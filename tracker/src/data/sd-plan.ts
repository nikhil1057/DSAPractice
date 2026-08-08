export interface SDProblem {
  name: string
  difficulty: 'beginner' | 'intermediate' | 'advanced'
  category: string
  build?: boolean
}

export interface SDDay {
  day: number
  date: string
  problems: SDProblem[]
}

export interface SDWeek {
  week: number
  title: string
  days: SDDay[]
}

export const SD_PLAN: SDWeek[] = [
  { week: 1, title: "Intro + Concepts", days: [
    { day: 1, date: "Aug 15", problems: [{ name: "What are SD Interviews?", difficulty: "beginner", category: "Intro" },{ name: "Types of SD Questions", difficulty: "beginner", category: "Intro" }]},
    { day: 2, date: "Aug 16", problems: [{ name: "Expectations by Level/YoE", difficulty: "beginner", category: "Intro" },{ name: "Concepts Must-Know", difficulty: "beginner", category: "Concepts" }]},
    { day: 3, date: "Aug 17", problems: [{ name: "Technologies Must-Know", difficulty: "beginner", category: "Concepts" },{ name: "Tradeoffs", difficulty: "intermediate", category: "Concepts" }]},
    { day: 4, date: "Aug 18", problems: [{ name: "Data Structures", difficulty: "intermediate", category: "Concepts" },{ name: "Networking", difficulty: "beginner", category: "Concepts" }]},
    { day: 5, date: "Aug 19", problems: [{ name: "Caching", difficulty: "intermediate", category: "Concepts" },{ name: "API Design", difficulty: "intermediate", category: "Concepts" }]},
    { day: 6, date: "Aug 20", problems: [{ name: "Database Design", difficulty: "intermediate", category: "Concepts" },{ name: "Distributed Systems", difficulty: "advanced", category: "Concepts" }]},
    { day: 7, date: "Aug 21", problems: [{ name: "Review Day", difficulty: "beginner", category: "Intro" }]}
  ]},
  { week: 2, title: "Technology Deep Dives Part 1", days: [
    { day: 8, date: "Aug 22", problems: [{ name: "PostgreSQL", difficulty: "intermediate", category: "Technologies" },{ name: "MySQL", difficulty: "intermediate", category: "Technologies" }]},
    { day: 9, date: "Aug 23", problems: [{ name: "MongoDB", difficulty: "intermediate", category: "Technologies" },{ name: "Redis", difficulty: "intermediate", category: "Technologies" }]},
    { day: 10, date: "Aug 24", problems: [{ name: "Memcached", difficulty: "intermediate", category: "Technologies" },{ name: "DynamoDB", difficulty: "intermediate", category: "Technologies" }]},
    { day: 11, date: "Aug 25", problems: [{ name: "Cassandra", difficulty: "advanced", category: "Technologies" },{ name: "Elasticsearch", difficulty: "intermediate", category: "Technologies" }]},
    { day: 12, date: "Aug 26", problems: [{ name: "Kafka", difficulty: "intermediate", category: "Technologies" },{ name: "RabbitMQ", difficulty: "intermediate", category: "Technologies" }]},
    { day: 13, date: "Aug 27", problems: [{ name: "SQS", difficulty: "intermediate", category: "Technologies" },{ name: "Flink", difficulty: "advanced", category: "Technologies" }]},
    { day: 14, date: "Aug 28", problems: [{ name: "Spark", difficulty: "advanced", category: "Technologies" },{ name: "S3", difficulty: "intermediate", category: "Technologies" }]}
  ]},
  { week: 3, title: "Tech Deep Dives Part 2 + Patterns", days: [
    { day: 15, date: "Aug 29", problems: [{ name: "AWS Lambda", difficulty: "intermediate", category: "Technologies" },{ name: "Nginx", difficulty: "intermediate", category: "Technologies" }]},
    { day: 16, date: "Aug 30", problems: [{ name: "Zookeeper", difficulty: "advanced", category: "Technologies" },{ name: "Docker", difficulty: "intermediate", category: "Technologies" }]},
    { day: 17, date: "Aug 31", problems: [{ name: "Kubernetes", difficulty: "advanced", category: "Technologies" },{ name: "Prometheus", difficulty: "intermediate", category: "Technologies" }]},
    { day: 18, date: "Sep 1", problems: [{ name: "Realtime Updates", difficulty: "intermediate", category: "Patterns" },{ name: "Fanout Pattern", difficulty: "intermediate", category: "Patterns" }]},
    { day: 19, date: "Sep 2", problems: [{ name: "High Read Traffic", difficulty: "intermediate", category: "Patterns" },{ name: "High Write Traffic", difficulty: "intermediate", category: "Patterns" }]},
    { day: 20, date: "Sep 3", problems: [{ name: "Handling Hot Keys", difficulty: "intermediate", category: "Patterns" },{ name: "Handling Traffic Spikes", difficulty: "intermediate", category: "Patterns" }]},
    { day: 21, date: "Sep 4", problems: [{ name: "Handling Large Files", difficulty: "intermediate", category: "Patterns" },{ name: "Media Streaming", difficulty: "advanced", category: "Patterns" }]}
  ]},
  { week: 4, title: "Patterns Continued", days: [
    { day: 22, date: "Sep 5", problems: [{ name: "Handling Location Data", difficulty: "intermediate", category: "Patterns" },{ name: "Generating Unique IDs", difficulty: "intermediate", category: "Patterns" }]},
    { day: 23, date: "Sep 6", problems: [{ name: "Distributed Counting", difficulty: "advanced", category: "Patterns" },{ name: "Leader Election", difficulty: "advanced", category: "Patterns" }]},
    { day: 24, date: "Sep 7", problems: [{ name: "Failure Detection", difficulty: "intermediate", category: "Patterns" },{ name: "Handling Failures", difficulty: "intermediate", category: "Patterns" }]},
    { day: 25, date: "Sep 8", problems: [{ name: "Recommendations", difficulty: "advanced", category: "Patterns" },{ name: "Multi-Tenancy", difficulty: "advanced", category: "Patterns" }]},
    { day: 26, date: "Sep 9", problems: [{ name: "Multi-Region Architecture", difficulty: "advanced", category: "Patterns" },{ name: "Deduplicating Data", difficulty: "intermediate", category: "Patterns" }]},
    { day: 27, date: "Sep 10", problems: [{ name: "Distributed Transactions", difficulty: "advanced", category: "Patterns" },{ name: "Removing Single Points of Failure", difficulty: "intermediate", category: "Patterns" }]},
    { day: 28, date: "Sep 11", problems: [{ name: "Answering Framework", difficulty: "beginner", category: "Tips" },{ name: "Estimation Cheatsheet", difficulty: "beginner", category: "Tips" }]}
  ]},
  { week: 5, title: "Tips + Basic + Real-Time", days: [
    { day: 29, date: "Sep 12", problems: [{ name: "Diagramming Tips", difficulty: "beginner", category: "Tips" },{ name: "Choosing the Right Database", difficulty: "intermediate", category: "Tips" }]},
    { day: 30, date: "Sep 13", problems: [{ name: "Design URL Shortener", difficulty: "beginner", category: "Basic Problems", build: true }]},
    { day: 31, date: "Sep 14", problems: [{ name: "Design Pastebin", difficulty: "beginner", category: "Basic Problems" }]},
    { day: 32, date: "Sep 15", problems: [{ name: "Design WhatsApp", difficulty: "intermediate", category: "Real-Time", build: true }]},
    { day: 33, date: "Sep 16", problems: [{ name: "Design Slack", difficulty: "intermediate", category: "Real-Time" }]},
    { day: 34, date: "Sep 17", problems: [{ name: "Design Live Comments", difficulty: "intermediate", category: "Real-Time" }]},
    { day: 35, date: "Sep 18", problems: [{ name: "Design Google Docs", difficulty: "advanced", category: "Real-Time", build: true }]}
  ]},
  { week: 6, title: "Real-Time + Social Media", days: [
    { day: 36, date: "Sep 19", problems: [{ name: "Design Zoom", difficulty: "advanced", category: "Real-Time" }]},
    { day: 37, date: "Sep 20", problems: [{ name: "Design Instagram", difficulty: "intermediate", category: "Social Media", build: true }]},
    { day: 38, date: "Sep 21", problems: [{ name: "Design FB News Feed", difficulty: "intermediate", category: "Social Media" }]},
    { day: 39, date: "Sep 22", problems: [{ name: "Design TikTok", difficulty: "intermediate", category: "Social Media" }]},
    { day: 40, date: "Sep 23", problems: [{ name: "Design Reddit", difficulty: "intermediate", category: "Social Media" }]},
    { day: 41, date: "Sep 24", problems: [{ name: "Design Tinder", difficulty: "intermediate", category: "Social Media" }]},
    { day: 42, date: "Sep 25", problems: [{ name: "Design Spotify", difficulty: "intermediate", category: "Social Media" }]}
  ]},
  { week: 7, title: "Media + Location", days: [
    { day: 43, date: "Sep 26", problems: [{ name: "Design YouTube", difficulty: "intermediate", category: "Media Streaming", build: true }]},
    { day: 44, date: "Sep 27", problems: [{ name: "Design Netflix", difficulty: "intermediate", category: "Media Streaming" }]},
    { day: 45, date: "Sep 28", problems: [{ name: "Design Google Drive", difficulty: "intermediate", category: "Media Streaming" }]},
    { day: 46, date: "Sep 29", problems: [{ name: "Design Gmail", difficulty: "advanced", category: "Media Streaming" }]},
    { day: 47, date: "Sep 30", problems: [{ name: "Design Twitch", difficulty: "advanced", category: "Media Streaming" }]},
    { day: 48, date: "Oct 1", problems: [{ name: "Design Airbnb", difficulty: "intermediate", category: "Location" }]},
    { day: 49, date: "Oct 2", problems: [{ name: "Design Food Delivery Service", difficulty: "intermediate", category: "Location" }]}
  ]},
  { week: 8, title: "Location + Search + E-commerce", days: [
    { day: 50, date: "Oct 3", problems: [{ name: "Design Uber", difficulty: "advanced", category: "Location", build: true }]},
    { day: 51, date: "Oct 4", problems: [{ name: "Design Google Maps", difficulty: "advanced", category: "Location" }]},
    { day: 52, date: "Oct 5", problems: [{ name: "Design Search Autocomplete", difficulty: "beginner", category: "Search", build: true }]},
    { day: 53, date: "Oct 6", problems: [{ name: "Design News Aggregator", difficulty: "intermediate", category: "Search" }]},
    { day: 54, date: "Oct 7", problems: [{ name: "Design Web Crawler", difficulty: "intermediate", category: "Search", build: true }]},
    { day: 55, date: "Oct 8", problems: [{ name: "Design Google Search", difficulty: "advanced", category: "Search" }]},
    { day: 56, date: "Oct 9", problems: [{ name: "Design Ad Click Aggregator", difficulty: "advanced", category: "Search", build: true }]}
  ]},
  { week: 9, title: "E-commerce + Payments", days: [
    { day: 57, date: "Oct 10", problems: [{ name: "Design Amazon", difficulty: "intermediate", category: "E-commerce" }]},
    { day: 58, date: "Oct 11", problems: [{ name: "Design Shopify", difficulty: "intermediate", category: "E-commerce" }]},
    { day: 59, date: "Oct 12", problems: [{ name: "Design Flash Sale", difficulty: "advanced", category: "E-commerce" }]},
    { day: 60, date: "Oct 13", problems: [{ name: "Design Online Auction System", difficulty: "advanced", category: "E-commerce" }]},
    { day: 61, date: "Oct 14", problems: [{ name: "Design Movie Booking System", difficulty: "advanced", category: "E-commerce" }]},
    { day: 62, date: "Oct 15", problems: [{ name: "Design Payment System", difficulty: "intermediate", category: "Payments", build: true }]},
    { day: 63, date: "Oct 16", problems: [{ name: "Design Digital Wallet", difficulty: "advanced", category: "Payments" }]}
  ]},
  { week: 10, title: "Infrastructure", days: [
    { day: 64, date: "Oct 17", problems: [{ name: "Design Stock Exchange", difficulty: "advanced", category: "Payments" }]},
    { day: 65, date: "Oct 18", problems: [{ name: "Design Load Balancer", difficulty: "intermediate", category: "Infrastructure" }]},
    { day: 66, date: "Oct 19", problems: [{ name: "Design API Gateway", difficulty: "intermediate", category: "Infrastructure" }]},
    { day: 67, date: "Oct 20", problems: [{ name: "Design Rate Limiter", difficulty: "intermediate", category: "Infrastructure", build: true }]},
    { day: 68, date: "Oct 21", problems: [{ name: "Design Key-Value Store", difficulty: "advanced", category: "Infrastructure", build: true }]},
    { day: 69, date: "Oct 22", problems: [{ name: "Design Distributed Cache", difficulty: "advanced", category: "Infrastructure", build: true }]},
    { day: 70, date: "Oct 23", problems: [{ name: "Design CDN", difficulty: "advanced", category: "Infrastructure" }]}
  ]},
  { week: 11, title: "Infrastructure + Counting + Async", days: [
    { day: 71, date: "Oct 24", problems: [{ name: "Design Object Storage like S3", difficulty: "advanced", category: "Infrastructure" }]},
    { day: 72, date: "Oct 25", problems: [{ name: "Design Messaging Queue", difficulty: "advanced", category: "Infrastructure", build: true }]},
    { day: 73, date: "Oct 26", problems: [{ name: "Design Time Series Database", difficulty: "advanced", category: "Infrastructure" }]},
    { day: 74, date: "Oct 27", problems: [{ name: "Design Locking Service", difficulty: "advanced", category: "Infrastructure" }]},
    { day: 75, date: "Oct 28", problems: [{ name: "Design Likes Counting System", difficulty: "intermediate", category: "Counting" }]},
    { day: 76, date: "Oct 29", problems: [{ name: "Design Real Time Leaderboard", difficulty: "intermediate", category: "Counting" }]},
    { day: 77, date: "Oct 30", problems: [{ name: "Design Top K", difficulty: "advanced", category: "Counting" }]},
    { day: 78, date: "Oct 31", problems: [{ name: "Design Notification Service", difficulty: "intermediate", category: "Async", build: true }]}
  ]},
  { week: 12, title: "Async + Specialized", days: [
    { day: 79, date: "Nov 1", problems: [{ name: "Design Job Scheduler", difficulty: "intermediate", category: "Async", build: true }]},
    { day: 80, date: "Nov 2", problems: [{ name: "Design CI/CD Pipeline", difficulty: "intermediate", category: "Async" }]},
    { day: 81, date: "Nov 3", problems: [{ name: "Design Monitoring and Alerting System", difficulty: "intermediate", category: "Async" }]},
    { day: 82, date: "Nov 4", problems: [{ name: "Design LeetCode", difficulty: "intermediate", category: "Specialized" }]},
    { day: 83, date: "Nov 5", problems: [{ name: "Design Calendar System", difficulty: "advanced", category: "Specialized" }]},
    { day: 84, date: "Nov 6", problems: [{ name: "Design Online Chess", difficulty: "advanced", category: "Specialized" }]},
    { day: 85, date: "Nov 7", problems: [{ name: "Review & Mock Practice", difficulty: "beginner", category: "Specialized" }]}
  ]}
]

export const SD_TOTAL = 113
