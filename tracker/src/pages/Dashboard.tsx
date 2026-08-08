import { useMemo } from 'react'
import { Link } from 'react-router-dom'
import { ArrowRight, AlertTriangle, CheckCircle2, Flame, Calendar, Code2, Layers, Zap, Hammer } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { DSA_PLAN, DSA_TOTAL, EXTRA_PROBLEMS, REVISION_CATEGORIES } from '../data/dsa-plan'
import { SD_PLAN, SD_TOTAL } from '../data/sd-plan'
import { DESIGN_PLAN, DESIGN_TOTAL } from '../data/design-plan'
import { SM_PLAN } from '../data/sm-plan'
import { ALL_PROJECTS, getProjectStatus } from '../data/projects'
import { LEETCODE_URLS } from '../data/leetcode-urls'

// --- Helper: get SM items for today ---
function getSMItemsForToday(): Array<{name: string, track: string}> {
  const today = new Date()
  const todayStr = today.toLocaleDateString('en-US', { month: 'short', day: 'numeric' })
  for (const week of SM_PLAN) {
    for (const day of week.days) {
      if (day.date === todayStr) return day.items
    }
  }
  return []
}

// --- Helper: get Design items for today ---
function getDesignItemsForToday(data: any) {
  const today = new Date()
  const month = today.toLocaleDateString('en-US', { month: 'short' })
  const day = today.getDate()
  const todayStr = `${month} ${day}`
  
  for (const week of DESIGN_PLAN) {
    for (const d of week.days) {
      if (d.date === todayStr) {
        return d.items.map((item, i) => ({
          ...item,
          id: `design_w${week.week}_d${d.day}_i${i}`,
          done: !!data.sd_progress[`design_w${week.week}_d${d.day}_i${i}`]
        }))
      }
    }
  }
  return []
}

// --- Helper: get SD start date string ---
function getSDStartDate(): string {
  if (SD_PLAN.length > 0 && SD_PLAN[0].days.length > 0) {
    return SD_PLAN[0].days[0].date
  }
  return ''
}

// --- Helper: get SM start date string ---
function getSMStartDate(): string {
  if (SM_PLAN.length > 0 && SM_PLAN[0].days.length > 0) {
    return SM_PLAN[0].days[0].date
  }
  return ''
}

// --- Helper: get week days for the current calendar week across all tracks ---
function getThisWeekDays(): Array<{date: Date, dateStr: string, hasDSA: boolean, hasSD: boolean, hasSM: boolean}> {
  const today = new Date()
  const dayOfWeek = today.getDay() // 0=Sun
  const monday = new Date(today)
  monday.setDate(today.getDate() - ((dayOfWeek + 6) % 7))

  const sdDates = new Set<string>()
  SD_PLAN.forEach(w => w.days.forEach(d => sdDates.add(d.date)))
  const smDates = new Set<string>()
  SM_PLAN.forEach(w => w.days.forEach(d => smDates.add(d.date)))

  const days: Array<{date: Date, dateStr: string, hasDSA: boolean, hasSD: boolean, hasSM: boolean}> = []
  for (let i = 0; i < 7; i++) {
    const d = new Date(monday)
    d.setDate(monday.getDate() + i)
    const dateStr = d.toLocaleDateString('en-US', { month: 'short', day: 'numeric' })
    days.push({
      date: d,
      dateStr,
      hasDSA: d.getDay() !== 0, // DSA every day except Sunday (heuristic)
      hasSD: sdDates.has(dateStr),
      hasSM: smDates.has(dateStr),
    })
  }
  return days
}

// --- Overdue Redo Types ---
interface OverdueRedo {
  name: string
  difficulty: string
  category: string
  overdue_days: number
  redo_count: number
}

function isWeekend(): boolean {
  const day = new Date().getDay()
  return day === 0 || day === 6
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
    const masteryCount = difficulty === 'easy' ? 2 : 4
    if (redoCount >= masteryCount) return

    const intervals = difficulty === 'easy' ? [1, 7] : difficulty === 'hard' ? [1, 3, 7, 30] : [1, 3, 7, 21]
    const baseDate = redoCount === 0
      ? new Date(p.solvedDate).getTime()
      : new Date(redoData!.last_redo!).getTime()
    const requiredInterval = intervals[Math.min(redoCount, intervals.length - 1)]
    const dueDate = baseDate + requiredInterval * 86400000

    if (dueDate <= now) {
      due.push({ name: p.name, difficulty, category: p.category, overdue_days: Math.floor((now - dueDate) / 86400000), redo_count: redoCount })
    }
  })

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
        if (data.progress[id]) solved.push({ category: p.category, solvedDate: data.progress[id].date })
      })
    })
  })
  EXTRA_PROBLEMS.forEach(p => solved.push({ category: p.category, solvedDate: p.solvedDate }))

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

