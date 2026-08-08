# Basecamp — Unified Master Plan

> **Duration:** Jul 18, 2026 → Dec 14, 2026 (22 weeks)  
> **Tracks:** DSA · LLD · System Design · Stack Mastery (.NET/AI/FE) · Projects  
> **Daily Budget:** 4-5 hours focused work

---

## Philosophy

Everything runs in parallel lanes. Each day has a clear focus split:
- **Morning (1.5h):** DSA problems + revision
- **Afternoon (2h):** Stack Mastery learning (concepts)
- **Evening (1h):** LLD study OR System Design study (alternating)
- **Weekend extra (2h):** Projects (build sessions)

Tags show when one activity covers multiple tracks:
- 🏷️ `[SD+SM]` = System Design concept reinforced by Stack Mastery implementation
- 🏷️ `[LLD+SM]` = LLD pattern practiced in Stack Mastery project
- 🏷️ `[SD+LLD]` = System Design topic that overlaps with LLD concepts
- 🏷️ `[ALL]` = Capstone/project touching all tracks

---

## Phase 1: Foundation (Jul 18 → Sep 6) — Weeks 1-7

**Goal:** Complete 150 DSA problems + begin LLD + Stack Mastery kickoff

### DSA Lane (3 problems/day, continues from existing plan)
- Week 1-3: Arrays, Two Pointers, Sliding Window, Stack, Binary Search, Linked List, Trees ✅ (mostly done)
- Week 4: Backtracking, Graphs (current)
- Week 5: Graphs, Adv. Graphs, 1-D DP
- Week 6: 2-D DP, Greedy
- Week 7: Greedy, Intervals, Math, Bits

### LLD Lane (starts Aug 11, alternating evenings with SD)

| Week | Topics | Problems |
|------|--------|----------|
| SM W1 (Aug 11) | OOP Refresher (skim), Class Relationships | — |
| SM W2 (Aug 18) | SOLID Principles, UML Basics | 🏗️ Parking Lot, 🏗️ Elevator |
| SM W3 (Aug 25) | Design Patterns: Creational (Singleton, Builder, Factory) | 🏗️ Library Mgmt, 🏗️ Snake Game |
| SM W4 (Sep 1) | Design Patterns: Structural (Adapter, Facade, Decorator) | 🏗️ Splitwise |

> 🏷️ `[LLD+SM]`: SM W4's "Build DI Container" directly teaches Factory + Singleton patterns

### Stack Mastery Lane (starts Aug 11, 6 days/week)

Weeks 1-4 as already planned:
- W1: .NET async/await + AI Math
- W2: .NET Threading + AI Gradient Descent → 🔨 Linear Regression
- W3: .NET GC & Memory + AI Neural Networks → 🔨 MNIST
- W4: .NET DI Container + AI Optimizers → 🔨 DI Container from scratch 🏷️ `[LLD+SM]`

### System Design Lane (starts Aug 15)

SD Weeks 1-2 only in this phase:
- W1: Intro + Concepts (networking, caching, API design, DBs, distributed systems)
- W2: Technology Deep Dives Part 1 (Postgres, Redis, Kafka, etc.)

> 🏷️ `[SD+SM]`: SM W2's "Channels: producer-consumer" maps directly to Kafka concepts in SD W2

---

## Phase 2: Intermediate (Sep 8 → Oct 19) — Weeks 8-13

**Goal:** DSA revision mastery + LLD patterns + SD problems start + Hybrid projects begin

### DSA Lane
- DSA plan complete by Sep 6
- Revision-only: 5 problems/day from redo queue (new spaced repetition strategy)
- Weekend mocks (4 problems, 90 min)

### LLD Lane (continues alternating evenings, 3-4 problems/week)

| Week | Topics | Problems |
|------|--------|----------|
| W5 (Sep 8) | Design Patterns: Behavioral (Strategy, Observer, Command, State) | 🏗️ Chess 🏗️ Vending Machine |
| W6 (Sep 15) | Design Patterns: Advanced (Memento, Visitor, Chain of Resp) | 🏗️ Hotel Booking |
| W7 (Sep 22) | Concurrency Patterns, Thread Safety | 🏗️ LRU Cache 🏷️ `[LLD+SM]` |
| W8 (Sep 29) | Interview Approach, Clean Code, Entity Modeling | 🏗️ Task Scheduler |
| W9 (Oct 6) | Machine Coding Practice (timed 90-min builds) | 🏗️ Rate Limiter 🏷️ `[LLD+SM+SD]` |
| W10 (Oct 13) | Machine Coding Practice | 🏗️ Logger Framework |

> 🏷️ `[LLD+SM]`: SM W5's "Custom Middleware Library" IS the Rate Limiter LLD problem
> 🏷️ `[LLD+SM+SD]`: Cache design = LLD problem + SD Infrastructure + SM memory management

### Stack Mastery Lane

