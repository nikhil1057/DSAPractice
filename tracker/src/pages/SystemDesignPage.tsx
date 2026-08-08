import { useState, useMemo } from 'react'
import { ChevronDown, ChevronRight, CheckCircle2 } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { SD_PLAN, SD_TOTAL } from '../data/sd-plan'

type Tab = 'plan' | 'categories'

export function SystemDesignPage() {
  const { data, toggleSD } = useProgress()
  const [tab, setTab] = useState<Tab>('plan')
  const [openWeeks, setOpenWeeks] = useState<Set<number>>(new Set([1]))

  const stats = useMemo(() => {
    const done = Object.keys(data.sd_progress).filter(k => data.sd_progress[k]?.done).length
    let beginner = 0, intermediate = 0, advanced = 0
    SD_PLAN.forEach(week => week.days.forEach(day => day.problems.forEach((p, i) => {
      const id = `sd_w${week.week}_d${day.day}_p${i}`
      if (data.sd_progress[id]?.done) {
        if (p.difficulty === 'beginner') beginner++
        else if (p.difficulty === 'intermediate') intermediate++
        else advanced++
      }
    })))
    return { done, beginner, intermediate, advanced }
  }, [data.sd_progress])

  const categories = useMemo(() => {
    const map: Record<string, { total: number; done: number }> = {}
    SD_PLAN.forEach(week => week.days.forEach(day => day.problems.forEach((p, i) => {
      if (!map[p.category]) map[p.category] = { total: 0, done: 0 }
      map[p.category].total++
      const id = `sd_w${week.week}_d${day.day}_p${i}`
      if (data.sd_progress[id]?.done) map[p.category].done++
    })))
    return Object.entries(map).map(([name, v]) => ({ name, ...v }))
  }, [data.sd_progress])

  const toggleWeek = (week: number) => {
    setOpenWeeks(prev => {
      const next = new Set(prev)
      next.has(week) ? next.delete(week) : next.add(week)
      return next
    })
  }

  const pct = Math.round((stats.done / SD_TOTAL) * 100)

  return (
    <div className="max-w-4xl mx-auto space-y-6 page-enter">
      {/* Header */}
      <header className="card p-6 overflow-hidden relative">
        <div className="absolute top-[-3rem] right-[-2rem] w-28 h-28 rounded-full border-2 border-[var(--border)] opacity-20 bg-emerald-100" />
        <div className="relative z-10">
          <span className="pill bg-emerald-50 text-emerald-700 text-xs font-bold mb-2 inline-flex">
            System Design
          </span>
          <h1 className="font-display text-2xl md:text-3xl font-extrabold mt-2 leading-tight">
            System Design
          </h1>
          <p className="text-[var(--text-muted)] text-sm mt-1">
            AlgoMaster · 85 days · Concepts → Technologies → Patterns → Problems
          </p>
        </div>

        {/* Progress bar */}
        <div className="mt-5">
          <div className="flex items-center justify-between text-xs font-bold mb-1.5">
            <span className="text-[var(--text-subtle)]">{stats.done} / {SD_TOTAL}</span>
            <span className="text-emerald-600">{pct}%</span>
          </div>
          <div className="h-3 rounded-full bg-[var(--border-light)] border border-[var(--border)] overflow-hidden">
            <div
              className="h-full rounded-full transition-all duration-500"
              style={{ width: `${pct}%`, background: 'var(--track-sd)' }}
            />
          </div>
        </div>

        {/* Stats */}
        <div className="grid grid-cols-4 gap-3 mt-5">
          <StatBox value={stats.done} label="Completed" color="var(--track-sd)" />
          <StatBox value={stats.beginner} label="Beginner" color="#10b981" />
          <StatBox value={stats.intermediate} label="Intermediate" color="#f59e0b" />
          <StatBox value={stats.advanced} label="Advanced" color="#ef4444" />
        </div>
      </header>

      {/* Tabs */}
      <div className="flex gap-2">
        <TabButton active={tab === 'plan'} onClick={() => setTab('plan')} label="Plan" />
        <TabButton active={tab === 'categories'} onClick={() => setTab('categories')} label="Categories" />
      </div>

      {/* Plan Tab */}
      {tab === 'plan' && (
        <div className="space-y-3">
          {SD_PLAN.map(week => {
            const isOpen = openWeeks.has(week.week)
            const weekDone = week.days.reduce((acc, day) =>
              acc + day.problems.filter((_, i) => data.sd_progress[`sd_w${week.week}_d${day.day}_p${i}`]?.done).length, 0)
            const weekTotal = week.days.reduce((acc, day) => acc + day.problems.length, 0)
            const allDone = weekDone === weekTotal && weekTotal > 0

            return (
              <div key={week.week} className="card overflow-hidden">
                <button
                  onClick={() => toggleWeek(week.week)}
                  className="w-full flex items-center gap-3 p-4 hover:bg-[var(--bg-hover)] transition-colors text-left"
                >
                  {isOpen
                    ? <ChevronDown size={16} className="text-[var(--text-subtle)] shrink-0" />
                    : <ChevronRight size={16} className="text-[var(--text-subtle)] shrink-0" />}
                  <div className="flex-1 min-w-0">
                    <div className="flex items-center gap-2">
                      <span className="font-display font-bold text-sm">Week {week.week}</span>
                      <span className="text-xs text-[var(--text-muted)] truncate">{week.title}</span>
                    </div>
                  </div>
                  <div className="flex items-center gap-2 shrink-0">
                    {allDone && <CheckCircle2 size={14} className="text-emerald-500" />}
                    <span className="font-mono text-xs text-[var(--text-subtle)]">{weekDone}/{weekTotal}</span>
                  </div>
                </button>

                {isOpen && (
                  <div className="px-4 pb-4 space-y-3">
                    {week.days.map(day => (
                      <div key={day.day} className="space-y-1.5">
                        <div className="text-[10px] uppercase font-bold tracking-wider text-[var(--text-subtle)] pl-1">
                          Day {day.day} · {day.date}
                        </div>
                        {day.problems.map((problem, i) => {
                          const id = `sd_w${week.week}_d${day.day}_p${i}`
                          const isDone = !!data.sd_progress[id]?.done
                          return (
                            <div
                              key={id}
                              className={`flex items-center gap-3 p-3 rounded-xl border-2 transition-all ${
                                isDone
                                  ? 'border-emerald-300 bg-emerald-50/60 opacity-75'
                                  : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'
                              }`}
                            >
                              <button
                                onClick={() => toggleSD(id)}
                                className={`check-box ${isDone ? 'checked' : ''}`}
                                aria-label={isDone ? `Unmark ${problem.name}` : `Mark ${problem.name} done`}
                              >
                                {isDone && <CheckMark />}
                              </button>
                              <span className={`flex-1 text-sm font-medium ${isDone ? 'line-through text-[var(--text-subtle)]' : ''}`}>
                                {problem.name}
                              </span>
                              <DifficultyBadge difficulty={problem.difficulty} />
                            </div>
                          )
                        })}
                      </div>
                    ))}
                  </div>
                )}
              </div>
            )
          })}
        </div>
      )}

      {/* Categories Tab */}
      {tab === 'categories' && (
        <div className="grid grid-cols-2 sm:grid-cols-3 gap-3">
          {categories.map(cat => {
            const catPct = cat.total > 0 ? Math.round((cat.done / cat.total) * 100) : 0
            return (
              <div key={cat.name} className="card p-4">
                <div className="flex items-center justify-between mb-2">
                  <span className="text-sm font-bold truncate">{cat.name}</span>
                  <span className="font-mono text-xs text-[var(--text-subtle)]">{cat.done}/{cat.total}</span>
                </div>
                <div className="h-2 rounded-full bg-[var(--border-light)] overflow-hidden">
                  <div
                    className="h-full rounded-full transition-all duration-300"
                    style={{ width: `${catPct}%`, background: 'var(--track-sd)' }}
                  />
                </div>
                <div className="text-[10px] text-[var(--text-muted)] mt-1.5 text-right">{catPct}%</div>
              </div>
            )
          })}
        </div>
      )}
    </div>
  )
}

