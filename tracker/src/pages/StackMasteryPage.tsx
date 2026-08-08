import { useState, useMemo } from 'react'
import { ChevronDown, ChevronRight, CheckCircle2 } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { SM_PLAN, SM_PROJECTS } from '../data/sm-plan'

type Tab = 'plan' | 'projects'

const TRACK_COLORS: Record<string, { bg: string; text: string; border: string }> = {
  dotnet: { bg: 'bg-violet-100', text: 'text-violet-700', border: 'border-violet-300' },
  ai:     { bg: 'bg-emerald-100', text: 'text-emerald-700', border: 'border-emerald-300' },
  fe:     { bg: 'bg-amber-100', text: 'text-amber-700', border: 'border-amber-300' },
  both:   { bg: 'bg-indigo-100', text: 'text-indigo-700', border: 'border-indigo-300' },
}

const TRACK_LABELS: Record<string, string> = {
  dotnet: '.NET',
  ai: 'AI',
  fe: 'FE',
  both: 'Both',
}

export function StackMasteryPage() {
  const { data, toggleSM } = useProgress()
  const [tab, setTab] = useState<Tab>('plan')
  const [openWeeks, setOpenWeeks] = useState<Set<number>>(new Set([1]))

  const smTotal = useMemo(() => {
    let total = 0
    SM_PLAN.forEach(week => week.days.forEach(day => { total += day.items.length }))
    return total
  }, [])

  const stats = useMemo(() => {
    let done = 0, dotnet = 0, ai = 0, fe = 0
    SM_PLAN.forEach(week => week.days.forEach(day => day.items.forEach((item, i) => {
      const id = `sm_w${week.week}_d${day.day}_i${i}`
      if (data.sm_progress[id]?.done) {
        done++
        if (item.track === 'dotnet') dotnet++
        else if (item.track === 'ai') ai++
        else if (item.track === 'fe') fe++
      }
    })))
    return { done, dotnet, ai, fe }
  }, [data.sm_progress])

  const toggleWeek = (week: number) => {
    setOpenWeeks(prev => {
      const next = new Set(prev)
      next.has(week) ? next.delete(week) : next.add(week)
      return next
    })
  }

  const pct = smTotal > 0 ? Math.round((stats.done / smTotal) * 100) : 0

  return (
    <div className="max-w-4xl mx-auto space-y-6">
      {/* Header */}
      <header className="card p-6 overflow-hidden relative">
        <div className="absolute top-[-3rem] right-[-2rem] w-28 h-28 rounded-full border-2 border-[var(--border)] opacity-20 bg-amber-100" />
        <div className="relative z-10">
          <span className="pill bg-amber-50 text-amber-700 text-xs font-bold mb-2 inline-flex">
            Stack Mastery
          </span>
          <h1 className="font-display text-2xl md:text-3xl font-extrabold mt-2 leading-tight">
            Stack Mastery
          </h1>
          <p className="text-[var(--text-muted)] text-sm mt-1">
            .NET Deep + AI Engineer + Frontend · 13 weeks Phase 1
          </p>
        </div>

        {/* Progress bar */}
        <div className="mt-5">
          <div className="flex items-center justify-between text-xs font-bold mb-1.5">
            <span className="text-[var(--text-subtle)]">{stats.done} / {smTotal}</span>
            <span className="text-amber-600">{pct}%</span>
          </div>
          <div className="h-3 rounded-full bg-[var(--border-light)] border border-[var(--border)] overflow-hidden">
            <div
              className="h-full rounded-full transition-all duration-500"
              style={{ width: `${pct}%`, background: 'var(--track-sm)' }}
            />
          </div>
        </div>

        {/* Stats */}
        <div className="grid grid-cols-4 gap-3 mt-5">
          <StatBox value={stats.done} label="Done" color="var(--track-sm)" />
          <StatBox value={stats.dotnet} label=".NET" color="#7c3aed" />
          <StatBox value={stats.ai} label="AI" color="#10b981" />
          <StatBox value={stats.fe} label="Frontend" color="#f59e0b" />
        </div>
      </header>

      {/* Tabs */}
      <div className="flex gap-2">
        <TabButton active={tab === 'plan'} onClick={() => setTab('plan')} label="Plan" />
        <TabButton active={tab === 'projects'} onClick={() => setTab('projects')} label="Projects" />
      </div>

      {/* Plan Tab */}
      {tab === 'plan' && (
        <div className="space-y-3">
          {SM_PLAN.map(week => {
            const isOpen = openWeeks.has(week.week)
            const weekDone = week.days.reduce((acc, day) =>
              acc + day.items.filter((_, i) => data.sm_progress[`sm_w${week.week}_d${day.day}_i${i}`]?.done).length, 0)
            const weekTotal = week.days.reduce((acc, day) => acc + day.items.length, 0)
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
                    {allDone && <CheckCircle2 size={14} className="text-amber-500" />}
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
                        {day.items.map((item, i) => {
                          const id = `sm_w${week.week}_d${day.day}_i${i}`
                          const isDone = !!data.sm_progress[id]?.done
                          const isProject = item.name.includes('PROJECT') || item.name.includes('CAPSTONE')
                          const trackStyle = TRACK_COLORS[item.track] || TRACK_COLORS.dotnet

                          return (
                            <div
                              key={id}
                              className={`flex items-center gap-3 p-3 rounded-xl border-2 transition-all ${
                                isProject ? 'border-l-4 border-l-amber-400 ' : ''
                              }${
                                isDone
                                  ? 'border-amber-300 bg-amber-50/60 opacity-75'
                                  : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'
                              }`}
                            >
                              <button
                                onClick={() => toggleSM(id)}
                                className={`check-box ${isDone ? 'checked' : ''}`}
                                aria-label={isDone ? `Unmark ${item.name}` : `Mark ${item.name} done`}
                              >
                                {isDone && <CheckMark />}
                              </button>
                              <span className={`flex-1 text-sm font-medium ${isDone ? 'line-through text-[var(--text-subtle)]' : ''}`}>
                                {item.name}
                              </span>
                              <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${trackStyle.bg} ${trackStyle.text} ${trackStyle.border}`}>
                                {TRACK_LABELS[item.track]}
                              </span>
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

      {/* Projects Tab */}
      {tab === 'projects' && (
        <div className="space-y-2">
          {SM_PROJECTS.map((project, idx) => {
            const id = `sm_project_${idx}`
            const isDone = !!data.sm_progress[id]?.done
            const trackStyle = TRACK_COLORS[project.track] || TRACK_COLORS.dotnet

            return (
              <div
                key={idx}
                className={`flex items-center gap-3 p-4 rounded-xl border-2 transition-all ${
                  isDone
                    ? 'border-amber-300 bg-amber-50/60 opacity-75'
                    : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'
                }`}
              >
                <button
                  onClick={() => toggleSM(id)}
                  className={`check-box ${isDone ? 'checked' : ''}`}
                  aria-label={isDone ? `Unmark ${project.name}` : `Mark ${project.name} done`}
                >
                  {isDone && <CheckMark />}
                </button>
                <div className="flex-1 min-w-0">
                  <span className={`text-sm font-medium ${isDone ? 'line-through text-[var(--text-subtle)]' : ''}`}>
                    {project.name}
                  </span>
                </div>
                <span className="pill text-[10px] bg-white text-[var(--text-muted)] hidden sm:inline-flex">
                  Week {project.week}
                </span>
                <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${trackStyle.bg} ${trackStyle.text} ${trackStyle.border}`}>
                  {TRACK_LABELS[project.track]}
                </span>
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
          ? 'border-amber-400 bg-amber-50 text-amber-700 shadow-[2px_2px_0_0_rgba(245,158,11,0.3)]'
          : 'border-[var(--border-light)] bg-white text-[var(--text-muted)] hover:border-[var(--border)]'
      }`}
    >
      {label}
    </button>
  )
}

function CheckMark() {
  return (
    <svg width="10" height="8" viewBox="0 0 10 8" fill="none" className="text-white">
      <path d="M1 4L3.5 6.5L9 1" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" />
    </svg>
  )
}