- W5: .NET Middleware + AI Embeddings/CNNs → 🔨 Middleware Library 🏷️ `[LLD+SM]`
- W6: .NET EF Core + AI Transformers
- W7: .NET EF Advanced + AI GPT Architecture → 🔨 BPE Tokenizer
- W8: .NET ASP.NET Internals + AI RAG Fundamentals
- W9: .NET Distributed Patterns + AI RAG Build → 🔨 Outbox+Saga 🏷️ `[SD+SM]`, 🔨 RAG Pipeline
- W10: Azure Cosmos DB + AI Fine-tuning → 🔨 Fine-tune model

### System Design Lane (ramps up, problems begin)

| SD Week | Focus | Key Problems |
|---------|-------|-------------|
| W3 (Sep 8) | Tech Deep Dives 2 + Patterns | Docker, K8s, Realtime patterns |
| W4 (Sep 15) | Patterns Continued | Distributed transactions, multi-region |
| W5 (Sep 22) | Tips + Basic Problems | 🏗️ URL Shortener, 🏗️ WhatsApp 🏷️ `[SD+SM]` |
| W6 (Sep 29) | Real-Time + Social Media | Instagram, Reddit, Spotify |
| W7 (Oct 6) | Media + Location | YouTube, Netflix, Uber |
| W8 (Oct 13) | Search + E-commerce | Search Autocomplete, Web Crawler |

> 🏷️ `[SD+SM]`: WhatsApp design is directly built as "Real-time Chat Service" hybrid project

### Hybrid Projects (weekends, 3-4h sessions)

| When | Project | Tags |
|------|---------|------|
| Sep 13-14 | URL Shortener + Analytics | 🏷️ `[SD+SM+LLD]` |
| Sep 20-21 | Real-time Chat Service | 🏷️ `[SD+SM]` |
| Sep 27-28 | Distributed Rate Limiter | 🏷️ `[LLD+SM+SD]` |
| Oct 4-5 | Real-time Leaderboard | 🏷️ `[SD+SM]` |
| Oct 11-12 | Semantic Search Engine | 🏷️ `[SD+SM]` |
| Oct 18-19 | Distributed Task Queue | 🏷️ `[SD+SM+LLD]` |

---

## Phase 3: Advanced (Oct 20 → Nov 16) — Weeks 14-17

**Goal:** SD infrastructure + AI agents + advanced LLD + capstone project

### DSA Lane
- Revision continues (3-4/day, mostly maintaining)
- Phase 2 selective problems added (30-40 from 250) if gaps identified

### LLD Lane (machine coding focus)

| Week | Focus |
|------|-------|
| W11 (Oct 20) | Timed builds: Social platforms (Stack Overflow, Chat App) |
| W12 (Oct 27) | Timed builds: E-commerce (Shopping Cart, Booking System) |
| W13 (Nov 3) | Timed builds: Financial (Payment Gateway, Stock Exchange) |
| W14 (Nov 10) | Mock LLD interviews (simulate real conditions) |

### Stack Mastery Lane

- W11: Azure Functions/Bus/Grid + AI Evaluation
- W12: .NET Performance + AI Agents → 🔨 Agent with tools 🏷️ `[SD+SM]`
- W13: Review + Mock Interviews + 🔨 Capstone 🏷️ `[ALL]`

### System Design Lane (infrastructure + advanced)

| SD Week | Focus | Key Problems |
|---------|-------|-------------|
| W9 (Oct 20) | E-commerce + Payments | Amazon, Flash Sale, Payment System |
| W10 (Oct 27) | Infrastructure | Rate Limiter, KV Store, Dist. Cache |
| W11 (Nov 3) | Infrastructure + Counting + Async | S3, Message Queue, Leaderboard |
| W12 (Nov 10) | Async + Specialized | Job Scheduler, CI/CD, LeetCode design |

### Capstone Project

**Healthcare AI Agent (Nov 3-16)** 🏷️ `[ALL]`
- .NET API with auth + rate limiting (SM + LLD)
- RAG pipeline with vector search (AI + SD)
- Agent with tool use and memory (AI)
- Distributed task processing (SD + SM)
- Full system design document (SD)
- Clean OOD architecture (LLD)

---

## Phase 4: Interview Prep (Nov 17 → Dec 14) — Weeks 18-22

**Goal:** Mock interviews, speed optimization, gap filling

### Weekly Structure

| Day | Focus |
|-----|-------|
| Mon | DSA Mock (4 problems, 90 min, blind) |
| Tue | LLD Mock (1 problem, 60 min, machine coding) |
| Wed | System Design Mock (1 design, 45 min, whiteboard) |
| Thu | DSA Mock + Revision |
| Fri | Behavioral prep + Portfolio review |
| Sat | Full mock interview simulation (all rounds) |
| Sun | Gap filling + light review |

### Success Criteria for Phase 4

- [ ] DSA: Solve any Medium in <15 min, any Hard in <30 min
- [ ] LLD: Complete machine coding round in 60 min with clean SOLID code
- [ ] SD: Present any design in 45 min hitting all checkpoints (requirements → HLD → deep dive → tradeoffs)
- [ ] Projects: Can explain capstone architecture in 5 min, demo in 10 min
- [ ] Revision: 80%+ problems at mastery level (4/4 or 2/2 redos)

