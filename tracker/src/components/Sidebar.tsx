import { NavLink } from 'react-router-dom'
import { LayoutDashboard, Code2, Layers, Zap, BarChart3, Download, Upload } from 'lucide-react'
import clsx from 'clsx'
import { useProgress } from '../state/ProgressContext'
import { DSA_PLAN, DSA_TOTAL } from '../data/dsa-plan'
import { SD_TOTAL } from '../data/sd-plan'
import { SM_PLAN } from '../data/sm-plan'

const NAV_ITEMS = [
  { to: '/', icon: LayoutDashboard, label: 'Dashboard' },
  { to: '/dsa', icon: Code2, label: 'DSA' },
  { to: '/system-design', icon: Layers, label: 'System Design' },
  { to: '/stack-mastery', icon: Zap, label: 'Stack Mastery' },
  { to: '/analytics', icon: BarChart3, label: 'Analytics' },
]

function MiniProgress({ label, value, total, color }: { label: string; value: number; total: number; color: string }) {
  const pct = total > 0 ? (value / total) * 100 : 0
  return (
    <div className="flex items-center gap-2">
      <span className="text-xs font-semibold text-[var(--text-muted)] w-6 shrink-0">{label}</span>
      <div className="flex-1 h-2 rounded-full border border-[var(--border-light)] bg-white overflow-hidden">
        <div
          className="h-full rounded-full transition-all duration-500"
          style={{ width: `${pct}%`, background: color }}
        />
      </div>
      <span className="font-mono text-xs text-[var(--text-subtle)] w-8 text-right">{Math.round(pct)}%</span>
    </div>
  )
}

