import { useState, useMemo } from 'react'
import { ChevronDown, ChevronRight, CheckCircle2 } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { DESIGN_PLAN, DESIGN_TOTAL, DESIGN_PHASES } from '../data/design-plan'

type Tab = 'plan' | 'categories'

const PHASE_COLORS: Record<number, string> = {
  1: 'blue',
  2: 'violet',
  3: 'emerald',
  4: 'amber',
  5: 'rose',
}

const PHASE_BORDER: Record<number, string> = {
  1: 'border-l-blue-500',
  2: 'border-l-violet-500',
  3: 'border-l-emerald-500',
  4: 'border-l-amber-500',
  5: 'border-l-rose-500',
}

const PHASE_PILL_ACTIVE: Record<number, string> = {
  1: 'bg-blue-100 text-blue-700 border-blue-300',
  2: 'bg-violet-100 text-violet-700 border-violet-300',
  3: 'bg-emerald-100 text-emerald-700 border-emerald-300',
  4: 'bg-amber-100 text-amber-700 border-amber-300',
  5: 'bg-rose-100 text-rose-700 border-rose-300',
}

const TYPE_BADGE: Record<string, string> = {
  lld: 'bg-violet-50 text-violet-700 border-violet-200',
  hld: 'bg-emerald-50 text-emerald-700 border-emerald-200',
  theory: 'bg-gray-50 text-gray-600 border-gray-200',
  pattern: 'bg-blue-50 text-blue-700 border-blue-200',
  build: 'bg-amber-50 text-amber-700 border-amber-200',
}

const TYPE_LABEL: Record<string, string> = {
  lld: 'LLD',
  hld: 'HLD',
  theory: 'Theory',
  pattern: 'Pattern',
  build: 'Build',
}

const DIFFICULTY_BADGE: Record<string, string> = {
  beginner: 'bg-emerald-50 text-emerald-700 border-emerald-200',
  intermediate: 'bg-amber-50 text-amber-700 border-amber-200',
  advanced: 'bg-red-50 text-red-700 border-red-200',
}

const START_DATE = new Date('2026-08-11')

function getCurrentWeek(): number {
  const today = new Date()
  const daysSinceStart = Math.floor((today.getTime() - START_DATE.getTime()) / 86400000)
  if (daysSinceStart < 0) return 1
  // Find week based on date matching
  for (const week of DESIGN_PLAN) {
    for (const day of week.days) {
      // Parse "Aug 11" style dates relative to 2026
      const dateStr = `${day.date} 2026`
      const d = new Date(dateStr)
      if (d.toDateString() === today.toDateString()) return week.week
    }
  }
  // Fallback: calculate by week number
  const weekNum = Math.floor(daysSinceStart / 7) + 1
  const maxWeek = DESIGN_PLAN[DESIGN_PLAN.length - 1].week
  return Math.min(weekNum, maxWeek)
}

function getCurrentPhase(completedCount: number): number {
  // Determine current phase by what percentage is done
  let cumulative = 0
  for (const phase of DESIGN_PHASES) {
    const phaseWeeks = DESIGN_PLAN.filter(w => w.phase === phase.phase)
    const phaseItems = phaseWeeks.reduce((a, w) => a + w.days.reduce((b, d) => b + d.items.length, 0), 0)
    cumulative += phaseItems
    if (completedCount < cumulative) return phase.phase
  }
  return 5
}

