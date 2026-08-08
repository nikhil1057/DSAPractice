import { createContext, useContext, useEffect, useState, useCallback, type ReactNode } from 'react'
import { loadProgress, saveProgress, type ProgressData } from '../api/progress'

interface ProgressContextValue {
  data: ProgressData
  loading: boolean
  toggleDSA: (id: string, name: string, difficulty: string, category: string) => void
  toggleSD: (id: string) => void
  toggleSM: (id: string) => void
  markRedone: (name: string, difficulty: string) => void
  markSolvedButSlow: (name: string, difficulty: string) => void
  markStruggled: (name: string) => void
  exportData: () => void
  importData: (file: File) => void
  resetAll: () => void
}

// Difficulty-weighted intervals
// Easy: 1d → 7d → mastered (2 redos)
// Medium: 1d → 3d → 7d → 21d → mastered (4 redos)
// Hard: 1d → 3d → 7d → 30d → mastered (4 redos)
function getIntervalsForDifficulty(difficulty: string): number[] {
  switch (difficulty) {
    case 'easy': return [1, 7]
    case 'hard': return [1, 3, 7, 30]
    default: return [1, 3, 7, 21] // medium
  }
}

function getMasteryCount(difficulty: string): number {
  return difficulty === 'easy' ? 2 : 4
}

const ProgressContext = createContext<ProgressContextValue | null>(null)

