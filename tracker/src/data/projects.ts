// All projects across tracks with prerequisite dependencies
// Prerequisites reference either:
// - SM week items: "sm_w{week}" (Stack Mastery week completed)
// - SD topics: "sd_w{week}" (System Design week studied)
// - Other projects: "proj_{id}" (another project completed)
// - LLD problems: "lld_{id}" (LLD problem completed)

export type ProjectTrack = 'dotnet' | 'ai' | 'fe' | 'hybrid' | 'lld'
export type ProjectStatus = 'locked' | 'ready' | 'in-progress' | 'done'

export interface Project {
  id: string
  name: string
  description: string
  track: ProjectTrack
  week: number // timeline position (SM week number)
  targetDate: string
  difficulty: 'beginner' | 'intermediate' | 'advanced'
  prerequisites: string[] // IDs of prereqs
  prereqLabels: string[] // Human-readable prereq descriptions
  tags: string[]
  estimatedHours: number
}

// ============ LLD PROBLEMS ============
// These are OOD/LLD design + implementation exercises

export const LLD_PROBLEMS: Project[] = [
  {
    id: 'lld_parking_lot',
    name: 'Design Parking Lot',
    description: 'Multi-level parking with vehicle types, spot assignment, and payment. SOLID principles, Strategy pattern.',
    track: 'lld',
    week: 2,
    targetDate: 'Aug 18',
    difficulty: 'beginner',
    prerequisites: [],
    prereqLabels: [],
    tags: ['SOLID', 'Strategy Pattern', 'OOP Basics'],
    estimatedHours: 3
  },
  {
    id: 'lld_elevator',
    name: 'Design Elevator System',
    description: 'Multiple elevators, scheduling algorithms (SCAN, LOOK), state machine, Observer pattern.',
    track: 'lld',
    week: 2,
    targetDate: 'Aug 19',
    difficulty: 'intermediate',
    prerequisites: ['lld_parking_lot'],
    prereqLabels: ['Parking Lot (OOP basics)'],
    tags: ['State Machine', 'Observer', 'Scheduling'],
    estimatedHours: 4
  },
  {
    id: 'lld_library',
    name: 'Design Library Management',
    description: 'Book catalog, member management, borrowing rules, fine calculation. Repository pattern, DI.',
    track: 'lld',
    week: 3,
    targetDate: 'Aug 25',
    difficulty: 'beginner',
    prerequisites: [],
    prereqLabels: [],
    tags: ['Repository Pattern', 'DI', 'Business Rules'],
    estimatedHours: 3
  },
  {
    id: 'lld_snake_game',
    name: 'Design Snake Game',
    description: 'Game loop, collision detection, queue-based snake body, command pattern for input.',
    track: 'lld',
    week: 3,
    targetDate: 'Aug 27',
    difficulty: 'intermediate',
    prerequisites: [],
    prereqLabels: [],
    tags: ['Command Pattern', 'Game Loop', 'Queue'],
    estimatedHours: 3
  },
  {
    id: 'lld_splitwise',
    name: 'Design Splitwise',
    description: 'Expense splitting (equal, exact, percent), debt simplification graph algorithm, Observer for notifications.',
    track: 'lld',
    week: 4,
    targetDate: 'Sep 1',
    difficulty: 'intermediate',
    prerequisites: ['lld_parking_lot'],
    prereqLabels: ['Parking Lot (OOP)'],
    tags: ['Graph', 'Observer', 'Strategy'],
    estimatedHours: 5
  },
  {
    id: 'lld_chess',
    name: 'Design Chess Game',
    description: 'Piece hierarchy, move validation, check/checkmate detection, undo with Memento pattern.',
    track: 'lld',
    week: 5,
    targetDate: 'Sep 8',
    difficulty: 'advanced',
    prerequisites: ['lld_snake_game', 'lld_splitwise'],
    prereqLabels: ['Snake Game', 'Splitwise'],
    tags: ['Inheritance', 'Memento', 'Template Method'],
    estimatedHours: 6
  },
  {
    id: 'lld_vending_machine',
    name: 'Design Vending Machine',
    description: 'State pattern for machine states, Chain of Responsibility for coin validation, inventory management.',
    track: 'lld',
    week: 5,
    targetDate: 'Sep 10',
    difficulty: 'intermediate',
    prerequisites: ['lld_elevator'],
    prereqLabels: ['Elevator (State Machine)'],
    tags: ['State Pattern', 'Chain of Responsibility'],
    estimatedHours: 3
  },
  {
    id: 'lld_hotel_booking',
    name: 'Design Hotel Booking System',
    description: 'Room types, reservation conflicts, pricing strategy, cancellation policy. Builder + Strategy patterns.',
    track: 'lld',
    week: 6,
    targetDate: 'Sep 15',
    difficulty: 'intermediate',
    prerequisites: ['lld_library'],
    prereqLabels: ['Library Management'],
    tags: ['Builder', 'Strategy', 'Concurrency'],
    estimatedHours: 5
  },
  {
    id: 'lld_cache',
    name: 'Design In-Memory Cache (LRU)',
    description: 'LRU eviction with HashMap + DoublyLinkedList, TTL support, thread-safety with locks.',
    track: 'lld',
    week: 7,
    targetDate: 'Sep 22',
    difficulty: 'intermediate',
    prerequisites: ['lld_parking_lot'],
    prereqLabels: ['Basic OOP'],
    tags: ['Data Structures', 'Thread Safety', 'Decorator'],
    estimatedHours: 4
  },
  {
    id: 'lld_task_scheduler',
    name: 'Design Task Scheduler',
    description: 'Priority queue, cron expressions, retry with exponential backoff, pub-sub for completion.',
    track: 'lld',
    week: 8,
    targetDate: 'Sep 29',
    difficulty: 'advanced',
    prerequisites: ['lld_vending_machine', 'lld_cache'],
    prereqLabels: ['Vending Machine', 'LRU Cache'],
    tags: ['Priority Queue', 'Pub-Sub', 'Retry Patterns'],
    estimatedHours: 6
  },
  {
    id: 'lld_rate_limiter',
    name: 'Design Rate Limiter',
    description: 'Token bucket, sliding window, fixed window algorithms. Decorator pattern, pluggable strategies.',
    track: 'lld',
    week: 9,
    targetDate: 'Oct 6',
    difficulty: 'intermediate',
    prerequisites: ['lld_cache'],
    prereqLabels: ['LRU Cache (data structure foundation)'],
    tags: ['Algorithms', 'Decorator', 'Strategy'],
    estimatedHours: 4
  },
  {
    id: 'lld_logger',
    name: 'Design Logging Framework',
    description: 'Log levels, multiple sinks (file, console, network), async buffering, Singleton + Chain of Responsibility.',
    track: 'lld',
    week: 10,
    targetDate: 'Oct 13',
    difficulty: 'intermediate',
    prerequisites: ['lld_vending_machine'],
    prereqLabels: ['Vending Machine (Chain of Responsibility)'],
    tags: ['Singleton', 'Chain of Responsibility', 'Async'],
    estimatedHours: 4
  },
]

