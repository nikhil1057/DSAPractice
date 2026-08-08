import { useMemo } from 'react'
import { Link } from 'react-router-dom'
import { ArrowRight, AlertTriangle, CheckCircle2, Flame, Calendar } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { DSA_PLAN, DSA_TOTAL, EXTRA_PROBLEMS, REVISION_CATEGORIES } from '../data/dsa-plan'
import { LEETCODE_URLS } from '../data/leetcode-urls'

export function Dashboard() {
  const { data, toggleDSA, markRedone, markSolvedButSlow, markStruggled } = useProgress()

  const ctx = useMemo(() => computeTodayContext(data), [data])

  return (
    <div className="max-w-4xl mx-auto space-y-6">
      {/* Hero */}
      <header className="card p-6 overflow-hidden relative">
        <div className="absolute top-[-3rem] right-[-2rem] w-28 h-28 rounded-full border-2 border-[var(--border)] opacity-20 bg-[var(--accent-soft)]" />
        <div className="relative z-10">
          <div className="flex items-center gap-2 mb-1">
            <span className="pill bg-[var(--accent-soft)] text-[var(--accent-dark)]">
              <Calendar size={12} /> Day {ctx.dayNumber}
            </span>
            <span className="pill bg-white text-[var(--text-muted)]">Week {ctx.currentWeekNum}</span>
          </div>
          <h1 className="font-display text-2xl md:text-3xl font-extrabold mt-3 leading-tight">
            {ctx.currentWeekTitle || 'Your Practice Journey'}
          </h1>
          <p className="text-[var(--text-muted)] text-sm mt-1">
            {new Date().toLocaleDateString('en-US', { weekday: 'long', month: 'long', day: 'numeric', year: 'numeric' })}
          </p>
        </div>

        {/* Stats */}
        <div className="grid grid-cols-3 gap-3 mt-5">
          <StatCard value={ctx.totalSolved} label="Solved" color="var(--accent)" />
          <StatCard value={ctx.overdueRedos.length} label="Overdue" color="var(--overdue)" />
          <StatCard value={`${ctx.streak}d`} label="Streak" color="var(--in-progress)" icon={<Flame size={14} className="text-amber-500" />} />
        </div>
      </header>

      {/* Today's Focus */}
      <section className="card p-5">
        <div className="flex items-center justify-between mb-4">
          <div className="flex items-center gap-2">
            <h2 className="font-display font-bold text-lg">Today's Focus</h2>
            {ctx.behindSchedule && (
              <span className="pill bg-[var(--in-progress-soft)] text-amber-700 text-[10px]">
                {ctx.daysBehind}d behind · Day {ctx.currentDayInWeek} of plan
              </span>
            )}
          </div>
          <Link to="/dsa" className="text-xs font-semibold text-[var(--accent)] hover:underline flex items-center gap-1">
            Full plan <ArrowRight size={12} />
          </Link>
        </div>

        {ctx.todayProblems.length > 0 ? (
          <div className="space-y-2">
            <div className="text-xs font-bold text-[var(--text-subtle)] uppercase tracking-wider mb-2">
              {ctx.behindSchedule ? 'Next up' : 'DSA'} · {ctx.todayCategory}
            </div>
            {ctx.todayProblems.map((p) => {
              const isDone = !!data.progress[p.id]
              return (
                <ProblemRow
                  key={p.id}
                  name={p.name}
                  difficulty={p.difficulty}
                  category={p.category}
                  done={isDone}
                  onToggle={() => toggleDSA(p.id, p.name, p.difficulty, p.category)}
                />
              )
            })}
          </div>
        ) : (
          <div className="text-center py-6 text-[var(--text-muted)] text-sm">
            <CheckCircle2 size={24} className="mx-auto mb-2 text-[var(--solved)]" />
            No problems scheduled for today — or you're ahead of schedule!
          </div>
        )}
      </section>

      {/* Overdue Revisions */}
      {ctx.overdueRedos.length > 0 && (
        <section className="card p-5 border-[var(--overdue)] border-opacity-50">
          <div className="flex items-center gap-2 mb-4">
            <AlertTriangle size={16} className="text-[var(--overdue)]" />
            <h2 className="font-display font-bold text-lg">Revision Due</h2>
            <span className="pill bg-[var(--overdue-soft)] text-[var(--overdue)] text-xs">{ctx.overdueRedos.length}</span>
          </div>
          <div className="space-y-2">
            {ctx.overdueRedos.slice(0, 5).map(p => (
              <div key={p.name} className="flex flex-col gap-2 p-3 rounded-xl border-2 border-[var(--border-light)] bg-white">
                <div className="flex items-center gap-2 min-w-0 flex-wrap">
                  <ProblemLink name={p.name} />
                  <DifficultyBadge difficulty={p.difficulty} />
                  <span className="pill text-[10px] bg-[var(--overdue-soft)] text-[var(--overdue)]">
                    {p.overdue_days}d overdue
                  </span>
                  <span className="text-[10px] text-[var(--text-subtle)] font-mono ml-auto">
                    redo {p.redo_count + 1}/{p.difficulty === 'easy' ? 2 : 4}
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
        </section>
      )}

      {/* This Week Strip */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">This Week</h2>
        <div className="flex items-center gap-2 overflow-x-auto pb-2">
          {ctx.thisWeekDays.map(d => {
            const solved = d.problems.filter((_: any, i: number) => {
              const id = `w${ctx.currentWeekNum}_d${d.day}_p${i}`
              return !!data.progress[id]
            }).length
            const total = d.problems.length
            const isToday = d.day === ctx.dayNumber
            const allDone = solved === total

            return (
              <div
                key={d.day}
                className={`flex flex-col items-center gap-1 px-3 py-2 rounded-xl border-2 min-w-[4rem] transition-all ${
                  isToday
                    ? 'border-[var(--accent)] bg-[var(--accent-soft)] shadow-[var(--shadow-pop)]'
                    : allDone
                    ? 'border-[var(--solved)] bg-[var(--solved-soft)]'
                    : 'border-[var(--border-light)] bg-white'
                }`}
              >
                <span className="font-mono text-xs text-[var(--text-subtle)]">D{d.day}</span>
                <span className={`font-display font-bold text-sm ${allDone ? 'text-[var(--solved)]' : isToday ? 'text-[var(--accent)]' : 'text-[var(--text)]'}`}>
                  {solved}/{total}
                </span>
                <span className="text-[10px] text-[var(--text-muted)]">{d.date.split(' ')[0]} {d.date.split(' ')[1]}</span>
              </div>
            )
          })}
        </div>
      </section>

      {/* Next Week Preview */}
      {ctx.nextWeek && (
        <section className="card p-5">
          <h2 className="font-display font-bold text-lg mb-2">Next Week Preview</h2>
          <div className="text-sm font-semibold text-[var(--text)]">
            Week {ctx.nextWeek.week}: {ctx.nextWeek.title}
          </div>
          <div className="mt-2 flex flex-wrap gap-1.5">
            {getNextWeekCategories(ctx.nextWeek).map(cat => (
              <span key={cat} className="pill bg-[var(--accent-soft)] text-[var(--accent-dark)] text-[10px]">{cat}</span>
            ))}
          </div>
          <div className="mt-2 text-xs text-[var(--text-muted)]">
            {ctx.nextWeek.days.reduce((a, d) => a + d.problems.length, 0)} problems ·{' '}
            {ctx.nextWeek.days.reduce((a, d) => a + d.problems.filter(p => p.difficulty === 'hard').length, 0)} hard
          </div>
        </section>
      )}

      {/* Pattern Health (compact) */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Pattern Health</h2>
        <div className="grid grid-cols-2 sm:grid-cols-3 md:grid-cols-4 gap-2">
          {ctx.patternHealth.map(p => (
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
    </div>
  )
}

// --- Sub-components ---

function StatCard({ value, label, color, icon }: { value: string | number; label: string; color: string; icon?: React.ReactNode }) {
  return (
    <div className="card p-4 overflow-hidden relative">
      <div className="absolute top-[-1.5rem] right-[-1rem] w-12 h-12 rounded-full border border-[var(--border-light)] opacity-30" style={{ background: color }} />
      <div className="relative z-10">
        <div className="flex items-center gap-1">
          {icon}
          <span className="font-display font-extrabold text-xl" style={{ color }}>{value}</span>
        </div>
        <div className="text-xs font-bold uppercase tracking-wider text-[var(--text-muted)] mt-0.5">{label}</div>
      </div>
    </div>
  )
}

function ProblemRow({ name, difficulty, category, done, onToggle }: { name: string; difficulty: string; category: string; done: boolean; onToggle: () => void }) {
  const url = LEETCODE_URLS[name]
  return (
    <div className={`flex items-center gap-3 p-3 rounded-xl border-2 transition-all ${done ? 'border-[var(--solved)] bg-[var(--solved-soft)] opacity-70' : 'border-[var(--border-light)] bg-white hover:border-[var(--border)]'}`}>
      <button
        onClick={onToggle}
        className={`check-box ${done ? 'checked' : ''}`}
        aria-label={done ? `Unmark ${name}` : `Mark ${name} done`}
      >
        {done && <CheckMark />}
      </button>
      <span className={`flex-1 text-sm font-medium ${done ? 'line-through text-[var(--text-subtle)]' : ''}`}>
        {url ? <a href={url} target="_blank" rel="noopener noreferrer" className="hover:text-[var(--accent)] border-b border-dashed border-[var(--border-light)] hover:border-[var(--accent)]">{name}</a> : name}
      </span>
      <span className="pill text-[10px] bg-white hidden sm:inline-flex">{category}</span>
      <DifficultyBadge difficulty={difficulty} />
    </div>
  )
}

function ProblemLink({ name }: { name: string }) {
  const url = LEETCODE_URLS[name]
  return url
    ? <a href={url} target="_blank" rel="noopener noreferrer" className="text-sm font-medium hover:text-[var(--accent)] truncate">{name}</a>
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

function CheckMark() {
  return (
    <svg width="10" height="8" viewBox="0 0 10 8" fill="none" className="text-white">
      <path d="M1 4L3.5 6.5L9 1" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" />
    </svg>
  )
}

// --- Computation helpers ---

interface OverdueRedo {
  name: string
  difficulty: string
  category: string
  overdue_days: number
  redo_count: number
}

function computeTodayContext(data: ReturnType<typeof useProgress>['data']) {
  const startDate = new Date('2026-07-18')
  const today = new Date()
  const dayNumber = Math.max(1, Math.floor((today.getTime() - startDate.getTime()) / 86400000) + 1)

  // Find the next unsolved day (actual progress position)
  let actualDay = 0
  let actualWeekNum = 1
  let actualWeekTitle = ''
  let focusProblems: Array<{ name: string; difficulty: string; category: string; id: string }> = []
  let thisWeekDays: any[] = []
  let behindSchedule = false

  // Find the first day with unsolved problems
  for (const week of DSA_PLAN) {
    for (const day of week.days) {
      const unsolved = day.problems.filter((_: any, i: number) => {
        const id = `w${week.week}_d${day.day}_p${i}`
        return !data.progress[id]
      })
      if (unsolved.length > 0 && focusProblems.length === 0) {
        actualDay = day.day
        actualWeekNum = week.week
        actualWeekTitle = week.title
        thisWeekDays = week.days
        focusProblems = unsolved.map((p: any, i: number) => {
          // Find original index
          const origIdx = day.problems.indexOf(p)
          return { ...p, id: `w${week.week}_d${day.day}_p${origIdx}` }
        })
      }
    }
  }

  // Check if behind schedule
  if (actualDay < dayNumber) {
    behindSchedule = true
  }

  // If all done, show last week
  if (focusProblems.length === 0) {
    const lastWeek = DSA_PLAN[DSA_PLAN.length - 1]
    actualWeekNum = lastWeek.week
    thisWeekDays = lastWeek.days
    actualWeekTitle = 'All Problems Complete!'
  }

  // Use the actual position for display, not calendar position
  const currentWeekNum = actualWeekNum
  const currentDayInWeek = actualDay || dayNumber
  const todayProblems = focusProblems.map(p => ({ name: p.name, difficulty: p.difficulty, category: p.category, id: p.id }))
  const currentWeekTitle = actualWeekTitle

  const todayCategory = todayProblems.length > 0 ? todayProblems[0].category : ''
  const daysBehind = behindSchedule ? dayNumber - actualDay : 0

  // Total solved
  const totalSolved = Object.keys(data.progress).filter(k => k !== '_seeded' && data.progress[k]?.done).length

  // Streak
  const dates = new Set(Object.values(data.progress).filter(v => v && typeof v === 'object' && 'date' in v).map(v => v.date))
  let streak = 0
  const d = new Date()
  if (!dates.has(d.toDateString())) d.setDate(d.getDate() - 1)
  while (dates.has(d.toDateString())) { streak++; d.setDate(d.getDate() - 1) }

  // Overdue redos
  const overdueRedos = getOverdueRedos(data)

  // Next week
  const nextWeek = DSA_PLAN.find(w => w.week === currentWeekNum + 1) || null

  // Pattern health
  const patternHealth = computePatternHealth(data)

  return {
    dayNumber,
    currentWeekNum,
    currentDayInWeek,
    todayProblems,
    todayCategory,
    currentWeekTitle,
    thisWeekDays,
    totalSolved,
    streak,
    overdueRedos,
    nextWeek,
    patternHealth,
    behindSchedule,
    daysBehind,
  }
}

function getOverdueRedos(data: any): OverdueRedo[] {
  const now = Date.now()
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

  EXTRA_PROBLEMS.forEach(p => {
    solved.push({ name: p.name, difficulty: p.difficulty, category: p.category, solvedDate: p.solvedDate })
  })

  const due: OverdueRedo[] = []
  solved.forEach(p => {
    const redoData = data.revision_v2?.redos?.[p.name]
    const redoCount = redoData ? redoData.redo_count : 0
    const difficulty = redoData?.difficulty || p.difficulty

    // Mastery check: easy=2, medium/hard=4
    const masteryCount = difficulty === 'easy' ? 2 : 4
    if (redoCount >= masteryCount) return

    // Use difficulty-weighted intervals
    const intervals = difficulty === 'easy' ? [1, 7] : difficulty === 'hard' ? [1, 3, 7, 30] : [1, 3, 7, 21]

    const baseDate = redoCount === 0
      ? new Date(p.solvedDate).getTime()
      : new Date(redoData!.last_redo!).getTime()
    const requiredInterval = intervals[Math.min(redoCount, intervals.length - 1)]
    const dueDate = baseDate + requiredInterval * 86400000

    if (dueDate <= now) {
      due.push({
        name: p.name,
        difficulty,
        category: p.category,
        overdue_days: Math.floor((now - dueDate) / 86400000),
        redo_count: redoCount,
      })
    }
  })

  // Priority sort: Hard > Medium > Easy, then by most overdue
  const diffPriority: Record<string, number> = { hard: 3, medium: 2, easy: 1 }
  due.sort((a, b) => {
    const dp = (diffPriority[b.difficulty] || 0) - (diffPriority[a.difficulty] || 0)
    if (dp !== 0) return dp
    return b.overdue_days - a.overdue_days
  })

  return due
}

function computePatternHealth(data: any) {
  const now = Date.now()
  const solved: Array<{ category: string; solvedDate: string }> = []

  DSA_PLAN.forEach(week => {
    week.days.forEach(day => {
      day.problems.forEach((p, i) => {
        const id = `w${week.week}_d${day.day}_p${i}`
        if (data.progress[id]) {
          solved.push({ category: p.category, solvedDate: data.progress[id].date })
        }
      })
    })
  })

  EXTRA_PROBLEMS.forEach(p => {
    solved.push({ category: p.category, solvedDate: p.solvedDate })
  })

  // Also account for redo dates
  Object.entries(data.revision_v2?.redos || {}).forEach(([name, rd]: [string, any]) => {
    if (rd.last_redo) {
      const p = solved.find(s => s.category) // just need category, use any solved
      if (p) solved.push({ category: p.category, solvedDate: rd.last_redo })
    }
  })

  const categoryLastSolve: Record<string, number> = {}
  solved.forEach(p => {
    const ts = new Date(p.solvedDate).getTime()
    if (!categoryLastSolve[p.category] || ts > categoryLastSolve[p.category]) {
      categoryLastSolve[p.category] = ts
    }
  })

  return REVISION_CATEGORIES.map(cat => {
    const lastSolve = categoryLastSolve[cat]
    if (!lastSolve) return { category: cat, status: 'gray' as const, label: '—' }

    const days = Math.floor((now - lastSolve) / 86400000)
    const label = days === 0 ? 'today' : `${days}d`
    const status = days <= 3 ? 'green' as const : days <= 7 ? 'yellow' as const : 'red' as const
    return { category: cat, status, label }
  })
}

function getNextWeekCategories(week: typeof DSA_PLAN[number]): string[] {
  const cats = new Set<string>()
  week.days.forEach(d => d.problems.forEach(p => cats.add(p.category)))
  return Array.from(cats)
}
