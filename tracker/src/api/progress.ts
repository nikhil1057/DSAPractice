export interface ProgressData {
  progress: Record<string, { done: boolean; date: string }>
  revision: Record<string, any>
  revision_v2: { redos: Record<string, { redo_count: number; last_redo: string | null; next_redo: string | null; difficulty?: string }>; mock_history: any[] }
  sd_progress: Record<string, { done: boolean; date: string }>
  sm_progress: Record<string, { done: boolean; date: string }>
  settings?: {
    start_date: string
    daily_target: number
  }
}

const DEFAULT_DATA: ProgressData = {
  progress: {},
  revision: {},
  revision_v2: { redos: {}, mock_history: [] },
  sd_progress: {},
  sm_progress: {},
  settings: {
    start_date: '2026-07-18',
    daily_target: 3
  }
}

export async function loadProgress(): Promise<ProgressData> {
  try {
    const res = await fetch('/api/progress')
    const data = await res.json()
    return {
      progress: data.progress || {},
      revision: data.revision || {},
      revision_v2: data.revision_v2 || { redos: {}, mock_history: [] },
      sd_progress: data.sd_progress || {},
      sm_progress: data.sm_progress || {},
      settings: data.settings || DEFAULT_DATA.settings
    }
  } catch {
    return DEFAULT_DATA
  }
}

export async function saveProgress(data: ProgressData): Promise<void> {
  await fetch('/api/progress', {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(data)
  })
}