// ============ HYBRID BUILD PROJECTS ============
// These combine System Design knowledge + Stack Mastery implementation

export const HYBRID_PROJECTS: Project[] = [
  {
    id: 'proj_url_shortener',
    name: 'URL Shortener + Analytics',
    description: 'Full implementation: Base62 encoding, Redis caching, click analytics pipeline, rate limiting.',
    track: 'hybrid',
    week: 5,
    targetDate: 'Sep 13',
    difficulty: 'beginner',
    prerequisites: ['sm_w4', 'sd_w5'],
    prereqLabels: ['SM: DI + Options pattern', 'SD: URL Shortener design studied'],
    tags: ['Redis', '.NET API', 'Rate Limiting', 'System Design'],
    estimatedHours: 8
  },
  {
    id: 'proj_realtime_chat',
    name: 'Real-time Chat Service',
    description: 'WebSocket-based messaging with SignalR, message persistence, online presence, typing indicators.',
    track: 'hybrid',
    week: 6,
    targetDate: 'Sep 15',
    difficulty: 'intermediate',
    prerequisites: ['sm_w2', 'sd_w5', 'proj_url_shortener'],
    prereqLabels: ['SM: Channels + async', 'SD: WhatsApp design', 'URL Shortener project'],
    tags: ['SignalR', 'WebSockets', '.NET', 'Real-Time'],
    estimatedHours: 12
  },
  {
    id: 'proj_rate_limiter',
    name: 'Distributed Rate Limiter',
    description: 'Middleware library with token bucket + sliding window, Redis backend, per-user + per-IP rules.',
    track: 'hybrid',
    week: 7,
    targetDate: 'Sep 22',
    difficulty: 'intermediate',
    prerequisites: ['sm_w5', 'lld_rate_limiter'],
    prereqLabels: ['SM: Middleware pipeline', 'LLD: Rate Limiter design'],
    tags: ['Middleware', 'Redis', 'Algorithms', '.NET'],
    estimatedHours: 8
  },
  {
    id: 'proj_leaderboard',
    name: 'Real-time Leaderboard',
    description: 'Redis sorted sets, WebSocket push updates, pagination, time-windowed rankings.',
    track: 'hybrid',
    week: 8,
    targetDate: 'Oct 1',
    difficulty: 'intermediate',
    prerequisites: ['proj_realtime_chat', 'sm_w7'],
    prereqLabels: ['Chat project (WebSockets)', 'SM: EF Core + Redis'],
    tags: ['Redis', 'WebSockets', 'Sorted Sets', 'Pub-Sub'],
    estimatedHours: 8
  },
  {
    id: 'proj_search_engine',
    name: 'Semantic Search Engine',
    description: 'Embedding generation, pgvector storage, hybrid search (dense + BM25), autocomplete with trie.',
    track: 'hybrid',
    week: 9,
    targetDate: 'Oct 6',
    difficulty: 'advanced',
    prerequisites: ['sm_w5', 'sd_w8'],
    prereqLabels: ['SM: Embeddings + Word2Vec', 'SD: Search design studied'],
    tags: ['AI', 'Embeddings', 'pgvector', 'Search'],
    estimatedHours: 14
  },
  {
    id: 'proj_task_queue',
    name: 'Distributed Task Queue',
    description: 'Background job processing with outbox pattern, dead-letter handling, retry policies, dashboard.',
    track: 'hybrid',
    week: 9,
    targetDate: 'Oct 8',
    difficulty: 'advanced',
    prerequisites: ['sm_w9', 'sd_w11', 'lld_task_scheduler'],
    prereqLabels: ['SM: Outbox + Saga', 'SD: Job Scheduler design', 'LLD: Task Scheduler'],
    tags: ['Outbox', 'Saga', 'Background Services', '.NET'],
    estimatedHours: 14
  },
  {
    id: 'proj_ai_classifier',
    name: 'AI Document Classifier',
    description: 'Fine-tuned model serving via .NET API, batch inference, A/B testing between models, eval pipeline.',
    track: 'hybrid',
    week: 10,
    targetDate: 'Oct 15',
    difficulty: 'advanced',
    prerequisites: ['sm_w10', 'proj_search_engine'],
    prereqLabels: ['SM: Fine-tuning', 'Search Engine project (embeddings)'],
    tags: ['Fine-tuning', 'Model Serving', '.NET', 'AI'],
    estimatedHours: 12
  },
  {
    id: 'proj_capstone',
    name: 'Healthcare AI Agent (Capstone)',
    description: 'Full RAG pipeline + tool-using agent + .NET API + auth + monitoring. Everything comes together.',
    track: 'hybrid',
    week: 13,
    targetDate: 'Nov 3',
    difficulty: 'advanced',
    prerequisites: ['sm_w12', 'proj_ai_classifier', 'proj_task_queue'],
    prereqLabels: ['SM: Agents + memory', 'AI Classifier', 'Task Queue'],
    tags: ['RAG', 'Agents', '.NET', 'Full Stack', 'Capstone'],
    estimatedHours: 20
  },
]

