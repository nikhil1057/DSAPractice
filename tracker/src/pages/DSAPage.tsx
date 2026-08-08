import { useState, useMemo } from 'react'
import { CheckCircle2, ChevronDown, ChevronRight, ExternalLink } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { DSA_PLAN, DSA_TOTAL, EXTRA_PROBLEMS, REVISION_CATEGORIES } from '../data/dsa-plan'
import { LEETCODE_URLS } from '../data/leetcode-urls'

type Tab = 'plan' | 'revision' | 'categories'

const START_DATE = new Date('2026-07-18')

function getCurrentDay(): number {
  const today = new Date()
  return Math.max(1, Math.floor((today.getTime() - START_DATE.getTime()) / 86400000) + 1)
}

function getCurrentWeek(): number {
  const dayNum = getCurrentDay()
  for (const week of DSA_PLAN) {
    for (const day of week.days) {
      if (day.day === dayNum) return week.week
    }
  }
  return 1
}

function formatDayDate(day: number): string {
  const d = new Date(START_DATE)
  d.setDate(d.getDate() + day - 1)
  return d.toLocaleDateString('en-US', { weekday: 'short', month: 'short', day: 'numeric' })
}

export function DSAPage() {
  const { data, toggleDSA, markRedone, markSolvedButSlow, markStruggled } = useProgress()
  const [tab, setTab] = useState<Tab>('plan')
  const currentWeek = getCurrentWeek()
  const currentDay = getCurrentDay()
  const [expandedWeeks, setExpandedWeeks] = useState<Set<number>>(() => new Set([currentWeek]))

  const stats = useMemo(() => {
    const solved = Object.keys(data.progress).length
    let easy = 0, medium = 0, hard = 0
    for (const week of DSA_PLAN) {
      for (const day of week.days) {
        day.problems.forEach((p, i) => {
          const id = `w${week.week}_d${day.day}_p${i}`
          if (data.progress[id]) {
            if (p.difficulty === 'easy') easy++
            else if (p.difficulty === 'medium') medium++
            else hard++
          }
        })
      }
    }
    // Count due reviews
    const now = Date.now()
    const dueReview = Object.values(data.revision).filter(
      (r: any) => r && !r.mastered && r.nextReview && r.nextReview <= now
    ).length

    return { solved, easy, medium, hard, dueReview }
  }, [data])

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
        <h1 className="font-display font-bold text-2xl md:text-3xl">150 Problems</h1>
        <p className="text-sm text-[var(--text-muted)] mt-1">
          3 problems/day · 48 days · Spaced repetition
        </p>

        {/* Progress bar */}
        <div className="mt-5">
          <div className="flex justify-between items-center mb-1.5">
            <span className="text-xs font-bold text-[var(--text-muted)]">
              {stats.solved} / {DSA_TOTAL} solved
            </span>
            <span className="text-xs font-mono text-[var(--text-subtle)]">
              {Math.round((stats.solved / DSA_TOTAL) * 100)}%
            </span>
          </div>
          <div className="progress-track">
            <div
              className="progress-fill progress-fill-gradient"
              style={{ width: `${(stats.solved / DSA_TOTAL) * 100}%` }}
            />
          </div>
        </div>

        {/* Stats row */}
        <div className="grid grid-cols-5 gap-3 mt-5">
          <StatBox value={stats.solved} label="Solved" color="var(--accent)" />
          <StatBox value={stats.easy} label="Easy" color="#059669" />
          <StatBox value={stats.medium} label="Medium" color="#f59e0b" />
          <StatBox value={stats.hard} label="Hard" color="#dc2626" />
          <StatBox value={stats.dueReview} label="Due Review" color="var(--overdue)" />
        </div>
      </header>

      {/* Tab bar */}
      <div className="flex gap-2">
        {(['plan', 'revision', 'categories'] as Tab[]).map(t => (
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
      {tab === 'plan' && <PlanTab data={data} toggleDSA={toggleDSA} expandedWeeks={expandedWeeks} toggleWeek={toggleWeek} currentDay={currentDay} />}
      {tab === 'revision' && <RevisionTab data={data} markRedone={markRedone} markSolvedButSlow={markSolvedButSlow} markStruggled={markStruggled} />}
      {tab === 'categories' && <CategoriesTab data={data} />}
    </div>
  )
}

// --- Plan Tab ---

function PlanTab({ data, toggleDSA, expandedWeeks, toggleWeek, currentDay }: {
  data: any; toggleDSA: any; expandedWeeks: Set<number>; toggleWeek: (w: number) => void; currentDay: number
}) {
  return (
    <div className="space-y-3">
      {DSA_PLAN.map(week => {
        const isExpanded = expandedWeeks.has(week.week)
        const weekSolved = week.days.reduce((acc, day) => {
          return acc + day.problems.filter((_: any, i: number) => {
            const id = `w${week.week}_d${day.day}_p${i}`
            return !!data.progress[id]
          }).length
        }, 0)
        const weekTotal = week.days.reduce((acc, day) => acc + day.problems.length, 0)

        return (
          <div key={week.week} className="card overflow-hidden">
            {/* Week header */}
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

            {/* Week content */}
            {isExpanded && (
              <div className="border-t-2 border-[var(--border-light)] px-4 pb-4">
                {week.days.map(day => {
                  const isToday = day.day === currentDay
                  return (
                    <div key={day.day} className="mt-4">
                      {/* Day label */}
                      <div className={`flex items-center gap-2 mb-2 ${isToday ? 'text-[var(--accent)]' : 'text-[var(--text-muted)]'}`}>
                        <span className="text-xs font-bold uppercase tracking-wider">
                          Day {day.day}
                        </span>
                        <span className="text-xs">{formatDayDate(day.day)}</span>
                        {isToday && <span className="pill text-[9px] bg-[var(--accent-soft)] text-[var(--accent-dark)]">Today</span>}
                      </div>

                      {/* Problems */}
                      <div className="space-y-1.5">
                        {day.problems.map((p: any, i: number) => {
                          const id = `w${week.week}_d${day.day}_p${i}`
                          const isDone = !!data.progress[id]
                          return (
                            <ProblemRow
                              key={id}
                              id={id}
                              name={p.name}
                              difficulty={p.difficulty}
                              category={p.category}
                              done={isDone}
                              isToday={isToday}
                              onToggle={() => toggleDSA(id, p.name, p.difficulty, p.category)}
                            />
                          )
                        })}
                      </div>
                    </div>
                  )
                })}
              </div>
            )}
          </div>
        )
      })}
    </div>
  )
}

// --- Revision Tab ---

function RevisionTab({ data, markRedone, markSolvedButSlow, markStruggled }: { data: any; markRedone: any; markSolvedButSlow: any; markStruggled: any }) {
  const [mockProblems, setMockProblems] = useState<Array<{ name: string; difficulty: string; category: string }>>([])

  const revisionStats = useMemo(() => {
    let mastered = 0, inProgress = 0, notStarted = 0
    const allProblems = DSA_PLAN.flatMap(w => w.days.flatMap(d => d.problems))
    const solvedNames = new Set(Object.values(data.revision).map((r: any) => r?.name).filter(Boolean))

    for (const p of allProblems) {
      if (!solvedNames.has(p.name)) {
        notStarted++
      } else {
        const rev = data.revision[p.name]
        if (rev?.mastered) mastered++
        else inProgress++
      }
    }
    return { mastered, inProgress, notStarted }
  }, [data])

  const redoQueue = useMemo(() => {
    const now = Date.now()
    const queue: Array<{ name: string; difficulty: string; category: string; overdueDays: number; redoCount: number }> = []

    // Get all solved problems
    const solved: Array<{ name: string; difficulty: string; category: string; solvedDate: string }> = []
    DSA_PLAN.forEach(week => {
      week.days.forEach(day => {
        day.problems.forEach((p, i) => {
          const id = `w${week.week}_d${day.day}_p${i}`
          if (data.progress[id]) {
            solved.push({ name: p.name, difficulty: p.difficulty, category: p.category, solvedDate: data.progress[id].date })
          }
        })
      })
    })
    EXTRA_PROBLEMS.forEach(p => solved.push({ name: p.name, difficulty: p.difficulty, category: p.category, solvedDate: p.solvedDate }))

    solved.forEach(p => {
      const redoData = data.revision_v2?.redos?.[p.name]
      const redoCount = redoData ? redoData.redo_count : 0
      const difficulty = redoData?.difficulty || p.difficulty
      const masteryCount = difficulty === 'easy' ? 2 : 4
      if (redoCount >= masteryCount) return

      const intervals = difficulty === 'easy' ? [1, 7] : difficulty === 'hard' ? [1, 3, 7, 30] : [1, 3, 7, 21]
      const baseDate = redoCount === 0
        ? new Date(p.solvedDate).getTime()
        : new Date(redoData!.last_redo!).getTime()
      const requiredInterval = intervals[Math.min(redoCount, intervals.length - 1)]
      const dueDate = baseDate + requiredInterval * 86400000

      if (dueDate <= now + 86400000) { // due today or overdue
        const overdueDays = Math.max(0, Math.floor((now - dueDate) / 86400000))
        queue.push({ name: p.name, difficulty, category: p.category, overdueDays, redoCount })
      }
    })

    // Priority: Hard > Medium > Easy, then most overdue
    const diffPriority: Record<string, number> = { hard: 3, medium: 2, easy: 1 }
    queue.sort((a, b) => {
      const dp = (diffPriority[b.difficulty] || 0) - (diffPriority[a.difficulty] || 0)
      if (dp !== 0) return dp
      return b.overdueDays - a.overdueDays
    })
    return queue
  }, [data])

  const patternHealth = useMemo(() => {
    const now = Date.now()
    return REVISION_CATEGORIES.map(cat => {
      const revisions = Object.values(data.revision).filter((r: any) => r?.category === cat) as any[]
      if (revisions.length === 0) return { category: cat, status: 'none', label: '—' }
      const mastered = revisions.filter((r: any) => r.mastered).length
      const overdue = revisions.filter((r: any) => !r.mastered && r.nextReview && r.nextReview <= now).length
      if (overdue > 0) return { category: cat, status: 'red', label: `${overdue} due` }
      if (mastered === revisions.length) return { category: cat, status: 'green', label: 'Mastered' }
      return { category: cat, status: 'yellow', label: `${mastered}/${revisions.length}` }
    })
  }, [data])

  const generateMock = () => {
    const allProblems = DSA_PLAN.flatMap(w => w.days.flatMap(d => d.problems))
    const categories = [...REVISION_CATEGORIES].sort(() => Math.random() - 0.5).slice(0, 4)
    const picks: Array<{ name: string; difficulty: string; category: string }> = []
    for (const cat of categories) {
      const pool = allProblems.filter(p => p.category === cat)
      if (pool.length > 0) {
        picks.push(pool[Math.floor(Math.random() * pool.length)])
      }
    }
    setMockProblems(picks)
  }

  return (
    <div className="space-y-5">
      {/* Stats */}
      <div className="grid grid-cols-3 gap-3">
        <div className="card p-4 text-center">
          <div className="font-display font-bold text-xl text-[var(--solved)]">{revisionStats.mastered}</div>
          <div className="text-xs font-bold uppercase tracking-wider text-[var(--text-muted)]">Mastered</div>
        </div>
        <div className="card p-4 text-center">
          <div className="font-display font-bold text-xl text-[var(--in-progress)]">{revisionStats.inProgress}</div>
          <div className="text-xs font-bold uppercase tracking-wider text-[var(--text-muted)]">In Progress</div>
        </div>
        <div className="card p-4 text-center">
          <div className="font-display font-bold text-xl text-[var(--text-subtle)]">{revisionStats.notStarted}</div>
          <div className="text-xs font-bold uppercase tracking-wider text-[var(--text-muted)]">Not Started</div>
        </div>
      </div>

      {/* Redo Queue */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Redo Queue</h2>
        {redoQueue.length === 0 ? (
          <div className="text-center py-6 text-[var(--text-muted)] text-sm">
            <CheckCircle2 size={24} className="mx-auto mb-2 text-[var(--solved)]" />
            No problems due for revision — you're all caught up!
          </div>
        ) : (
          <div className="space-y-2">
            {redoQueue.slice(0, 8).map(p => (
              <div key={p.name} className="flex flex-col gap-2 p-3 rounded-xl border-2 border-[var(--border-light)] bg-white">
                <div className="flex items-center gap-2 min-w-0 flex-wrap">
                  <ProblemLink name={p.name} />
                  <DifficultyBadge difficulty={p.difficulty} />
                  {p.overdueDays > 0 && (
                    <span className="pill text-[10px] bg-[var(--overdue-soft)] text-[var(--overdue)]">
                      {p.overdueDays}d overdue
                    </span>
                  )}
                  <span className="text-[10px] text-[var(--text-subtle)] font-mono ml-auto">
                    redo {(p.redoCount || 0) + 1}/{p.difficulty === 'easy' ? 2 : 4}
                  </span>
                </div>
                <div className="flex gap-1.5 flex-wrap">
                  <button onClick={() => markStruggled(p.name)} className="btn-secondary text-xs py-1.5 px-2.5">
                    Struggled
                  </button>
                  <button onClick={() => markSolvedButSlow(p.name, p.difficulty)} className="btn-secondary text-xs py-1.5 px-2.5">
                    Slow
                  </button>
                  <button onClick={() => markRedone(p.name, p.difficulty)} className="btn-primary text-xs py-1.5 px-2.5">
                    Solved Clean
                  </button>
                </div>
              </div>
            ))}
          </div>
        )}
      </section>

      {/* Pattern Health */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Pattern Health</h2>
        <div className="grid grid-cols-2 sm:grid-cols-3 gap-2">
          {patternHealth.map(p => (
            <div key={p.category} className="flex items-center gap-2 px-3 py-2 rounded-lg border border-[var(--border-light)]">
              <div className={`w-2.5 h-2.5 rounded-full shrink-0 ${
                p.status === 'green' ? 'bg-emerald-400 shadow-[0_0_6px_rgba(52,211,153,0.5)]' :
                p.status === 'yellow' ? 'bg-amber-400 shadow-[0_0_6px_rgba(251,191,36,0.5)]' :
                p.status === 'red' ? 'bg-red-400 shadow-[0_0_6px_rgba(248,113,113,0.5)]' :
                'bg-gray-300'
              }`} />
              <span className="text-xs font-medium text-[var(--text)] truncate">{p.category}</span>
              <span className="ml-auto text-[10px] text-[var(--text-subtle)] font-mono">{p.label}</span>
            </div>
          ))}
        </div>
      </section>

      {/* Weekend Mock */}
      <section className="card p-5">
        <div className="flex items-center justify-between mb-4">
          <h2 className="font-display font-bold text-lg">Weekend Mock</h2>
          <button onClick={generateMock} className="btn-primary text-xs">
            Generate 4 Problems
          </button>
        </div>
        {mockProblems.length > 0 ? (
          <div className="space-y-2">
            {mockProblems.map((p, i) => (
              <div key={i} className="flex items-center gap-3 p-3 rounded-xl border-2 border-[var(--border-light)] bg-white">
                <span className="font-mono text-xs text-[var(--text-subtle)] w-5">{i + 1}.</span>
                <ProblemLink name={p.name} />
                <span className="pill text-[10px] bg-white">{p.category}</span>
                <DifficultyBadge difficulty={p.difficulty} />
              </div>
            ))}
          </div>
        ) : (
          <p className="text-sm text-[var(--text-muted)]">
            Click "Generate 4 Problems" to get a random set from different categories.
          </p>
        )}
      </section>
    </div>
  )
}

// --- Categories Tab ---

function CategoriesTab({ data }: { data: any }) {
  const categoryStats = useMemo(() => {
    return REVISION_CATEGORIES.map(cat => {
      let total = 0, solved = 0
      for (const week of DSA_PLAN) {
        for (const day of week.days) {
          day.problems.forEach((p: any, i: number) => {
            if (p.category === cat) {
              total++
              const id = `w${week.week}_d${day.day}_p${i}`
              if (data.progress[id]) solved++
            }
          })
        }
      }
      return { category: cat, solved, total }
    })
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
            {c.total > 0 ? `${Math.round((c.solved / c.total) * 100)}% complete` : 'No problems'}
          </div>
        </div>
      ))}
    </div>
  )
}

// --- Shared Sub-components ---

function ProblemRow({ id, name, difficulty, category, done, isToday, onToggle }: {
  id: string; name: string; difficulty: string; category: string; done: boolean; isToday: boolean; onToggle: () => void
}) {
  const url = LEETCODE_URLS[name]
  return (
    <div className={`flex items-center gap-3 p-3 rounded-xl border-2 transition-all ${
      done
        ? 'border-[var(--solved)] bg-[var(--solved-soft)] opacity-70'
        : isToday
        ? 'border-l-4 border-l-violet-500 border-[var(--border-light)] bg-white hover:border-[var(--border)]'
        : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'
    }`}>
      <button
        onClick={onToggle}
        className={`check-box ${done ? 'checked' : ''}`}
        aria-label={done ? `Unmark ${name}` : `Mark ${name} done`}
      >
        {done && <CheckMark />}
      </button>
      <span className={`flex-1 text-sm font-medium min-w-0 truncate ${done ? 'line-through text-[var(--text-subtle)]' : ''}`}>
        {url ? (
          <a href={url} target="_blank" rel="noopener noreferrer" className="hover:text-[var(--accent)] inline-flex items-center gap-1">
            {name} <ExternalLink size={11} className="opacity-40" />
          </a>
        ) : name}
      </span>
      <span className="pill text-[10px] bg-white hidden sm:inline-flex">{category}</span>
      <DifficultyBadge difficulty={difficulty} />
    </div>
  )
}

function ProblemLink({ name }: { name: string }) {
  const url = LEETCODE_URLS[name]
  return url
    ? <a href={url} target="_blank" rel="noopener noreferrer" className="text-sm font-medium hover:text-[var(--accent)] truncate inline-flex items-center gap-1">
        {name} <ExternalLink size={11} className="opacity-40" />
      </a>
    : <span className="text-sm font-medium truncate">{name}</span>
}

function DifficultyBadge({ difficulty }: { difficulty: string }) {
  const colors: Record<string, string> = {
    easy: 'bg-emerald-50 text-emerald-700 border-emerald-200',
    medium: 'bg-amber-50 text-amber-700 border-amber-200',
    hard: 'bg-red-50 text-red-700 border-red-200',
  }
  return (
    <span className={`inline-flex items-center px-2 py-0.5 rounded-full text-[10px] font-bold border ${colors[difficulty] || 'bg-gray-50 text-gray-600 border-gray-200'}`}>
      {difficulty}
    </span>
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