// --- Sub-components ---

function StatBox({ value, label, color }: { value: number; label: string; color: string }) {
  return (
    <div className="card p-3 text-center">
      <div className="font-display font-extrabold text-lg" style={{ color }}>{value}</div>
      <div className="text-[10px] font-bold uppercase tracking-wider text-[var(--text-muted)] mt-0.5">{label}</div>
    </div>
  )
}

function TabButton({ active, onClick, label }: { active: boolean; onClick: () => void; label: string }) {
  return (
    <button
      onClick={onClick}
      className={`px-4 py-2 rounded-xl text-sm font-bold border-2 transition-all ${
        active
          ? 'border-emerald-400 bg-emerald-50 text-emerald-700 shadow-[2px_2px_0_0_rgba(16,185,129,0.3)]'
          : 'border-[var(--border-light)] bg-white text-[var(--text-muted)] hover:border-[var(--border)]'
      }`}
    >
      {label}
    </button>
  )
}

function DifficultyBadge({ difficulty }: { difficulty: string }) {
  const colors: Record<string, string> = {
    beginner: 'bg-emerald-50 text-emerald-700 border-emerald-200',
    intermediate: 'bg-amber-50 text-amber-700 border-amber-200',
    advanced: 'bg-red-50 text-red-700 border-red-200',
  }
  return (
    <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${colors[difficulty] || 'bg-gray-50 text-gray-600 border-gray-200'}`}>
      {difficulty}
    </span>
  )
}

function CheckMark() {
  return (
    <svg width="10" height="8" viewBox="0 0 10 8" fill="none" className="text-white">
      <path d="M1 4L3.5 6.5L9 1" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" />
    </svg>
  )
}