export function Sidebar() {
  const { data, exportData, importData } = useProgress()

  const dsaSolved = Object.keys(data.progress).filter(k => k !== '_seeded' && data.progress[k]?.done).length
  const sdSolved = Object.keys(data.sd_progress).filter(k => data.sd_progress[k]?.done).length
  const smTotal = SM_PLAN.reduce((acc, w) => acc + w.days.reduce((a, d) => a + d.items.length, 0), 0)
  const smSolved = Object.keys(data.sm_progress).filter(k => data.sm_progress[k]?.done).length

  // Compute today's day number
  const startDate = new Date('2026-07-18')
  const today = new Date()
  const dayNumber = Math.max(1, Math.floor((today.getTime() - startDate.getTime()) / 86400000) + 1)
  const currentWeek = DSA_PLAN.find(w => w.days.some(d => d.day === dayNumber))

  // Overdue redo count
  const overdueCount = getOverdueCount(data)

  return (
    <>
      {/* Desktop sidebar */}
      <aside className="hidden md:flex flex-col w-64 border-r-2 border-[var(--border)] bg-[var(--surface)] p-4 sticky top-0 h-screen overflow-y-auto">
        {/* Brand */}
        <div className="flex items-center gap-3 mb-8 px-2">
          <div className="w-9 h-9 rounded-xl border-2 border-[var(--border)] bg-gradient-to-br from-[var(--accent)] to-[var(--track-sd)] grid place-items-center shadow-[3px_3px_0_0_#e2e8f0] text-white font-display font-extrabold text-sm">
            T
          </div>
          <div>
            <div className="font-display font-bold text-sm leading-tight">DSA Tracker</div>
            <div className="text-xs text-[var(--text-muted)]">Practice Dashboard</div>
          </div>
        </div>

        {/* Navigation */}
        <nav className="flex flex-col gap-1 mb-8">
          {NAV_ITEMS.map(item => (
            <NavLink
              key={item.to}
              to={item.to}
              end={item.to === '/'}
              className={({ isActive }) => clsx(
                'flex items-center gap-3 px-3 py-2.5 rounded-xl text-sm font-semibold transition-all',
                'border-2 border-transparent',
                isActive
                  ? 'bg-[var(--accent)] text-white border-[var(--border)] shadow-[var(--shadow-pop)]'
                  : 'text-[var(--text-muted)] hover:bg-[rgba(251,191,36,0.14)] hover:text-[var(--text)] hover:border-[var(--border-light)]'
              )}
            >
              <item.icon size={18} />
              {item.label}
            </NavLink>
          ))}
        </nav>

        {/* Progress section */}
        <div className="border-t-2 border-[var(--border-light)] pt-4 mb-6">
          <div className="text-xs font-bold uppercase tracking-widest text-[var(--text-subtle)] mb-3 px-1">Progress</div>
          <div className="flex flex-col gap-2.5 px-1">
            <MiniProgress label="DSA" value={dsaSolved} total={DSA_TOTAL} color="var(--track-dsa)" />
            <MiniProgress label="SD" value={sdSolved} total={SD_TOTAL} color="var(--track-sd)" />
            <MiniProgress label="SM" value={smSolved} total={smTotal} color="var(--track-sm)" />
          </div>
        </div>

        {/* Today context */}
        <div className="border-t-2 border-[var(--border-light)] pt-4 mb-6">
          <div className="text-xs font-bold uppercase tracking-widest text-[var(--text-subtle)] mb-3 px-1">Today</div>
          <div className="px-1 text-sm space-y-1">
            <div className="font-semibold">Day {dayNumber} of 48</div>
            {currentWeek && <div className="text-[var(--text-muted)] text-xs">Week {currentWeek.week} · {currentWeek.title.split('·')[0].trim()}</div>}
            {overdueCount > 0 && (
              <div className="text-xs font-bold text-[var(--overdue)] flex items-center gap-1 mt-2">
                <span className="w-2 h-2 rounded-full bg-[var(--overdue)] animate-pulse" />
                {overdueCount} revision{overdueCount > 1 ? 's' : ''} overdue
              </div>
            )}
          </div>
        </div>

        {/* Actions */}
        <div className="mt-auto pt-4 border-t-2 border-[var(--border-light)] flex gap-2">
          <button onClick={exportData} className="btn-secondary text-xs py-2 px-3 flex-1" title="Export data">
            <Download size={14} /> Export
          </button>
          <label className="btn-secondary text-xs py-2 px-3 flex-1 cursor-pointer" title="Import data">
            <Upload size={14} /> Import
            <input
              type="file"
              accept=".json"
              className="hidden"
              onChange={(e) => { if (e.target.files?.[0]) importData(e.target.files[0]) }}
            />
          </label>
        </div>
      </aside>

      {/* Mobile bottom nav */}
      <nav className="md:hidden fixed bottom-0 left-0 right-0 z-50 flex items-center justify-around bg-[var(--surface)] border-t-2 border-[var(--border)] px-2 py-1.5 safe-area-pb">
        {NAV_ITEMS.map(item => (
          <NavLink
            key={item.to}
            to={item.to}
            end={item.to === '/'}
            className={({ isActive }) => clsx(
              'flex flex-col items-center gap-0.5 px-3 py-1.5 rounded-xl text-xs font-semibold transition-colors',
              isActive ? 'text-[var(--accent)]' : 'text-[var(--text-subtle)]'
            )}
          >
            <item.icon size={20} />
            <span className="text-[10px]">{item.label.split(' ')[0]}</span>
          </NavLink>
        ))}
      </nav>
    </>
  )
}

// Helper to count overdue revisions
function getOverdueCount(data: ReturnType<typeof useProgress>['data']): number {
  const now = Date.now()
  const intervals = [3, 7, 14]

  // Get all solved problems from progress data
  const solved: Array<{ name: string; solvedDate: string }> = []
  DSA_PLAN.forEach(week => {
    week.days.forEach(day => {
      day.problems.forEach((p, i) => {
        const id = `w${week.week}_d${day.day}_p${i}`
        if (data.progress[id]) {
          solved.push({ name: p.name, solvedDate: data.progress[id].date })
        }
      })
    })
  })

  let count = 0
  solved.forEach(p => {
    const redoData = data.revision_v2.redos[p.name]
    const redoCount = redoData ? redoData.redo_count : 0
    if (redoCount >= 3) return

    const baseDate = redoCount === 0
      ? new Date(p.solvedDate).getTime()
      : new Date(redoData!.last_redo!).getTime()
    const requiredInterval = intervals[Math.min(redoCount, intervals.length - 1)]
    const dueDate = baseDate + requiredInterval * 86400000

    if (dueDate <= now) count++
  })

  return count
}