// ============ ALL PROJECTS COMBINED ============

export const ALL_PROJECTS: Project[] = [...LLD_PROBLEMS, ...HYBRID_PROJECTS]

// Helper: check if a prerequisite is met
export function isPrereqMet(
  prereqId: string,
  smProgress: Record<string, any>,
  sdProgress: Record<string, any>,
  projectProgress: Record<string, boolean>
): boolean {
  // SM week prereq: "sm_w{N}" — check if >80% of that week's items are done
  if (prereqId.startsWith('sm_w')) {
    const weekNum = parseInt(prereqId.replace('sm_w', ''))
    // Count items done in that week
    const weekKeys = Object.keys(smProgress).filter(k => k.startsWith(`sm_w${weekNum}_`))
    // Rough heuristic: if any items from that week exist, consider it started
    return weekKeys.length >= 4 // At least 4 items from the week done
  }

  // SD week prereq: "sd_w{N}" — check if any items from that week are done
  if (prereqId.startsWith('sd_w')) {
    const weekNum = parseInt(prereqId.replace('sd_w', ''))
    const weekKeys = Object.keys(sdProgress).filter(k => k.startsWith(`sd_w${weekNum}_`))
    return weekKeys.length >= 2
  }

  // Project prereq: "proj_{id}" or "lld_{id}"
  return !!projectProgress[prereqId]
}

export function getProjectStatus(
  project: Project,
  smProgress: Record<string, any>,
  sdProgress: Record<string, any>,
  projectProgress: Record<string, boolean>
): ProjectStatus {
  if (projectProgress[project.id]) return 'done'

  const allPrereqsMet = project.prerequisites.every(p =>
    isPrereqMet(p, smProgress, sdProgress, projectProgress)
  )

  return allPrereqsMet ? 'ready' : 'locked'
}
