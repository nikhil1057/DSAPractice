import { useState, useMemo } from 'react'
import { Lock, Unlock, CheckCircle2, Clock, Hammer, Code2, Cpu, Globe } from 'lucide-react'
import { useProgress } from '../state/ProgressContext'
import { ALL_PROJECTS, LLD_PROBLEMS, HYBRID_PROJECTS, getProjectStatus, type Project, type ProjectStatus } from '../data/projects'

type Filter = 'all' | 'lld' | 'hybrid' | 'ready'

const DIFFICULTY_COLORS: Record<string, string> = {
  beginner: 'bg-green-100 text-green-700',
  intermediate: 'bg-amber-100 text-amber-700',
  advanced: 'bg-red-100 text-red-700',
}

const TRACK_ICON: Record<string, typeof Code2> = {
  lld: Code2,
  hybrid: Globe,
  dotnet: Cpu,
  ai: Cpu,
  fe: Globe,
}

export function ProjectsPage() {
  const { data, toggleSM } = useProgress()
  const [filter, setFilter] = useState<Filter>('all')

  // Build project completion map from sm_progress
  const projectProgress = useMemo(() => {
    const map: Record<string, boolean> = {}
    ALL_PROJECTS.forEach(p => {
      if (data.sm_progress[`project_${p.id}`]?.done) {
        map[p.id] = true
      }
    })
    return map
  }, [data.sm_progress])

  // Compute status for all projects
  const projectStatuses = useMemo(() => {
    const statuses: Record<string, ProjectStatus> = {}
    ALL_PROJECTS.forEach(p => {
      statuses[p.id] = getProjectStatus(p, data.sm_progress, data.sd_progress, projectProgress)
    })
    return statuses
  }, [data.sm_progress, data.sd_progress, projectProgress])

  // Filter projects
  const filteredProjects = useMemo(() => {
    return ALL_PROJECTS.filter(p => {
      if (filter === 'lld') return p.track === 'lld'
      if (filter === 'hybrid') return p.track === 'hybrid'
      if (filter === 'ready') return projectStatuses[p.id] === 'ready'
      return true
    })
  }, [filter, projectStatuses])

  // Group by week
  const grouped = useMemo(() => {
    const map = new Map<number, Project[]>()
    filteredProjects.forEach(p => {
      if (!map.has(p.week)) map.set(p.week, [])
      map.get(p.week)!.push(p)
    })
    return Array.from(map.entries()).sort((a, b) => a[0] - b[0])
  }, [filteredProjects])

  // Stats
  const stats = useMemo(() => {
    let ready = 0, done = 0, locked = 0
    ALL_PROJECTS.forEach(p => {
      const s = projectStatuses[p.id]
      if (s === 'ready') ready++
      else if (s === 'done') done++
      else locked++
    })
    return { total: ALL_PROJECTS.length, ready, done, locked }
  }, [projectStatuses])

  const toggleProject = (projectId: string) => {
    toggleSM(`project_${projectId}`)
  }

  // Week date labels — use the first project's targetDate in each group
  const getWeekDate = (week: number, projects: Project[]): string => {
    if (projects.length > 0 && projects[0].targetDate) {
      return projects[0].targetDate
    }
    return ''
  }

  return (
    <div className="max-w-4xl mx-auto space-y-6 page-enter stagger-in">
      {/* Header */}
      <header className="card p-6">
        <div className="flex items-center gap-3 mb-1">
          <Hammer className="w-6 h-6 text-violet-600" />
          <h1 className="text-2xl font-display font-bold">Projects</h1>
        </div>
        <p className="text-sm text-gray-500">LLD + Build Projects · Prerequisite-gated</p>
      </header>

      {/* Filter Tabs */}
      <div className="flex gap-2 flex-wrap">
        {([
          ['all', 'All'],
          ['lld', 'LLD'],
          ['hybrid', 'Hybrid Build'],
          ['ready', 'Ready'],
        ] as [Filter, string][]).map(([key, label]) => (
          <button
            key={key}
            onClick={() => setFilter(key)}
            className={`pill cursor-pointer transition-all ${
              filter === key
                ? 'bg-violet-600 text-white shadow-sm'
                : 'bg-gray-100 text-gray-600 hover:bg-gray-200'
            }`}
          >
            {label}
          </button>
        ))}
      </div>

      {/* Stats Row */}
      <div className="grid grid-cols-2 sm:grid-cols-4 gap-3">
        <div className="card p-4 text-center">
          <div className="text-2xl font-display font-bold">{stats.total}</div>
          <div className="text-xs text-gray-500">Total</div>
        </div>
        <div className="card p-4 text-center">
          <div className="text-2xl font-display font-bold text-amber-600">{stats.ready}</div>
          <div className="text-xs text-gray-500">Ready</div>
        </div>
        <div className="card p-4 text-center">
          <div className="text-2xl font-display font-bold text-green-600">{stats.done}</div>
          <div className="text-xs text-gray-500">Done</div>
        </div>
        <div className="card p-4 text-center">
          <div className="text-2xl font-display font-bold text-gray-400">{stats.locked}</div>
          <div className="text-xs text-gray-500">Locked</div>
        </div>
      </div>

      {/* Project Timeline */}
      <div className="space-y-6">
        {grouped.map(([week, projects]) => (
          <div key={week} className="space-y-3">
            {/* Week header */}
            <div className="flex items-center gap-3">
              <div className="h-px flex-1 bg-gray-200" />
              <span className="text-sm font-display font-bold text-gray-500 whitespace-nowrap">
                Design W{week} — {getWeekDate(week, projects)}
              </span>
              <div className="h-px flex-1 bg-gray-200" />
            </div>

            {/* Project cards */}
            <div className="space-y-3">
              {projects.map(project => (
                <ProjectCard
                  key={project.id}
                  project={project}
                  status={projectStatuses[project.id]}
                  smProgress={data.sm_progress}
                  sdProgress={data.sd_progress}
                  projectProgress={projectProgress}
                  onToggle={toggleProject}
                />
              ))}
            </div>
          </div>
        ))}
      </div>

      {filteredProjects.length === 0 && (
        <div className="card p-8 text-center text-gray-400">
          <Lock className="w-8 h-8 mx-auto mb-2 opacity-50" />
          <p>No projects match this filter.</p>
        </div>
      )}
    </div>
  )
}