// ============================
// MAIN COMPONENT
// ============================
export function Dashboard() {
  const { data, toggleDSA, toggleSD, toggleSM, markRedone, markSolvedButSlow, markStruggled } = useProgress()

  const ctx = useMemo(() => {
    const startDate = new Date('2026-07-18')
    const today = new Date()
    const dayNumber = Math.max(1, Math.floor((today.getTime() - startDate.getTime()) / 86400000) + 1)
    const currentWeekNum = Math.ceil(dayNumber / 7)
    const dateString = today.toLocaleDateString('en-US', { weekday: 'long', month: 'long', day: 'numeric', year: 'numeric' })

    // DSA: find first day with unsolved problems
    let dsaCategory = ''
    let todayProblems: Array<{ name: string; difficulty: string; category: string; id: string }> = []
    let behindSchedule = false
    let daysBehind = 0
    let actualDay = dayNumber

    for (const week of DSA_PLAN) {
      if (todayProblems.length > 0) break
      for (const day of week.days) {
        const unsolved = day.problems.map((p: any, i: number) => {
          const id = `w${week.week}_d${day.day}_p${i}`
          return { ...p, id, done: !!data.progress[id] }
        }).filter((p: any) => !p.done)
        if (unsolved.length > 0 && todayProblems.length === 0) {
          actualDay = day.day
          dsaCategory = unsolved[0].category
          todayProblems = unsolved.slice(0, 3).map(({ done, ...rest }: any) => rest)
          if (day.day < dayNumber) {
            behindSchedule = true
            daysBehind = dayNumber - day.day
          }
          break
        }
      }
    }

    // DSA solved count
    const dsaSolved = Object.keys(data.progress).filter(k => k !== '_seeded' && data.progress[k]?.done).length

    // SD solved count
    const sdSolved = Object.keys(data.sd_progress).filter(k => data.sd_progress[k]?.done).length

    // SM solved count & total
    let smTotal = 0
    SM_PLAN.forEach(w => w.days.forEach(d => { smTotal += d.items.length }))
    const smSolved = Object.keys(data.sm_progress).filter(k => data.sm_progress[k]?.done).length

    // Streak
    const dates = new Set(Object.values(data.progress).filter(v => v && typeof v === 'object' && 'date' in v).map(v => v.date))
    let streak = 0
    const d = new Date()
    if (!dates.has(d.toDateString())) d.setDate(d.getDate() - 1)
    while (dates.has(d.toDateString())) { streak++; d.setDate(d.getDate() - 1) }

    // SD items for today
    const sdItems = getDesignItemsForToday(data)
    // SM items for today
    const smItems = getSMItemsForToday()
    // Week strip
    const weekDays = getThisWeekDays()
    // Overdue redos
    const overdueRedos = getOverdueRedos(data)
    // Pattern health
    const patternHealth = computePatternHealth(data)

    // Projects ready
    const projectProgress: Record<string, boolean> = {}
    ALL_PROJECTS.forEach(p => {
      if (data.sm_progress[`project_${p.id}`]) projectProgress[p.id] = true
    })
    // Projects are only "ready" if prerequisites are met AND their scheduled date has arrived
    const nowDate = new Date()
    const readyProjects = ALL_PROJECTS.filter(p => {
      if (getProjectStatus(p, data.sm_progress, data.sd_progress, projectProgress) !== 'ready') return false
      // Check if targetDate has arrived (parse "Aug 21" style dates)
      const targetDate = new Date(`${p.targetDate} 2026`)
      return nowDate >= targetDate
    })

    return {
      dayNumber, currentWeekNum, dateString, behindSchedule, daysBehind,
      dsaSolved, sdSolved, smSolved, smTotal, streak,
      todayProblems, dsaCategory, sdItems, smItems,
      weekDays, overdueRedos, patternHealth, readyProjects,
    }
  }, [data])

  return (
    <div className="max-w-4xl mx-auto space-y-6 page-enter stagger-in">
      {/* Section 1: Hero Card */}
      <header className="card p-6 overflow-hidden relative">
        <div className="absolute top-[-3rem] right-[-2rem] w-28 h-28 rounded-full border-2 border-[var(--border)] opacity-15 bg-[var(--accent-soft)]" />
        <div className="relative z-10">
          <div className="flex items-center gap-2 mb-1">
            <span className="pill bg-[var(--accent-soft)] text-[var(--accent-dark)]">
              <Calendar size={12} /> Day {ctx.dayNumber}
            </span>
            <span className="pill bg-white text-[var(--text-muted)]">Week {ctx.currentWeekNum}</span>
            {ctx.behindSchedule && <span className="pill bg-[var(--in-progress-soft)] text-amber-700">{ctx.daysBehind}d behind</span>}
          </div>
          <h1 className="font-display text-2xl md:text-3xl font-extrabold mt-3 leading-tight">
            {ctx.dateString}
          </h1>
          <div className="grid grid-cols-4 gap-3 mt-5">
            <StatMini value={ctx.dsaSolved} total={DSA_TOTAL} label="DSA" color="var(--track-dsa)" />
            <StatMini value={ctx.sdSolved} total={DESIGN_TOTAL} label="Design" color="var(--track-sd)" />
            <StatMini value={ctx.smSolved} total={ctx.smTotal} label="SM" color="var(--track-sm)" />
            <StatMini value={`${ctx.streak}d`} total="" label="Streak" color="var(--in-progress)" icon={<Flame size={12} />} />
          </div>
        </div>
      </header>

      {/* Section 2: Today's Plan */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Today's Plan</h2>

        {/* DSA Block */}
        <div className="border-l-4 border-l-[var(--track-dsa)] pl-4 mb-4">
          <div className="flex items-center gap-2 mb-2">
            <Code2 size={14} className="text-[var(--track-dsa)]" />
            <span className="text-xs font-bold uppercase tracking-wider text-[var(--track-dsa)]">DSA · {ctx.dsaCategory || 'Complete'}</span>
          </div>
          {ctx.todayProblems.length > 0 ? (
            <div className="space-y-2">
              {ctx.todayProblems.map(p => {
                const isDone = !!data.progress[p.id]
                return (
                  <ProblemRow
                    key={p.id}
                    name={p.name}
                    difficulty={p.difficulty}
                    done={isDone}
                    onToggle={() => toggleDSA(p.id, p.name, p.difficulty, p.category)}
                  />
                )
              })}
            </div>
          ) : (
            <p className="text-sm text-[var(--text-muted)]">All caught up! 🎉</p>
          )}
        </div>

        {/* Design Block */}
        <div className="border-l-4 border-l-[var(--track-sd)] pl-4 mb-4">
          <div className="flex items-center gap-2 mb-2">
            <Layers size={14} className="text-[var(--track-sd)]" />
            <span className="text-xs font-bold uppercase tracking-wider text-[var(--track-sd)]">Design (LLD+HLD)</span>
          </div>
          {ctx.sdItems.length > 0 ? (
            <div className="space-y-1">
              {ctx.sdItems.map((item) => (
                <TrackItemRow key={item.id} name={item.name} done={item.done} onToggle={() => toggleSD(item.id)} />
              ))}
            </div>
          ) : (
            <p className="text-sm text-[var(--text-muted)]">{getSDStartDate() ? `Starts ${getSDStartDate()}` : 'No items today'}</p>
          )}
        </div>

        {/* Stack Mastery Block */}
        <div className="border-l-4 border-l-[var(--track-sm)] pl-4 mb-4">
          <div className="flex items-center gap-2 mb-2">
            <Zap size={14} className="text-[var(--track-sm)]" />
            <span className="text-xs font-bold uppercase tracking-wider text-[var(--track-sm)]">Stack Mastery</span>
          </div>
          {ctx.smItems.length > 0 ? (
            <div className="space-y-1">
              {ctx.smItems.map((item, idx) => {
                const smId = `sm_today_${idx}`
                const done = !!data.sm_progress[smId]
                return <TrackItemRow key={smId} name={item.name} done={done} onToggle={() => toggleSM(smId)} />
              })}
            </div>
          ) : (
            <p className="text-sm text-[var(--text-muted)]">{getSMStartDate() ? `Starts ${getSMStartDate()}` : 'No items today'}</p>
          )}
        </div>

        {/* Revision Block (always present if items due) */}
        {ctx.overdueRedos.length > 0 && (
          <div className="border-l-4 border-l-red-400 pl-4 mb-4">
            <div className="flex items-center gap-2 mb-2">
              <AlertTriangle size={14} className="text-red-500" />
              <span className="text-xs font-bold uppercase tracking-wider text-red-500">
                Revision · {ctx.overdueRedos.length} due
              </span>
            </div>
            <div className="space-y-2">
              {ctx.overdueRedos.slice(0, 5).map(p => (
                <div key={p.name} className="flex flex-col gap-2 p-3 rounded-xl border-2 border-[var(--border-light)] bg-white breathe">
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
                    <button onClick={() => markStruggled(p.name)} className="btn-secondary text-xs py-1.5 px-2.5">Struggled</button>
                    <button onClick={() => markSolvedButSlow(p.name, p.difficulty)} className="btn-secondary text-xs py-1.5 px-2.5">Slow</button>
                    <button onClick={() => markRedone(p.name, p.difficulty)} className="btn-primary text-xs py-1.5 px-2.5">Solved Clean</button>
                  </div>
                </div>
              ))}
            </div>
          </div>
        )}

        {/* Project Block (hybrid builds only - LLD is in Design track) */}
        {ctx.readyProjects.filter(p => p.track === 'hybrid').length > 0 && (
          <div className="border-l-4 border-l-[var(--accent)] pl-4">
            <div className="flex items-center gap-2 mb-2">
              <Hammer size={14} className="text-[var(--accent)]" />
              <span className="text-xs font-bold uppercase tracking-wider text-[var(--accent)]">
                {isWeekend() ? 'Project · Build Day' : 'Project · Ready'}
              </span>
              <Link to="/projects" className="text-[10px] text-[var(--text-subtle)] hover:underline ml-auto">View all →</Link>
            </div>
            {ctx.readyProjects.filter(p => p.track === 'hybrid').slice(0, isWeekend() ? 2 : 1).map(p => (
              <div key={p.id} className="flex items-center gap-3 p-3 rounded-xl border-2 border-[var(--border-light)] bg-white mb-1">
                <span className="text-sm font-medium">{p.name}</span>
                <span className="pill text-[10px] bg-violet-50 text-violet-700">Hybrid</span>
                <span className="ml-auto text-[10px] text-[var(--text-subtle)] font-mono">{p.estimatedHours}h est.</span>
              </div>
            ))}
          </div>
        )}
      </section>

      {/* Section 4: This Week Strip */}
      <section className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">This Week</h2>
        <div className="flex items-center gap-2 overflow-x-auto pb-2">
          {ctx.weekDays.map((wd, idx) => {
            const isToday = wd.date.toDateString() === new Date().toDateString()
            const dayLabel = wd.date.toLocaleDateString('en-US', { weekday: 'short' })
            return (
              <div
                key={idx}
                className={`flex flex-col items-center gap-1.5 px-3 py-2 rounded-xl border-2 min-w-[4.5rem] transition-all ${
                  isToday
                    ? 'border-[var(--accent)] bg-[var(--accent-soft)] shadow-[var(--shadow-pop)]'
                    : 'border-[var(--border-light)] bg-white'
                }`}
              >
                <span className="font-mono text-xs text-[var(--text-subtle)]">{dayLabel}</span>
                <span className="text-[10px] text-[var(--text-muted)]">{wd.dateStr}</span>
                <div className="flex items-center gap-1 mt-0.5">
                  {wd.hasDSA && <span className="w-2 h-2 rounded-full bg-purple-500" title="DSA" />}
                  {wd.hasSD && <span className="w-2 h-2 rounded-full bg-emerald-500" title="SD" />}
                  {wd.hasSM && <span className="w-2 h-2 rounded-full bg-amber-500" title="SM" />}
                </div>
              </div>
            )
          })}
        </div>
      </section>

      {/* Section 5: Pattern Health */}
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

// ============================
// SUB-COMPONENTS
// ============================

function StatMini({ value, total, label, color, icon }: { value: string | number; total: string | number; label: string; color: string; icon?: React.ReactNode }) {
  return (
    <div className="text-center">
      <div className="flex items-center justify-center gap-1">
        {icon}
        <span className="font-display font-extrabold text-lg" style={{ color }}>{value}</span>
        {total && <span className="text-xs text-[var(--text-subtle)]">/{total}</span>}
      </div>
      <div className="text-[10px] font-bold uppercase tracking-wider text-[var(--text-muted)] mt-0.5">{label}</div>
    </div>
  )
}

function TrackItemRow({ name, done, onToggle }: { name: string; done: boolean; onToggle: () => void }) {
  return (
    <div className={`flex items-center gap-3 py-1.5 ${done ? 'opacity-50' : ''}`}>
      <button onClick={onToggle} className={`check-box w-5 h-5 ${done ? 'checked' : ''}`} aria-label={done ? `Unmark ${name}` : `Mark ${name} done`}>
        {done && <CheckMark />}
      </button>
      <span className={`text-sm ${done ? 'line-through text-[var(--text-subtle)]' : ''}`}>{name}</span>
    </div>
  )
}

function ProblemRow({ name, difficulty, done, onToggle }: { name: string; difficulty: string; done: boolean; onToggle: () => void }) {
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
