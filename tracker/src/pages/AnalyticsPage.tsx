import { useMemo } from 'react'
import { TrendingUp, Target, Calendar } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { DSA_PLAN, DSA_TOTAL, EXTRA_PROBLEMS, REVISION_CATEGORIES } from '../data/dsa-plan'
import { SD_PLAN, SD_TOTAL } from '../data/sd-plan'
import { SM_PLAN } from '../data/sm-plan'

export function AnalyticsPage() {
  const { data } = useProgress()

  // Collect all DSA problems with their categories and difficulties
  const allDSAProblems = useMemo(() => {
    const problems: Array<{ name: string; difficulty: string; category: string; id: string }> = []
    DSA_PLAN.forEach(week => {
      week.days.forEach(day => {
        day.problems.forEach((p, i) => {
          problems.push({ name: p.name, difficulty: p.difficulty, category: p.category, id: `w${week.week}_d${day.day}_p${i}` })
        })
      })
    })
    return problems
  }, [])

  // Count all SM items
  const smTotal = useMemo(() => {
    let count = 0
    SM_PLAN.forEach(week => week.days.forEach(day => { count += day.items.length }))
    return count
  }, [])

  // Velocity: problems solved per day for last 21 days
  const velocityData = useMemo(() => {
    const today = new Date()
    const days: Array<{ date: string; count: number }> = []

    for (let i = 20; i >= 0; i--) {
      const d = new Date(today)
      d.setDate(d.getDate() - i)
      const dateStr = d.toDateString()
      let count = 0

      // Count DSA problems solved on this date
      Object.values(data.progress).forEach(entry => {
        if (entry.date === dateStr) count++
      })
      // Count SD problems solved on this date
      Object.values(data.sd_progress).forEach(entry => {
        if (entry.date === dateStr) count++
      })

      days.push({ date: dateStr, count })
    }

    return days
  }, [data.progress, data.sd_progress])

  const velocityStats = useMemo(() => {
    const counts = velocityData.map(d => d.count)
    const max = Math.max(...counts, 1)
    const total = counts.reduce((a, b) => a + b, 0)
    const avg = total / counts.length
    const best = max
    return { max, avg, best }
  }, [velocityData])

  // Completion forecast
  const forecast = useMemo(() => {
    const dsaSolved = Object.keys(data.progress).filter(k => k !== '_seeded' && data.progress[k]?.done).length
    const sdSolved = Object.keys(data.sd_progress).filter(k => data.sd_progress[k]?.done).length
    const totalSolved = dsaSolved + sdSolved
    const totalTarget = DSA_TOTAL + SD_TOTAL
    const remaining = totalTarget - totalSolved

    // Current pace: average over last 14 days
    const last14 = velocityData.slice(-14)
    const last14Total = last14.reduce((a, d) => a + d.count, 0)
    const currentPace = last14Total / 14

    const today = new Date()
    const atThreePerDay = remaining > 0 ? new Date(today.getTime() + (remaining / 3) * 86400000) : today
    const atTwoPerDay = remaining > 0 ? new Date(today.getTime() + (remaining / 2) * 86400000) : today
    const atCurrentPace = remaining > 0 && currentPace > 0
      ? new Date(today.getTime() + (remaining / currentPace) * 86400000)
      : null

    return { remaining, currentPace, atThreePerDay, atTwoPerDay, atCurrentPace }
  }, [data.progress, data.sd_progress, velocityData])

  // Category mastery
  const categoryMastery = useMemo(() => {
    return REVISION_CATEGORIES.map(cat => {
      const totalInCat = allDSAProblems.filter(p => p.category === cat).length
      const solvedInCat = allDSAProblems.filter(p => p.category === cat && data.progress[p.id]).length
      const pct = totalInCat > 0 ? (solvedInCat / totalInCat) * 100 : 0
      return { category: cat, solved: solvedInCat, total: totalInCat, pct }
    }).sort((a, b) => b.pct - a.pct)
  }, [allDSAProblems, data.progress])

  // Difficulty distribution
  const difficultyDist = useMemo(() => {
    let easy = 0, medium = 0, hard = 0
    allDSAProblems.forEach(p => {
      if (data.progress[p.id]) {
        if (p.difficulty === 'easy') easy++
        else if (p.difficulty === 'medium') medium++
        else hard++
      }
    })
    return { easy, medium, hard, total: easy + medium + hard }
  }, [allDSAProblems, data.progress])

  // Revision mastery
  const revisionMastery = useMemo(() => {
    const redos = data.revision_v2.redos
    let mastered = 0, inProgress = 0, notStarted = 0

    const solvedNames = new Set<string>()
    allDSAProblems.forEach(p => {
      if (data.progress[p.id]) solvedNames.add(p.name)
    })
    EXTRA_PROBLEMS.forEach(p => solvedNames.add(p.name))

    solvedNames.forEach(name => {
      const r = redos[name]
      if (r && r.redo_count >= 3) mastered++
      else if (r && r.redo_count > 0) inProgress++
      else notStarted++
    })

    return { mastered, inProgress, notStarted, total: mastered + inProgress + notStarted }
  }, [allDSAProblems, data.progress, data.revision_v2.redos])

  // Cross-track summary
  const crossTrack = useMemo(() => {
    const dsaSolved = Object.keys(data.progress).filter(k => k !== '_seeded' && data.progress[k]?.done).length
    const sdSolved = Object.keys(data.sd_progress).filter(k => data.sd_progress[k]?.done).length
    const smSolved = Object.keys(data.sm_progress).filter(k => data.sm_progress[k]?.done).length
    return {
      dsa: { solved: dsaSolved, total: DSA_TOTAL, pct: Math.round((dsaSolved / DSA_TOTAL) * 100) },
      sd: { solved: sdSolved, total: SD_TOTAL, pct: Math.round((sdSolved / SD_TOTAL) * 100) },
      sm: { solved: smSolved, total: smTotal, pct: Math.round((smSolved / smTotal) * 100) }
    }
  }, [data.progress, data.sd_progress, data.sm_progress, smTotal])

  const formatDate = (d: Date) => d.toLocaleDateString('en-US', { month: 'short', day: 'numeric', year: 'numeric' })

  return (
    <div className="space-y-6">
      <h1 className="font-display font-black text-2xl">Analytics</h1>

      {/* Velocity Sparkline */}
      <div className="card p-5">
        <div className="flex items-center gap-2 mb-4">
          <TrendingUp size={20} />
          <h2 className="font-display font-bold text-lg">Velocity — Last 21 Days</h2>
        </div>
        <div className="flex items-end gap-1 h-24">
          {velocityData.map(d => (
            <div
              key={d.date}
              className="flex-1 rounded-t"
              style={{
                height: `${(d.count / velocityStats.max) * 100}%`,
                background: 'var(--accent)',
                opacity: d.count > 0 ? 0.4 + (d.count / velocityStats.max) * 0.6 : 0.15
              }}
            />
          ))}
        </div>
        <div className="flex gap-6 mt-3 text-sm opacity-70">
          <span>Avg: <strong>{velocityStats.avg.toFixed(1)}/day</strong></span>
          <span>Target: <strong>3/day</strong></span>
          <span>Best: <strong>{velocityStats.best}</strong></span>
        </div>
      </div>

      {/* Completion Forecast */}
      <div className="card p-5">
        <div className="flex items-center gap-2 mb-4">
          <Calendar size={20} />
          <h2 className="font-display font-bold text-lg">Completion Forecast</h2>
        </div>
        <p className="text-sm opacity-70 mb-3">
          {forecast.remaining} problems remaining (DSA + System Design)
        </p>
        <div className="space-y-2 text-sm">
          <div className="flex justify-between">
            <span>At 3/day (target)</span>
            <span className="font-mono font-bold">{formatDate(forecast.atThreePerDay)}</span>
          </div>
          <div className="flex justify-between">
            <span>At 2/day</span>
            <span className="font-mono font-bold">{formatDate(forecast.atTwoPerDay)}</span>
          </div>
          <div className="flex justify-between">
            <span>Current pace ({forecast.currentPace.toFixed(1)}/day)</span>
            <span className="font-mono font-bold">
              {forecast.atCurrentPace ? formatDate(forecast.atCurrentPace) : '—'}
            </span>
          </div>
        </div>
      </div>

      {/* Category Mastery */}
      <div className="card p-5">
        <div className="flex items-center gap-2 mb-4">
          <Target size={20} />
          <h2 className="font-display font-bold text-lg">Category Mastery</h2>
        </div>
        <div className="space-y-2">
          {categoryMastery.map(cat => (
            <div key={cat.category}>
              <div className="flex justify-between text-sm mb-1">
                <span>{cat.category}</span>
                <span className="font-mono opacity-70">{cat.solved}/{cat.total}</span>
              </div>
              <div className="h-2 rounded-full bg-black/10 dark:bg-white/10 overflow-hidden">
                <div
                  className="h-full rounded-full transition-all"
                  style={{ width: `${cat.pct}%`, background: 'var(--accent)' }}
                />
              </div>
            </div>
          ))}
        </div>
      </div>

      {/* Difficulty Distribution */}
      <div className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Difficulty Distribution</h2>
        <div className="space-y-3">
          {[
            { label: 'Easy', count: difficultyDist.easy, color: '#22c55e' },
            { label: 'Medium', count: difficultyDist.medium, color: '#f59e0b' },
            { label: 'Hard', count: difficultyDist.hard, color: '#ef4444' }
          ].map(d => (
            <div key={d.label}>
              <div className="flex justify-between text-sm mb-1">
                <span>{d.label}</span>
                <span className="font-mono font-bold">{d.count}</span>
              </div>
              <div className="h-3 rounded-full bg-black/10 dark:bg-white/10 overflow-hidden">
                <div
                  className="h-full rounded-full transition-all"
                  style={{
                    width: difficultyDist.total > 0 ? `${(d.count / difficultyDist.total) * 100}%` : '0%',
                    background: d.color
                  }}
                />
              </div>
            </div>
          ))}
        </div>
      </div>

      {/* Revision Mastery */}
      <div className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Revision Mastery</h2>
        <div className="grid grid-cols-3 gap-4 text-center">
          <div>
            <div className="text-2xl font-black" style={{ color: '#22c55e' }}>
              {revisionMastery.mastered}
            </div>
            <div className="text-xs opacity-70 mt-1">Mastered (3/3)</div>
          </div>
          <div>
            <div className="text-2xl font-black" style={{ color: '#f59e0b' }}>
              {revisionMastery.inProgress}
            </div>
            <div className="text-xs opacity-70 mt-1">In Progress</div>
          </div>
          <div>
            <div className="text-2xl font-black" style={{ color: '#ef4444' }}>
              {revisionMastery.notStarted}
            </div>
            <div className="text-xs opacity-70 mt-1">Not Started</div>
          </div>
        </div>
        {revisionMastery.total > 0 && (
          <div className="h-3 rounded-full bg-black/10 dark:bg-white/10 overflow-hidden mt-4 flex">
            <div
              className="h-full"
              style={{ width: `${(revisionMastery.mastered / revisionMastery.total) * 100}%`, background: '#22c55e' }}
            />
            <div
              className="h-full"
              style={{ width: `${(revisionMastery.inProgress / revisionMastery.total) * 100}%`, background: '#f59e0b' }}
            />
            <div
              className="h-full"
              style={{ width: `${(revisionMastery.notStarted / revisionMastery.total) * 100}%`, background: '#ef4444' }}
            />
          </div>
        )}
      </div>

      {/* Cross-Track Summary */}
      <div className="card p-5">
        <h2 className="font-display font-bold text-lg mb-4">Cross-Track Summary</h2>
        <div className="space-y-4">
          {[
            { label: 'DSA', ...crossTrack.dsa },
            { label: 'System Design', ...crossTrack.sd },
            { label: 'Stack Mastery', ...crossTrack.sm }
          ].map(track => (
            <div key={track.label}>
              <div className="flex justify-between text-sm mb-1">
                <span className="font-medium">{track.label}</span>
                <span className="font-mono">
                  {track.solved}/{track.total} ({track.pct}%)
                </span>
              </div>
              <div className="h-2 rounded-full bg-black/10 dark:bg-white/10 overflow-hidden">
                <div
                  className="h-full rounded-full transition-all"
                  style={{ width: `${track.pct}%`, background: 'var(--accent)' }}
                />
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  )
}