---

## Master Timeline (Gantt View)

```
         Aug          Sep          Oct          Nov          Dec
     11  18  25  01  08  15  22  29  06  13  20  27  03  10  17  24  07  14
     ─────────────────────────────────────────────────────────────────────────
DSA  ████████████████████████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
     └─ 3/day solving ─────────┘└─ revision only (5/day) ──────────────────┘

LLD       ░░░░████████████████████████████████████████████░░░░░░░░░░░░░░░░░░
          └theory┘└── patterns ──┘└─ problems (build) ───┘└─ timed mocks ──┘

SD             ░░░░░░░░████████████████████████████████████████████░░░░░░░░░
               └concepts┘└─ tech + patterns ─┘└─ design problems ────────┘

SM   ██████████████████████████████████████████████████████████████░░░░░░░░░
     └─ .NET + AI + FE learning (6 days/week) ──────────────────┘└review──┘

PROJ           ░░░░░░░░░░░░░░██░░██░░██░░██░░██░░██████████████░░░░░░░░░░░░
                              └─ weekend builds (3-4h each) ──┘└capstone──┘

MOCK                                                               ██████████
                                                                   └─ full ─┘
```

---

## Cross-Reference: What Covers What

### Items that count for MULTIPLE tracks:

| Activity | DSA | LLD | SD | SM | Project |
|----------|:---:|:---:|:--:|:--:|:-------:|
| Build DI Container from scratch | | ✓ Factory/Singleton | | ✓ .NET W4 | |
| Custom Middleware (rate limiter) | | ✓ Chain of Resp, Decorator | ✓ Rate Limiter design | ✓ .NET W5 | ✓ |
| LRU Cache LLD | ✓ (DSA problem too) | ✓ Data Structure design | ✓ Distributed Cache | ✓ .NET memory | |
| Outbox Pattern + Saga | | | ✓ Distributed transactions | ✓ .NET W9 | ✓ |
| RAG Pipeline | | | ✓ Search Engine design | ✓ AI W9 | ✓ |
| Real-time Chat build | | ✓ Observer, Pub-Sub | ✓ WhatsApp design | ✓ .NET SignalR | ✓ |
| Channels: producer-consumer | | ✓ Producer-Consumer pattern | ✓ Message Queue | ✓ .NET W2 | |
| Task Scheduler | | ✓ Priority Queue, State | ✓ Job Scheduler design | ✓ Background services | ✓ |
| Healthcare Capstone | | ✓ Clean architecture | ✓ Multi-service design | ✓ .NET + AI | ✓ |

### LLD Patterns covered by Stack Mastery (no separate study needed):

| LLD Pattern | Where in SM |
|-------------|-------------|
| Singleton | SM W4: DI Container |
| Factory | SM W4: DI Container |
| Decorator | SM W5: Middleware |
| Chain of Responsibility | SM W5: Middleware |
| Observer | SM W2: Channels, SM W6: EF Change Tracker |
| Repository | SM W6-7: EF Core |
| Strategy | SM W5: Middleware (pluggable components) |
| Builder | SM W4: Options pattern |
| Pub-Sub | SM W9: Service Bus, Change Feed |

---

## Daily Schedule Template

### Weekday (4.5h total)

| Time | Block | Activity |
|------|-------|----------|
| 7:00-8:30 | Morning | DSA: 3 problems + 5 revisions |
| 12:00-14:00 | Afternoon | Stack Mastery: .NET or AI deep topic |
| 20:00-21:00 | Evening | Alternating: LLD (Mon/Wed/Fri) or SD (Tue/Thu) |

### Weekend (6h total)

| Time | Block | Activity |
|------|-------|----------|
| 8:00-9:30 | Morning | DSA: revision + weekend mock (4 problems) |
| 10:00-12:00 | Mid-day | Hybrid Project build session |
| 14:00-16:00 | Afternoon | LLD problem (build + document) or SD deep study |

---

## Key Milestones

| Date | Milestone | Verification |
|------|-----------|-------------|
| Sep 6 | 150 DSA problems complete | All plan checkboxes done |
| Sep 15 | First 4 LLD problems built | Code in repo, patterns documented |
| Sep 21 | First hybrid project (URL Shortener) deployed | Running locally |
| Oct 1 | 50% SD plan complete | Categories tab shows 50%+ |
| Oct 13 | All 12 LLD problems done | Projects page shows all green |
| Oct 19 | All 8 hybrid projects done | Projects page complete |
| Nov 3 | Capstone started | Architecture doc + first commit |
| Nov 16 | Capstone complete | Demo-ready |
| Dec 14 | Interview ready | Pass 3 consecutive full mock rounds |

---

*This plan lives at `tracker/MASTER_PLAN.md` and is the source of truth for all scheduling decisions.*