export function ProgressProvider({ children }: { children: ReactNode }) {
  const [data, setData] = useState<ProgressData>({
    progress: {},
    revision: {},
    revision_v2: { redos: {}, mock_history: [] },
    sd_progress: {},
    sm_progress: {},
    settings: { start_date: '2026-07-18', daily_target: 3 }
  })
  const [loading, setLoading] = useState(true)

  useEffect(() => {
    loadProgress().then(d => { setData(d); setLoading(false) })
  }, [])

  const persist = useCallback((newData: ProgressData) => {
    setData(newData)
    saveProgress(newData)
  }, [])

  const toggleDSA = useCallback((id: string, name: string, difficulty: string, category: string) => {
    setData(prev => {
      const next = { ...prev, progress: { ...prev.progress }, revision: { ...prev.revision } }
      if (next.progress[id]) {
        delete next.progress[id]
        delete next.revision[name]
      } else {
        next.progress[id] = { done: true, date: new Date().toDateString() }
        next.revision[name] = {
          name, difficulty, category,
          nextReview: Date.now() + 3 * 86400000,
          interval: 'medium', easyStreak: 0, mastered: false, reviews: 0
        }
      }
      saveProgress(next)
      return next
    })
  }, [])

  const toggleSD = useCallback((id: string) => {
    setData(prev => {
      const next = { ...prev, sd_progress: { ...prev.sd_progress } }
      if (next.sd_progress[id]) {
        delete next.sd_progress[id]
      } else {
        next.sd_progress[id] = { done: true, date: new Date().toDateString() }
      }
      saveProgress(next)
      return next
    })
  }, [])

  const toggleSM = useCallback((id: string) => {
    setData(prev => {
      const next = { ...prev, sm_progress: { ...prev.sm_progress } }
      if (next.sm_progress[id]) {
        delete next.sm_progress[id]
      } else {
        next.sm_progress[id] = { done: true, date: new Date().toDateString() }
      }
      saveProgress(next)
      return next
    })
  }, [])

  const markRedone = useCallback((name: string, difficulty: string) => {
    setData(prev => {
      const next = { ...prev, revision_v2: { ...prev.revision_v2, redos: { ...prev.revision_v2.redos } } }
      const r = next.revision_v2.redos[name] || { redo_count: 0, last_redo: null, next_redo: null, difficulty }
      r.redo_count++
      r.last_redo = new Date().toDateString()
      r.difficulty = difficulty

      const intervals = getIntervalsForDifficulty(difficulty)
      const masteryCount = getMasteryCount(difficulty)

      if (r.redo_count >= masteryCount) {
        r.next_redo = null // mastered
      } else {
        const nextInterval = intervals[Math.min(r.redo_count, intervals.length - 1)]
        const next_date = new Date()
        next_date.setDate(next_date.getDate() + nextInterval)
        r.next_redo = next_date.toDateString()
      }
      next.revision_v2.redos[name] = r
      saveProgress(next)
      return next
    })
  }, [])

  const markSolvedButSlow = useCallback((name: string, difficulty: string) => {
    setData(prev => {
      const next = { ...prev, revision_v2: { ...prev.revision_v2, redos: { ...prev.revision_v2.redos } } }
      const r = next.revision_v2.redos[name] || { redo_count: 0, last_redo: null, next_redo: null, difficulty }
      // Counts as a pass but keeps the SAME interval (doesn't advance)
      // If redo_count is 0, still advance to 1 (first redo completed)
      if (r.redo_count === 0) r.redo_count = 1
      r.last_redo = new Date().toDateString()
      r.difficulty = difficulty

      const intervals = getIntervalsForDifficulty(difficulty)
      // Repeat current interval instead of advancing
      const currentIntervalIdx = Math.max(0, Math.min(r.redo_count - 1, intervals.length - 1))
      const repeatInterval = intervals[currentIntervalIdx]
      const next_date = new Date()
      next_date.setDate(next_date.getDate() + repeatInterval)
      r.next_redo = next_date.toDateString()

      next.revision_v2.redos[name] = r
      saveProgress(next)
      return next
    })
  }, [])

  const markStruggled = useCallback((name: string) => {
    setData(prev => {
      const next = { ...prev, revision_v2: { ...prev.revision_v2, redos: { ...prev.revision_v2.redos } } }
      const r = { redo_count: 0, last_redo: new Date().toDateString(), next_redo: '' }
      const tomorrow = new Date()
      tomorrow.setDate(tomorrow.getDate() + 1)
      r.next_redo = tomorrow.toDateString()
      next.revision_v2.redos[name] = r
      saveProgress(next)
      return next
    })
  }, [])

  const exportData = useCallback(() => {
    const blob = new Blob([JSON.stringify(data, null, 2)], { type: 'application/json' })
    const a = document.createElement('a')
    a.href = URL.createObjectURL(blob)
    a.download = `tracker_backup_${new Date().toISOString().slice(0, 10)}.json`
    a.click()
    URL.revokeObjectURL(a.href)
  }, [data])

  const importData = useCallback((file: File) => {
    const reader = new FileReader()
    reader.onload = (e) => {
      try {
        const imported = JSON.parse(e.target?.result as string)
        const merged: ProgressData = {
          progress: imported.progress || {},
          revision: imported.revision || {},
          revision_v2: imported.revision_v2 || { redos: {}, mock_history: [] },
          sd_progress: imported.sd_progress || {},
          sm_progress: imported.sm_progress || {},
          settings: imported.settings || data.settings
        }
        persist(merged)
      } catch { /* ignore invalid files */ }
    }
    reader.readAsText(file)
  }, [data.settings, persist])

  const resetAll = useCallback(() => {
    const fresh: ProgressData = {
      progress: {},
      revision: {},
      revision_v2: { redos: {}, mock_history: [] },
      sd_progress: {},
      sm_progress: {},
      settings: { start_date: '2026-07-18', daily_target: 3 }
    }
    persist(fresh)
  }, [persist])

  return (
    <ProgressContext.Provider value={{ data, loading, toggleDSA, toggleSD, toggleSM, markRedone, markSolvedButSlow, markStruggled, exportData, importData, resetAll }}>
      {children}
    </ProgressContext.Provider>
  )
}

export function useProgress() {
  const ctx = useContext(ProgressContext)
  if (!ctx) throw new Error('useProgress must be used within ProgressProvider')
  return ctx
}