// ============ Project Card Component ============

interface ProjectCardProps {
  project: Project
  status: ProjectStatus
  smProgress: Record<string, any>
  sdProgress: Record<string, any>
  projectProgress: Record<string, boolean>
  onToggle: (id: string) => void
}

function ProjectCard({ project, status, smProgress, sdProgress, projectProgress, onToggle }: ProjectCardProps) {
  const isLocked = status === 'locked'
  const isDone = status === 'done'
  const isReady = status === 'ready'

  const borderColor = project.track === 'lld' ? 'border-l-blue-500' : 'border-l-violet-500'
  const TrackIcon = TRACK_ICON[project.track] || Code2

  // Check individual prerequisites
  const prereqStatus = project.prerequisites.map((prereqId, idx) => {
    let met = false
    if (prereqId.startsWith('sm_w')) {
      const weekNum = parseInt(prereqId.replace('sm_w', ''))
      const weekKeys = Object.keys(smProgress).filter(k => k.startsWith(`sm_w${weekNum}_`))
      met = weekKeys.length >= 4
    } else if (prereqId.startsWith('sd_w')) {
      const weekNum = parseInt(prereqId.replace('sd_w', ''))
      const weekKeys = Object.keys(sdProgress).filter(k => k.startsWith(`sd_w${weekNum}_`))
      met = weekKeys.length >= 2
    } else {
      met = !!projectProgress[prereqId]
    }
    return { id: prereqId, label: project.prereqLabels[idx] || prereqId, met }
  })

  return (
    <div
      className={`card p-5 border-l-4 ${borderColor} transition-all ${
        isLocked ? 'opacity-60' : ''
      } ${isReady ? 'ring-1 ring-amber-300 shadow-[0_0_8px_rgba(245,158,11,0.15)]' : ''} ${
        isDone ? 'bg-green-50/50' : ''
      }`}
    >
      <div className="flex items-start gap-3">
        {/* Status icon */}
        <div className="pt-0.5">
          {isLocked && <Lock className="w-5 h-5 text-gray-400" />}
          {isReady && <Unlock className="w-5 h-5 text-amber-500" />}
          {isDone && <CheckCircle2 className="w-5 h-5 text-green-600 fill-green-100" />}
        </div>

        {/* Content */}
        <div className="flex-1 min-w-0 space-y-2">
          {/* Name + Track badge */}
          <div className="flex items-center gap-2 flex-wrap">
            <h3 className="font-display font-bold text-base">{project.name}</h3>
            <span className={`pill text-xs ${
              project.track === 'lld'
                ? 'bg-blue-100 text-blue-700'
                : 'bg-gradient-to-r from-violet-100 to-fuchsia-100 text-violet-700'
            }`}>
              <TrackIcon className="w-3 h-3 inline-block mr-0.5" />
              {project.track === 'lld' ? 'LLD' : 'Hybrid'}
            </span>
            <span className={`pill text-xs ${DIFFICULTY_COLORS[project.difficulty]}`}>
              {project.difficulty}
            </span>
          </div>

          {/* Description */}
          <p className="text-sm text-gray-500 leading-relaxed">{project.description}</p>

          {/* Tags */}
          <div className="flex flex-wrap gap-1.5">
            {project.tags.map(tag => (
              <span key={tag} className="pill text-xs bg-gray-100 text-gray-600">
                {tag}
              </span>
            ))}
          </div>

          {/* Prerequisites */}
          {project.prerequisites.length > 0 && (
            <div className="space-y-1 pt-1">
              <div className="text-xs font-medium text-gray-400 uppercase tracking-wide">Prerequisites</div>
              <div className="space-y-0.5">
                {prereqStatus.map(({ id, label, met }) => (
                  <div key={id} className={`text-xs flex items-center gap-1.5 ${
                    met ? 'text-green-600' : isLocked ? 'text-red-500' : 'text-gray-400'
                  }`}>
                    {met ? (
                      <CheckCircle2 className="w-3 h-3 flex-shrink-0" />
                    ) : (
                      <Lock className="w-3 h-3 flex-shrink-0" />
                    )}
                    <span>{label}</span>
                  </div>
                ))}
              </div>
            </div>
          )}

          {/* Footer: hours + toggle */}
          <div className="flex items-center justify-between pt-2">
            <div className="flex items-center gap-1 text-xs text-gray-400">
              <Clock className="w-3.5 h-3.5" />
              <span>{project.estimatedHours}h estimated</span>
            </div>

            {(isReady || isDone) && (
              <button
                onClick={() => onToggle(project.id)}
                className={`flex items-center gap-1.5 px-3 py-1.5 rounded-md text-xs font-medium transition-all cursor-pointer ${
                  isDone
                    ? 'bg-green-100 text-green-700 hover:bg-green-200'
                    : 'bg-violet-100 text-violet-700 hover:bg-violet-200'
                }`}
              >
                {isDone ? (
                  <>
                    <CheckCircle2 className="w-3.5 h-3.5" />
                    Completed
                  </>
                ) : (
                  <>
                    <Hammer className="w-3.5 h-3.5" />
                    Mark Done
                  </>
                )}
              </button>
            )}
          </div>
        </div>
      </div>
    </div>
  )
}