export function DesignPage() {
  const { data, toggleSD } = useProgress()
  const [tab, setTab] = useState<Tab>('plan')
  const currentWeek = getCurrentWeek()
  const [expandedWeeks, setExpandedWeeks] = useState<Set<number>>(() => new Set([currentWeek]))

  const stats = useMemo(() => {
    let total = 0, lld = 0, hld = 0, theory = 0
    for (const week of DESIGN_PLAN) {
      for (const day of week.days) {
        day.items.forEach((item, i) => {
          const key = `design_w${week.week}_d${day.day}_i${i}`
          if (data.sd_progress[key]) {
            total++
            if (item.type === 'lld' || item.type === 'build') lld++
            else if (item.type === 'hld') hld++
            else if (item.type === 'theory' || item.type === 'pattern') theory++
          }
        })
      }
    }
    return { total, lld, hld, theory }
  }, [data])

  const currentPhase = getCurrentPhase(stats.total)

  const toggleWeek = (week: number) => {
    setExpandedWeeks(prev => {
      const next = new Set(prev)
      if (next.has(week)) next.delete(week)
      else next.add(week)
      return next
    })
  }

  return (
    <div className="max-w-4xl mx-auto space-y-6 page-enter">
      {/* Header */}
      <header className="card p-6">
        <h1 className="font-display font-bold text-2xl md:text-3xl">Design</h1>
        <p className="text-sm text-[var(--text-muted)] mt-1">
          LLD + System Design · Unified Track · 16 weeks
        </p>

        {/* Phase indicators */}
        <div className="flex flex-wrap gap-2 mt-4">
          {DESIGN_PHASES.map(p => (
            <span
              key={p.phase}
              className={`inline-flex items-center px-2.5 py-1 rounded-full text-[10px] font-bold border ${
                p.phase === currentPhase
                  ? PHASE_PILL_ACTIVE[p.phase]
                  : p.phase < currentPhase
                  ? 'bg-gray-100 text-gray-500 border-gray-200 line-through'
                  : 'bg-white text-[var(--text-subtle)] border-[var(--border-light)]'
              }`}
            >
              P{p.phase}: {p.name}
            </span>
          ))}
        </div>

        {/* Progress bar */}
        <div className="mt-5">
          <div className="flex justify-between items-center mb-1.5">
            <span className="text-xs font-bold text-[var(--text-muted)]">
              {stats.total} / {DESIGN_TOTAL} completed
            </span>
            <span className="text-xs font-mono text-[var(--text-subtle)]">
              {Math.round((stats.total / DESIGN_TOTAL) * 100)}%
            </span>
          </div>
          <div className="progress-track">
            <div
              className="progress-fill progress-fill-gradient"
              style={{ width: `${(stats.total / DESIGN_TOTAL) * 100}%` }}
            />
          </div>
        </div>

        {/* Stats row */}
        <div className="grid grid-cols-4 gap-3 mt-5">
          <StatBox value={stats.total} label="Done" color="var(--accent)" />
          <StatBox value={stats.lld} label="LLD" color="#7c3aed" />
          <StatBox value={stats.hld} label="HLD" color="#059669" />
          <StatBox value={stats.theory} label="Theory" color="#6b7280" />
        </div>
      </header>

      {/* Tab bar */}
      <div className="flex gap-2">
        {(['plan', 'categories'] as Tab[]).map(t => (
          <button
            key={t}
            onClick={() => setTab(t)}
            className={`btn-secondary capitalize ${tab === t ? '!bg-[var(--accent-soft)] !border-[var(--accent)]' : ''}`}
          >
            {t}
          </button>
        ))}
      </div>

      {/* Tab content */}
      {tab === 'plan' && (
        <PlanTab
          data={data}
          toggleSD={toggleSD}
          expandedWeeks={expandedWeeks}
          toggleWeek={toggleWeek}
        />
      )}
      {tab === 'categories' && <CategoriesTab data={data} />}
    </div>
  )
}

// --- Plan Tab ---

function PlanTab({ data, toggleSD, expandedWeeks, toggleWeek }: {
  data: any; toggleSD: (id: string) => void; expandedWeeks: Set<number>; toggleWeek: (w: number) => void
}) {
  let lastPhase = 0

  return (
    <div className="space-y-3">
      {DESIGN_PLAN.map(week => {
        const showPhaseHeader = week.phase !== lastPhase
        lastPhase = week.phase
        const isExpanded = expandedWeeks.has(week.week)

        const weekSolved = week.days.reduce((acc, day) => {
          return acc + day.items.filter((_, i) => {
            const key = `design_w${week.week}_d${day.day}_i${i}`
            return !!data.sd_progress[key]
          }).length
        }, 0)
        const weekTotal = week.days.reduce((acc, day) => acc + day.items.length, 0)

        return (
          <div key={week.week}>
            {/* Phase header */}
            {showPhaseHeader && (
              <div className="flex items-center gap-3 mt-6 mb-3 first:mt-0">
                <div className={`w-3 h-3 rounded-full bg-${PHASE_COLORS[week.phase]}-400`} />
                <h2 className="font-display font-bold text-sm text-[var(--text-muted)] uppercase tracking-wider">
                  Phase {week.phase}: {DESIGN_PHASES[week.phase - 1].name}
                </h2>
                <span className="text-[10px] text-[var(--text-subtle)]">
                  {DESIGN_PHASES[week.phase - 1].description}
                </span>
              </div>
            )}

            {/* Week accordion */}
            <div className={`card overflow-hidden border-l-4 ${PHASE_BORDER[week.phase]}`}>
              <button
                onClick={() => toggleWeek(week.week)}
                className="w-full flex items-center gap-3 p-4 text-left hover:bg-[var(--bg-deep)] transition-colors"
              >
                {isExpanded
                  ? <ChevronDown size={18} className="text-[var(--accent)] shrink-0" />
                  : <ChevronRight size={18} className="text-[var(--text-subtle)] shrink-0" />
                }
                <div className="flex-1 min-w-0">
                  <div className="flex items-center gap-2">
                    <span className="font-display font-bold text-sm">Week {week.week}</span>
                    <span className="text-xs text-[var(--text-muted)] truncate">{week.title}</span>
                  </div>
                </div>
                <span className={`font-mono text-xs px-2 py-0.5 rounded-full border ${
                  weekSolved === weekTotal
                    ? 'bg-emerald-50 text-emerald-700 border-emerald-200'
                    : 'bg-gray-50 text-[var(--text-subtle)] border-[var(--border-light)]'
                }`}>
                  {weekSolved}/{weekTotal}
                </span>
              </button>

              {isExpanded && (
                <div className="border-t-2 border-[var(--border-light)] px-4 pb-4">
                  {week.days.map(day => (
                    <div key={day.day} className="mt-4">
                      <div className="flex items-center gap-2 mb-2 text-[var(--text-muted)]">
                        <span className="text-xs font-bold uppercase tracking-wider">
                          Day {day.day}
                        </span>
                        <span className="text-xs">{day.date}</span>
                      </div>

                      <div className="space-y-1.5">
                        {day.items.map((item, i) => {
                          const key = `design_w${week.week}_d${day.day}_i${i}`
                          const isDone = !!data.sd_progress[key]
                          return (
                            <DesignItemRow
                              key={key}
                              itemKey={key}
                              item={item}
                              done={isDone}
                              onToggle={() => toggleSD(key)}
                            />
                          )
                        })}
                      </div>
                    </div>
                  ))}
                </div>
              )}
            </div>
          </div>
        )
      })}
    </div>
  )
}

