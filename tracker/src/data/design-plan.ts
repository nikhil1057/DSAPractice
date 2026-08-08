// Unified Design Track: LLD + HLD merged into one timeline
// Phase 1: Foundations (OOP, SOLID, Patterns) — Week 1-3
// Phase 2: LLD Problems (build at class level) — Week 4-7
// Phase 3: HLD Concepts + Technologies — Week 8-11
// Phase 4: HLD Problems (design at system level) — Week 12-18
// Phase 5: Combined (LLD+HLD for same system) — Week 19-21

export interface DesignItem {
  name: string
  type: 'lld' | 'hld' | 'theory' | 'pattern' | 'build'
  difficulty: 'beginner' | 'intermediate' | 'advanced'
  category: string
  tags?: string[] // cross-track tags like ['SD+SM', 'LLD+SM']
}

export interface DesignDay {
  day: number
  date: string
  items: DesignItem[]
}

export interface DesignWeek {
  week: number
  phase: number
  title: string
  days: DesignDay[]
}

export const DESIGN_PLAN: DesignWeek[] = [
  // ═══════════════════════════════════════════
  // PHASE 1: FOUNDATIONS (Aug 11 - Aug 30)
  // OOP, SOLID, Design Patterns — theory sprint
  // ═══════════════════════════════════════════
  { week: 1, phase: 1, title: "OOP + SOLID + Class Relationships", days: [
    { day: 1, date: "Aug 11", items: [
      { name: "Classes, Objects, Enums, Interfaces", type: "theory", difficulty: "beginner", category: "OOP" },
      { name: "Encapsulation, Abstraction", type: "theory", difficulty: "beginner", category: "OOP" },
    ]},
    { day: 2, date: "Aug 12", items: [
      { name: "Inheritance, Polymorphism", type: "theory", difficulty: "beginner", category: "OOP" },
      { name: "Association, Aggregation, Composition", type: "theory", difficulty: "beginner", category: "Relationships" },
    ]},
    { day: 3, date: "Aug 13", items: [
      { name: "Dependency, Realization", type: "theory", difficulty: "intermediate", category: "Relationships" },
      { name: "DRY, KISS, YAGNI, Law of Demeter", type: "theory", difficulty: "beginner", category: "Principles" },
    ]},
    { day: 4, date: "Aug 14", items: [
      { name: "Separation of Concerns, Coupling & Cohesion", type: "theory", difficulty: "intermediate", category: "Principles" },
      { name: "Single Responsibility + Open/Closed", type: "theory", difficulty: "intermediate", category: "SOLID" },
    ]},
    { day: 5, date: "Aug 15", items: [
      { name: "Liskov Substitution + Interface Segregation", type: "theory", difficulty: "intermediate", category: "SOLID" },
      { name: "Dependency Inversion", type: "theory", difficulty: "intermediate", category: "SOLID" },
    ]},
    { day: 6, date: "Aug 16", items: [
      { name: "UML: Class Diagram, Sequence Diagram", type: "theory", difficulty: "intermediate", category: "UML" },
      { name: "UML: State Machine, Activity Diagram", type: "theory", difficulty: "intermediate", category: "UML" },
    ]},
  ]},
  { week: 2, phase: 1, title: "Design Patterns: Creational + Structural", days: [
    { day: 7, date: "Aug 18", items: [
      { name: "Singleton + Builder", type: "pattern", difficulty: "beginner", category: "Creational" },
      { name: "Factory Method + Abstract Factory", type: "pattern", difficulty: "intermediate", category: "Creational", tags: ["LLD+SM"] },
    ]},
    { day: 8, date: "Aug 19", items: [
      { name: "Prototype", type: "pattern", difficulty: "intermediate", category: "Creational" },
      { name: "Adapter + Facade", type: "pattern", difficulty: "beginner", category: "Structural" },
    ]},
    { day: 9, date: "Aug 20", items: [
      { name: "Decorator + Composite", type: "pattern", difficulty: "intermediate", category: "Structural", tags: ["LLD+SM"] },
      { name: "Proxy + Bridge", type: "pattern", difficulty: "intermediate", category: "Structural" },
    ]},
    { day: 10, date: "Aug 21", items: [
      { name: "Flyweight", type: "pattern", difficulty: "advanced", category: "Structural" },
      { name: "🏗️ LLD: Parking Lot", type: "build", difficulty: "beginner", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 11, date: "Aug 22", items: [
      { name: "🏗️ LLD: Elevator System", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 12, date: "Aug 23", items: [
      { name: "Review: Creational + Structural patterns", type: "theory", difficulty: "beginner", category: "Review" },
    ]},
  ]},
  { week: 3, phase: 1, title: "Design Patterns: Behavioral + Advanced", days: [
    { day: 13, date: "Aug 25", items: [
      { name: "Strategy + Iterator", type: "pattern", difficulty: "beginner", category: "Behavioral" },
      { name: "Observer + Command", type: "pattern", difficulty: "intermediate", category: "Behavioral", tags: ["LLD+SM"] },
    ]},
    { day: 14, date: "Aug 26", items: [
      { name: "State + Template Method", type: "pattern", difficulty: "intermediate", category: "Behavioral" },
      { name: "Chain of Responsibility", type: "pattern", difficulty: "intermediate", category: "Behavioral", tags: ["LLD+SM"] },
    ]},
    { day: 15, date: "Aug 27", items: [
      { name: "Visitor + Mediator + Memento", type: "pattern", difficulty: "advanced", category: "Behavioral" },
      { name: "🏗️ LLD: Library Management", type: "build", difficulty: "beginner", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 16, date: "Aug 28", items: [
      { name: "Null Object, Repository, MVC, DI Pattern", type: "pattern", difficulty: "intermediate", category: "Additional" },
      { name: "🏗️ LLD: Snake Game", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 17, date: "Aug 29", items: [
      { name: "Game Loop, Thread Pool, Producer-Consumer", type: "pattern", difficulty: "advanced", category: "Additional", tags: ["SD+SM"] },
      { name: "Specification Pattern", type: "pattern", difficulty: "advanced", category: "Additional" },
    ]},
    { day: 18, date: "Aug 30", items: [
      { name: "LLD Interview Approach + Entity Modeling", type: "theory", difficulty: "intermediate", category: "Interview Tips" },
      { name: "How to choose Design Patterns", type: "theory", difficulty: "intermediate", category: "Interview Tips" },
    ]},
  ]},

  // ═══════════════════════════════════════════
  // PHASE 2: LLD PROBLEMS (Sep 1 - Sep 27)
  // Build at class/object level
  // ═══════════════════════════════════════════
  { week: 4, phase: 2, title: "LLD: State Machines + Concurrency", days: [
    { day: 19, date: "Sep 1", items: [
      { name: "🏗️ LLD: Splitwise", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD"] },
      { name: "Concurrency: Locks, Semaphores, Mutexes", type: "theory", difficulty: "intermediate", category: "Concurrency" },
    ]},
    { day: 20, date: "Sep 2", items: [
      { name: "🏗️ LLD: Vending Machine", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 21, date: "Sep 3", items: [
      { name: "🏗️ LLD: Chess Game", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 22, date: "Sep 4", items: [
      { name: "🏗️ LLD: Chess Game (continued)", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 23, date: "Sep 5", items: [
      { name: "Machine Coding Practice: Tic Tac Toe (60 min timed)", type: "build", difficulty: "beginner", category: "Machine Coding" },
    ]},
    { day: 24, date: "Sep 6", items: [
      { name: "Review: State Pattern + machine coding approach", type: "theory", difficulty: "intermediate", category: "Review" },
    ]},
  ]},
  { week: 5, phase: 2, title: "LLD: Data Structures + Caching", days: [
    { day: 25, date: "Sep 8", items: [
      { name: "🏗️ LLD: Hotel Booking System", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 26, date: "Sep 9", items: [
      { name: "🏗️ LLD: LRU Cache", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 27, date: "Sep 10", items: [
      { name: "🏗️ LLD: Rate Limiter", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "LLD+SM", "SD+LLD"] },
    ]},
    { day: 28, date: "Sep 11", items: [
      { name: "🏗️ LLD: Task Scheduler", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 29, date: "Sep 12", items: [
      { name: "🏗️ LLD: Logging Framework", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "LLD+SM"] },
    ]},
    { day: 30, date: "Sep 13", items: [
      { name: "Machine Coding: Search Autocomplete (90 min timed)", type: "build", difficulty: "intermediate", category: "Machine Coding", tags: ["LLD", "SD+LLD"] },
    ]},
  ]},
  { week: 6, phase: 2, title: "LLD: Platforms + Communication", days: [
    { day: 31, date: "Sep 15", items: [
      { name: "🏗️ LLD: Notification System", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 32, date: "Sep 16", items: [
      { name: "🏗️ LLD: Pub-Sub System", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+SM"] },
    ]},
    { day: 33, date: "Sep 17", items: [
      { name: "🏗️ LLD: Chat Application", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 34, date: "Sep 18", items: [
      { name: "🏗️ LLD: URL Shortener", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 35, date: "Sep 19", items: [
      { name: "🏗️ LLD: Shopping Cart", type: "build", difficulty: "intermediate", category: "LLD Problem", tags: ["LLD"] },
    ]},
    { day: 36, date: "Sep 20", items: [
      { name: "Machine Coding: Payment Gateway (90 min timed)", type: "build", difficulty: "intermediate", category: "Machine Coding", tags: ["LLD"] },
    ]},
  ]},
  { week: 7, phase: 2, title: "LLD: Advanced + Mock Practice", days: [
    { day: 37, date: "Sep 22", items: [
      { name: "🏗️ LLD: Movie Booking System", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 38, date: "Sep 23", items: [
      { name: "🏗️ LLD: Ride Hailing Service", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 39, date: "Sep 24", items: [
      { name: "🏗️ LLD: Online Food Delivery", type: "build", difficulty: "advanced", category: "LLD Problem", tags: ["LLD", "SD+LLD"] },
    ]},
    { day: 40, date: "Sep 25", items: [
      { name: "Mock LLD Interview: Random problem (60 min)", type: "build", difficulty: "intermediate", category: "Mock" },
    ]},
    { day: 41, date: "Sep 26", items: [
      { name: "Mock LLD Interview: Random problem (60 min)", type: "build", difficulty: "advanced", category: "Mock" },
    ]},
    { day: 42, date: "Sep 27", items: [
      { name: "LLD Phase Review + Pattern Summary Document", type: "theory", difficulty: "beginner", category: "Review" },
    ]},
  ]},

  // ═══════════════════════════════════════════
  // PHASE 3: HLD CONCEPTS + TECHNOLOGIES (Sep 29 - Oct 25)
  // System-level thinking
  // ═══════════════════════════════════════════
  { week: 8, phase: 3, title: "HLD: Fundamentals + Networking + Databases", days: [
    { day: 43, date: "Sep 29", items: [
      { name: "What are SD Interviews? + Types + Expectations", type: "hld", difficulty: "beginner", category: "HLD Intro" },
      { name: "Networking: HTTP, TCP, DNS, CDNs", type: "hld", difficulty: "beginner", category: "HLD Concepts" },
    ]},
    { day: 44, date: "Sep 30", items: [
      { name: "API Design: REST, GraphQL, gRPC", type: "hld", difficulty: "intermediate", category: "HLD Concepts", tags: ["SD+SM"] },
      { name: "Database Design: SQL vs NoSQL, Sharding, Replication", type: "hld", difficulty: "intermediate", category: "HLD Concepts" },
    ]},
    { day: 45, date: "Oct 1", items: [
      { name: "Caching: Strategies, Invalidation, Redis/Memcached", type: "hld", difficulty: "intermediate", category: "HLD Concepts", tags: ["SD+SM", "SD+LLD"] },
      { name: "Distributed Systems: CAP, Consistency models", type: "hld", difficulty: "advanced", category: "HLD Concepts" },
    ]},
    { day: 46, date: "Oct 2", items: [
      { name: "Tradeoffs + Data Structures for Scale", type: "hld", difficulty: "intermediate", category: "HLD Concepts" },
      { name: "PostgreSQL + MySQL deep dive", type: "hld", difficulty: "intermediate", category: "Technologies" },
    ]},
    { day: 47, date: "Oct 3", items: [
      { name: "MongoDB + Redis deep dive", type: "hld", difficulty: "intermediate", category: "Technologies", tags: ["SD+SM"] },
      { name: "DynamoDB + Cassandra", type: "hld", difficulty: "intermediate", category: "Technologies" },
    ]},
    { day: 48, date: "Oct 4", items: [
      { name: "Elasticsearch + Kafka deep dive", type: "hld", difficulty: "intermediate", category: "Technologies", tags: ["SD+SM"] },
      { name: "RabbitMQ + SQS", type: "hld", difficulty: "intermediate", category: "Technologies" },
    ]},
  ]},
  { week: 9, phase: 3, title: "HLD: Infrastructure + Patterns", days: [
    { day: 49, date: "Oct 6", items: [
      { name: "S3 + AWS Lambda + Nginx", type: "hld", difficulty: "intermediate", category: "Technologies" },
      { name: "Docker + Kubernetes", type: "hld", difficulty: "advanced", category: "Technologies", tags: ["SD+SM"] },
    ]},
    { day: 50, date: "Oct 7", items: [
      { name: "Zookeeper + Prometheus", type: "hld", difficulty: "advanced", category: "Technologies" },
      { name: "Realtime Updates + Fanout Pattern", type: "hld", difficulty: "intermediate", category: "HLD Patterns", tags: ["SD+LLD"] },
    ]},
    { day: 51, date: "Oct 8", items: [
      { name: "High Read Traffic + High Write Traffic", type: "hld", difficulty: "intermediate", category: "HLD Patterns" },
      { name: "Handling Hot Keys + Traffic Spikes", type: "hld", difficulty: "intermediate", category: "HLD Patterns" },
    ]},
    { day: 52, date: "Oct 9", items: [
      { name: "Handling Large Files + Media Streaming", type: "hld", difficulty: "advanced", category: "HLD Patterns" },
      { name: "Location Data + Unique ID Generation", type: "hld", difficulty: "intermediate", category: "HLD Patterns" },
    ]},
    { day: 53, date: "Oct 10", items: [
      { name: "Distributed Counting + Leader Election", type: "hld", difficulty: "advanced", category: "HLD Patterns" },
      { name: "Failure Detection + Handling Failures", type: "hld", difficulty: "intermediate", category: "HLD Patterns" },
    ]},
    { day: 54, date: "Oct 11", items: [
      { name: "Recommendations + Multi-Tenancy", type: "hld", difficulty: "advanced", category: "HLD Patterns" },
      { name: "Multi-Region + Deduplication", type: "hld", difficulty: "advanced", category: "HLD Patterns" },
    ]},
  ]},
  { week: 10, phase: 3, title: "HLD: Advanced Patterns + Interview Framework", days: [
    { day: 55, date: "Oct 13", items: [
      { name: "Distributed Transactions + Removing SPOFs", type: "hld", difficulty: "advanced", category: "HLD Patterns", tags: ["SD+SM"] },
      { name: "Answering Framework + Estimation Cheatsheet", type: "hld", difficulty: "beginner", category: "Interview Tips" },
    ]},
    { day: 56, date: "Oct 14", items: [
      { name: "Diagramming Tips + Choosing Databases", type: "hld", difficulty: "intermediate", category: "Interview Tips" },
      { name: "SD Interview Dry Run: URL Shortener (practice framework)", type: "hld", difficulty: "beginner", category: "Practice" },
    ]},
    { day: 57, date: "Oct 15", items: [
      { name: "SD Interview Dry Run: Pastebin", type: "hld", difficulty: "beginner", category: "Practice" },
    ]},
    { day: 58, date: "Oct 16", items: [
      { name: "SD Interview Dry Run: WhatsApp", type: "hld", difficulty: "intermediate", category: "Practice", tags: ["SD+LLD"] },
    ]},
    { day: 59, date: "Oct 17", items: [
      { name: "SD Interview Dry Run: Instagram", type: "hld", difficulty: "intermediate", category: "Practice" },
    ]},
    { day: 60, date: "Oct 18", items: [
      { name: "Review: All HLD concepts + patterns", type: "theory", difficulty: "beginner", category: "Review" },
    ]},
  ]},
  { week: 11, phase: 3, title: "HLD: Real-Time + Social + Media Systems", days: [
    { day: 61, date: "Oct 20", items: [
      { name: "Design WhatsApp (full)", type: "hld", difficulty: "intermediate", category: "Real-Time", tags: ["SD+LLD"] },
      { name: "Design Slack", type: "hld", difficulty: "intermediate", category: "Real-Time" },
    ]},
    { day: 62, date: "Oct 21", items: [
      { name: "Design Google Docs", type: "hld", difficulty: "advanced", category: "Real-Time" },
      { name: "Design Zoom", type: "hld", difficulty: "advanced", category: "Real-Time" },
    ]},
    { day: 63, date: "Oct 22", items: [
      { name: "Design Instagram", type: "hld", difficulty: "intermediate", category: "Social Media" },
      { name: "Design TikTok / FB News Feed", type: "hld", difficulty: "intermediate", category: "Social Media" },
    ]},
    { day: 64, date: "Oct 23", items: [
      { name: "Design Reddit + Tinder", type: "hld", difficulty: "intermediate", category: "Social Media" },
      { name: "Design Spotify", type: "hld", difficulty: "intermediate", category: "Social Media" },
    ]},
    { day: 65, date: "Oct 24", items: [
      { name: "Design YouTube", type: "hld", difficulty: "intermediate", category: "Media", tags: ["SD+LLD"] },
      { name: "Design Netflix + Google Drive", type: "hld", difficulty: "intermediate", category: "Media" },
    ]},
    { day: 66, date: "Oct 25", items: [
      { name: "Design Twitch + Gmail", type: "hld", difficulty: "advanced", category: "Media" },
    ]},
  ]},

  // ═══════════════════════════════════════════
  // PHASE 4: HLD PROBLEMS (Oct 27 - Nov 29)
  // Design at system level
  // ═══════════════════════════════════════════
  { week: 12, phase: 4, title: "HLD: Location + Search + E-commerce", days: [
    { day: 67, date: "Oct 27", items: [
      { name: "Design Airbnb", type: "hld", difficulty: "intermediate", category: "Location" },
      { name: "Design Food Delivery Service", type: "hld", difficulty: "intermediate", category: "Location", tags: ["SD+LLD"] },
    ]},
    { day: 68, date: "Oct 28", items: [
      { name: "Design Uber", type: "hld", difficulty: "advanced", category: "Location", tags: ["SD+LLD"] },
      { name: "Design Google Maps", type: "hld", difficulty: "advanced", category: "Location" },
    ]},
    { day: 69, date: "Oct 29", items: [
      { name: "Design Search Autocomplete", type: "hld", difficulty: "beginner", category: "Search", tags: ["SD+LLD"] },
      { name: "Design Web Crawler", type: "hld", difficulty: "intermediate", category: "Search" },
    ]},
    { day: 70, date: "Oct 30", items: [
      { name: "Design Google Search", type: "hld", difficulty: "advanced", category: "Search" },
      { name: "Design News Aggregator", type: "hld", difficulty: "intermediate", category: "Search" },
    ]},
    { day: 71, date: "Oct 31", items: [
      { name: "Design Amazon", type: "hld", difficulty: "intermediate", category: "E-commerce" },
      { name: "Design Flash Sale System", type: "hld", difficulty: "advanced", category: "E-commerce" },
    ]},
    { day: 72, date: "Nov 1", items: [
      { name: "Design Movie Booking", type: "hld", difficulty: "advanced", category: "E-commerce", tags: ["SD+LLD"] },
      { name: "Design Online Auction", type: "hld", difficulty: "advanced", category: "E-commerce" },
    ]},
  ]},
  { week: 13, phase: 4, title: "HLD: Payments + Infrastructure", days: [
    { day: 73, date: "Nov 3", items: [
      { name: "Design Payment System", type: "hld", difficulty: "intermediate", category: "Payments", tags: ["SD+LLD"] },
      { name: "Design Digital Wallet", type: "hld", difficulty: "advanced", category: "Payments" },
    ]},
    { day: 74, date: "Nov 4", items: [
      { name: "Design Stock Exchange", type: "hld", difficulty: "advanced", category: "Payments", tags: ["SD+LLD"] },
      { name: "Design Ad Click Aggregator", type: "hld", difficulty: "advanced", category: "Payments" },
    ]},
    { day: 75, date: "Nov 5", items: [
      { name: "Design Load Balancer", type: "hld", difficulty: "intermediate", category: "Infrastructure" },
      { name: "Design API Gateway", type: "hld", difficulty: "intermediate", category: "Infrastructure", tags: ["SD+SM"] },
    ]},
    { day: 76, date: "Nov 6", items: [
      { name: "Design Rate Limiter (system level)", type: "hld", difficulty: "intermediate", category: "Infrastructure", tags: ["SD+LLD", "SD+SM"] },
      { name: "Design Key-Value Store", type: "hld", difficulty: "advanced", category: "Infrastructure", tags: ["SD+LLD"] },
    ]},
    { day: 77, date: "Nov 7", items: [
      { name: "Design Distributed Cache", type: "hld", difficulty: "advanced", category: "Infrastructure", tags: ["SD+LLD", "SD+SM"] },
      { name: "Design CDN", type: "hld", difficulty: "advanced", category: "Infrastructure" },
    ]},
    { day: 78, date: "Nov 8", items: [
      { name: "Design Object Storage (S3)", type: "hld", difficulty: "advanced", category: "Infrastructure" },
      { name: "Design Messaging Queue", type: "hld", difficulty: "advanced", category: "Infrastructure", tags: ["SD+SM"] },
    ]},
  ]},
  { week: 14, phase: 4, title: "HLD: Async + Counting + Specialized", days: [
    { day: 79, date: "Nov 10", items: [
      { name: "Design Time Series Database", type: "hld", difficulty: "advanced", category: "Infrastructure" },
      { name: "Design Locking Service", type: "hld", difficulty: "advanced", category: "Infrastructure" },
    ]},
    { day: 80, date: "Nov 11", items: [
      { name: "Design Likes Counting System", type: "hld", difficulty: "intermediate", category: "Counting" },
      { name: "Design Real Time Leaderboard", type: "hld", difficulty: "intermediate", category: "Counting", tags: ["SD+LLD"] },
    ]},
    { day: 81, date: "Nov 12", items: [
      { name: "Design Top K", type: "hld", difficulty: "advanced", category: "Counting" },
      { name: "Design Notification Service", type: "hld", difficulty: "intermediate", category: "Async", tags: ["SD+LLD"] },
    ]},
    { day: 82, date: "Nov 13", items: [
      { name: "Design Job Scheduler", type: "hld", difficulty: "intermediate", category: "Async", tags: ["SD+LLD", "SD+SM"] },
      { name: "Design CI/CD Pipeline", type: "hld", difficulty: "intermediate", category: "Async" },
    ]},
    { day: 83, date: "Nov 14", items: [
      { name: "Design Monitoring and Alerting", type: "hld", difficulty: "intermediate", category: "Async" },
      { name: "Design Calendar System", type: "hld", difficulty: "advanced", category: "Specialized" },
    ]},
    { day: 84, date: "Nov 15", items: [
      { name: "Design Online Chess (HLD)", type: "hld", difficulty: "advanced", category: "Specialized", tags: ["SD+LLD"] },
      { name: "Design LeetCode Platform", type: "hld", difficulty: "intermediate", category: "Specialized" },
    ]},
  ]},

  // ═══════════════════════════════════════════
  // PHASE 5: COMBINED LLD+HLD (Nov 17 - Dec 6)
  // Same system, both levels
  // ═══════════════════════════════════════════
  { week: 15, phase: 5, title: "Combined: Design + Build (Real-Time Systems)", days: [
    { day: 85, date: "Nov 17", items: [
      { name: "WhatsApp: HLD review + LLD implementation focus", type: "build", difficulty: "intermediate", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 86, date: "Nov 18", items: [
      { name: "Rate Limiter: HLD distributed + LLD algorithms", type: "build", difficulty: "intermediate", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 87, date: "Nov 19", items: [
      { name: "Notification System: HLD async + LLD pub-sub", type: "build", difficulty: "intermediate", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 88, date: "Nov 20", items: [
      { name: "Payment System: HLD distributed tx + LLD state machine", type: "build", difficulty: "advanced", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 89, date: "Nov 21", items: [
      { name: "Mock: Full design round (HLD + LLD deep dive)", type: "build", difficulty: "advanced", category: "Mock" },
    ]},
    { day: 90, date: "Nov 22", items: [
      { name: "Mock: Full design round (HLD + LLD deep dive)", type: "build", difficulty: "advanced", category: "Mock" },
    ]},
  ]},
  { week: 16, phase: 5, title: "Combined: Design + Build (Infrastructure)", days: [
    { day: 91, date: "Nov 24", items: [
      { name: "Key-Value Store: HLD partitioning + LLD data structures", type: "build", difficulty: "advanced", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 92, date: "Nov 25", items: [
      { name: "Job Scheduler: HLD queue + LLD priority/retry", type: "build", difficulty: "advanced", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 93, date: "Nov 26", items: [
      { name: "Uber: HLD location + LLD matching algorithm", type: "build", difficulty: "advanced", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 94, date: "Nov 27", items: [
      { name: "Movie Booking: HLD concurrency + LLD seat locking", type: "build", difficulty: "advanced", category: "Combined", tags: ["ALL"] },
    ]},
    { day: 95, date: "Nov 28", items: [
      { name: "Mock: Full design round (random system)", type: "build", difficulty: "advanced", category: "Mock" },
    ]},
    { day: 96, date: "Nov 29", items: [
      { name: "Mock: Full design round (random system)", type: "build", difficulty: "advanced", category: "Mock" },
    ]},
  ]},
]

export const DESIGN_TOTAL = DESIGN_PLAN.reduce((acc, w) => acc + w.days.reduce((a, d) => a + d.items.length, 0), 0)

export const DESIGN_PHASES = [
  { phase: 1, name: 'Foundations', description: 'OOP, SOLID, Design Patterns', weeks: '1-3' },
  { phase: 2, name: 'LLD Problems', description: 'Build at class/object level', weeks: '4-7' },
  { phase: 3, name: 'HLD Concepts', description: 'System-level thinking + technologies', weeks: '8-11' },
  { phase: 4, name: 'HLD Problems', description: 'Design at system scale', weeks: '12-14' },
  { phase: 5, name: 'Combined', description: 'Same system, both zoom levels', weeks: '15-16' },
]