// --- Categories Tab ---

function CategoriesTab({ data }: { data: any }) {
  const categoryStats = useMemo(() => {
    const map: Record<string, { solved: number; total: number }> = {}
    for (const week of DESIGN_PLAN) {
      for (const day of week.days) {
        day.items.forEach((item, i) => {
          if (!map[item.category]) map[item.category] = { solved: 0, total: 0 }
          map[item.category].total++
          const key = `design_w${week.week}_d${day.day}_i${i}`
          if (data.sd_progress[key]) map[item.category].solved++
        })
      }
    }
    return Object.entries(map)
      .map(([category, s]) => ({ category, ...s }))
      .sort((a, b) => b.total - a.total)
  }, [data])

  return (
    <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-3">
      {categoryStats.map(c => (
        <div key={c.category} className="card p-5">
          <div className="flex items-center justify-between mb-3">
            <h3 className="font-display font-bold text-sm">{c.category}</h3>
            <span className="font-mono text-xs text-[var(--text-subtle)]">
              {c.solved}/{c.total}
            </span>
          </div>
          <div className="progress-track">
            <div
              className="progress-fill"
              style={{
                width: c.total > 0 ? `${(c.solved / c.total) * 100}%` : '0%',
                background: c.solved === c.total && c.total > 0 ? 'var(--solved)' : 'var(--accent)'
              }}
            />
          </div>
          <div className="mt-2 text-[10px] text-[var(--text-muted)] font-semibold uppercase tracking-wider">
            {c.total > 0 ? `${Math.round((c.solved / c.total) * 100)}% complete` : 'No items'}
          </div>
        </div>
      ))}
    </div>
  )
}

// --- Shared Components ---

function DesignItemRow({ itemKey, item, done, onToggle }: {
  itemKey: string; item: any; done: boolean; onToggle: () => void
}) {
  return (
    <div className={`flex items-center gap-3 p-3 rounded-xl border-2 transition-all ${
      done
        ? 'border-[var(--solved)] bg-[var(--solved-soft)] opacity-70'
        : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'
    }`}>
      <button
        onClick={onToggle}
        className={`check-box ${done ? 'checked' : ''}`}
        aria-label={done ? `Unmark ${item.name}` : `Mark ${item.name} done`}
      >
        {done && <CheckMark />}
      </button>

      <span className={`flex-1 text-sm font-medium min-w-0 truncate ${done ? 'line-through text-[var(--text-subtle)]' : ''}`}>
        {item.name}
      </span>

      {/* Type badge */}
      <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${TYPE_BADGE[item.type]} hidden sm:inline-flex`}>
        {TYPE_LABEL[item.type]}
      </span>

      {/* Difficulty badge */}
      <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${DIFFICULTY_BADGE[item.difficulty]}`}>
        {item.difficulty}
      </span>

      {/* Tags */}
      {item.tags && item.tags.length > 0 && (
        <div className="hidden md:flex gap-1">
          {item.tags.map((tag: string) => (
            <span key={tag} className="pill text-[9px] bg-[var(--bg-deep)] text-[var(--text-subtle)]">
              {tag}
            </span>
          ))}
        </div>
      )}
    </div>
  )
}

function StatBox({ value, label, color }: { value: number; label: string; color: string }) {
  return (
    <div className="text-center">
      <div className="font-display font-bold text-lg" style={{ color }}>{value}</div>
      <div className="text-[10px] font-bold uppercase tracking-wider text-[var(--text-muted)]">{label}</div>
    </div>
  )
}

function CheckMark() {
  return (
    <svg width="10" height="8" viewBox="0 0 10 8" fill="none" className="text-white">
      <path d="M1 4L3.5 6.5L9 1" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" />
    </svg>
  )
}
