# Stack Mastery Plan — .NET Expert + AI Engineer

**Goal:** Be rock-solid in your entire stack — .NET internals, Azure deep, Python advanced, AI/ML fundamentals → applied  
**Start Date:** 2026-08-11 (Monday)  
**Phase 1 Target:** November 2026 (Interview Ready)  
**Phase 2 Target:** February 2027 (Deep Mastery)  
**Daily Time:** ~1.5 hrs (45 min .NET + 45 min AI), weekends flexible  

**Integration:** Runs alongside DSA (finishing Sep 3) and System Design (Aug 15 – Nov 7).  
When SD topics overlap with Stack Mastery (e.g., SD covers Kafka → Stack Mastery that week goes deeper on implementation), merge the study time.

---

## Learning Method (Every Topic)

1. **Understand** — Watch/read (Udemy, YouTube, docs) — 30%
2. **Code** — Hands-on implementation, no copy-paste — 50%
3. **Teach** — Write a 1-page summary OR explain to AI (me) — 20%

---

## Phase 1: Foundation (Aug 11 – Nov 9) — 13 Weeks

### Schedule Overview

| Week | .NET Track | AI Track | Project |
|------|-----------|----------|---------|
| 1 | async/await & Task internals | ML Math: Linear Algebra + Calculus intuition | — |
| 2 | Threading, ThreadPool, CancellationToken | Gradient Descent from scratch (Python) | 🔨 Linear Regression from scratch |
| 3 | GC internals, Memory<T>, Span<T> | Neural Networks: Perceptron → MLP | 🔨 MNIST classifier (no frameworks) |
| 4 | DI Container internals, Lifetimes | Backpropagation, Loss functions, Optimizers | — |
| 5 | Middleware pipeline, Custom middleware | CNNs + Word Embeddings (Word2Vec intuition) | 🔨 Custom .NET middleware library |
| 6 | EF Core internals: Change Tracker, Query Pipeline | Attention mechanism + Transformer architecture | — |
| 7 | EF Core: Compiled queries, Interceptors, Migrations | GPT architecture, Tokenization, KV Cache | 🔨 Build a mini tokenizer |
| 8 | ASP.NET Core internals: Kestrel, Routing, Filters | Prompt Engineering + RAG fundamentals | — |
| 9 | Distributed patterns: Outbox, Saga, Idempotency | RAG Pipeline: Chunking, Retrieval, Reranking | 🔨 RAG pipeline with evaluation |
| 10 | Azure Cosmos DB deep: Partitions, RUs, Consistency | Fine-tuning: LoRA, QLoRA, Data prep | 🔨 Fine-tune a small model |
| 11 | Azure: Functions scaling, Service Bus, Event Grid | Evaluation: BLEU, ROUGE, LLM-as-judge | — |
| 12 | Performance: BenchmarkDotNet, profiling, ArrayPool | Agents: Tool-use, Planning, Memory architecture | 🔨 Build an agent with tools |
| 13 | Review week + Mock interviews | Review + Build portfolio piece | 🔨 Capstone: combine both |

---

## Detailed Weekly Breakdown — Phase 1

---

### Week 1 (Aug 11-17): async/await Internals + ML Math

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | What async/await compiles to (state machine) | Read Sharplab.io output of async method, annotate |
| Tue | Task vs ValueTask vs Task<T> | Code: benchmark Task vs ValueTask in hot path |
| Wed | SynchronizationContext, ConfigureAwait | Code: deadlock demo in UI context, fix it |
| Thu | TaskCompletionSource, custom awaitables | Build a custom awaitable type |
| Fri | ExecutionContext flow, AsyncLocal<T> | Code: trace context propagation across awaits |
| Sat | Review + write 1-page summary | Teach it back |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Vectors, dot product, cosine similarity | Code: implement cosine similarity from scratch |
| Tue | Matrix multiplication intuition | Code: matmul in NumPy, visualize shapes |
| Wed | Derivatives, chain rule refresher | Khan Academy or 3Blue1Brown video |
| Thu | Partial derivatives, gradients | Compute gradient by hand for f(x,y) = x²y + 3x |
| Fri | What is a loss function? MSE, Cross-entropy | Code: implement MSE and CE in Python |
| Sat | Review: why this math matters for ML | Connect dots: gradient → optimization |

**Resources:**
- .NET: Stephen Cleary's blog (async series), Sharplab.io
- AI: 3Blue1Brown "Essence of Linear Algebra", "Neural Networks" series

---

### Week 2 (Aug 18-24): Threading + Gradient Descent

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | ThreadPool internals, work stealing | Code: ThreadPool.QueueUserWorkItem vs Task.Run |
| Tue | CancellationToken patterns | Code: implement cooperative cancellation in pipeline |
| Wed | Parallel.ForEachAsync, Channels | Build producer-consumer with Channel<T> |
| Thu | SemaphoreSlim, lock-free patterns | Code: rate limiter using SemaphoreSlim |
| Fri | IAsyncEnumerable, streaming patterns | Build streaming API endpoint |
| Sat | Review + integrate: async + threading mental model | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Gradient Descent algorithm explanation | Watch Andrej Karpathy "micrograd" lecture |
| Tue | Implement gradient descent for linear regression | Code from scratch in Python (no sklearn) |
| Wed | Learning rate, convergence, local minima | Experiment: plot loss curves with different LRs |
| Thu | Stochastic GD vs Mini-batch GD | Modify your code to use batches |
| Fri | 🔨 **PROJECT: Linear Regression from scratch** | Full implementation with visualization |
| Sat | Review: how does this connect to neural networks? | — |

**Resources:**
- .NET: "Concurrency in C# Cookbook" (Cleary), Marc Gravell's Channels posts
- AI: Andrej Karpathy "Neural Networks: Zero to Hero" (Lecture 1: micrograd)

---

### Week 3 (Aug 25-31): GC & Memory + Neural Networks

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | GC generations (Gen 0/1/2), Large Object Heap | Read: .NET GC docs, draw memory layout |
| Tue | GC modes (Workstation vs Server), tuning | Profile a .NET app with dotnet-counters |
| Wed | Span<T>, Memory<T>, stackalloc | Code: parse CSV using Span<T> (zero allocation) |
| Thu | ArrayPool<T>, MemoryPool<T> | Refactor an existing solution to use pooling |
| Fri | ref struct, Ref returns, Unsafe | Code: high-perf string manipulation with Span |
| Sat | Review + benchmark: before/after memory optimization | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Perceptron: single neuron, activation functions | Code: implement perceptron from scratch |
| Tue | Multi-layer perceptron, forward pass | Build 2-layer network (numpy only) |
| Wed | Backpropagation: chain rule applied | Hand-compute gradients for 2-layer net |
| Thu | Implement backprop in code | Extend your network with backprop |
| Fri | Activation functions: ReLU, Sigmoid, Softmax | Add to your network, compare |
| Sat | 🔨 **PROJECT: MNIST digit classifier (no PyTorch)** | Pure numpy, ~90% accuracy target |

**Resources:**
- .NET: Adam Sitnik's blogs, "Writing High-Performance .NET Code" (Watson)
- AI: Karpathy Lecture 2 (makemore), Nielsen's "Neural Networks and Deep Learning" Ch 1-2

---

### Week 4 (Sep 1-7): DI Internals + Backprop & Optimizers

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | How DI containers work: registration, resolution | Build a minimal DI container from scratch |
| Tue | Lifetimes deep: Transient, Scoped, Singleton traps | Code: demonstrate captive dependency bug |
| Wed | Service descriptors, IServiceProviderFactory | Extend your DI container with scopes |
| Thu | Keyed services (.NET 8), IServiceScopeFactory | Code: multi-tenant resolution by key |
| Fri | Options pattern: IOptions vs IOptionsSnapshot vs IOptionsMonitor | Build hot-reload config demo |
| Sat | Review: draw the full DI lifecycle diagram | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Optimizers: SGD, Momentum, Adam | Implement SGD + Momentum from scratch |
| Tue | Adam optimizer implementation | Code Adam, compare convergence vs SGD |
| Wed | Regularization: L1, L2, Dropout | Add dropout to your MNIST network |
| Thu | Batch Normalization | Understand why it works, implement |
| Fri | PyTorch basics: tensors, autograd, nn.Module | Rebuild your MNIST in PyTorch (compare) |
| Sat | Review: full training loop mental model | Diagram: data → forward → loss → backward → update |

**Resources:**
- .NET: Andrew Lock's blog (DI series), .NET source code (Microsoft.Extensions.DependencyInjection)
- AI: Karpathy Lecture 3 (activations & gradients), PyTorch official tutorials

---

### Week 5 (Sep 8-14): Middleware Pipeline + Embeddings & CNNs

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | ASP.NET middleware pipeline: how Use/Map/Run work | Draw the pipeline, trace a request |
| Tue | Writing custom middleware (logging, timing, auth) | Build: request timing + correlation ID middleware |
| Wed | Middleware ordering matters: exception handling, CORS | Code: demonstrate ordering bugs |
| Thu | Endpoint routing internals, route constraints | Build custom route constraint |
| Fri | 🔨 **PROJECT: Build reusable middleware library** | Rate limiter + request logging + health check |
| Sat | Review: full request lifecycle from Kestrel to response | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Word Embeddings: Word2Vec (Skip-gram, CBOW) | Understand: why words become vectors? |
| Tue | Train Word2Vec on small corpus | Use gensim, explore analogies (king - man + woman) |
| Wed | Sentence embeddings, document embeddings | Compare: TF-IDF vs Word2Vec avg vs Sentence-BERT |
| Thu | CNNs basics: convolution, pooling, feature maps | Code: simple CNN for image classification |
| Fri | 1D CNNs for text classification | Build: sentiment classifier with CNN |
| Sat | Review: embeddings are the bridge to transformers | — |

**Resources:**
- .NET: Andrew Lock "ASP.NET Core in Action" Ch 3-4, David Fowler's middleware talks
- AI: Jay Alammar "Illustrated Word2Vec", Stanford CS224N Lecture 1-2

---

### Week 6 (Sep 15-21): EF Core Internals + Attention & Transformers

*SD Overlap: This week SD covers real-time systems — merge SignalR knowledge with SD study*

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | EF Core: DbContext lifecycle, Change Tracker states | Code: trace entity state changes (Added/Modified/Detached) |
| Tue | Query pipeline: LINQ → Expression Tree → SQL | Use ToQueryString(), compare with raw SQL |
| Wed | Loading strategies: Eager, Explicit, Lazy, Split queries | Benchmark each approach, N+1 detection |
| Thu | Compiled queries, query filters, interceptors | Build: soft-delete interceptor + audit interceptor |
| Fri | Migrations internals, seeding, concurrency tokens | Handle concurrent updates with RowVersion |
| Sat | Review: when to use EF vs Dapper vs raw SQL | Decision matrix |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Attention mechanism: why RNNs fail at long sequences | Read: "Attention Is All You Need" (first pass) |
| Tue | Self-attention: Q, K, V matrices explained | Code: implement single-head attention from scratch |
| Wed | Multi-head attention, why multiple heads | Extend to multi-head, visualize attention weights |
| Thu | Positional encoding: sinusoidal + learned | Implement positional encoding |
| Fri | Full Transformer block: attention + FFN + LayerNorm | Build a transformer encoder block from scratch |
| Sat | Review: how BERT vs GPT differ (encoder vs decoder) | Draw architecture diagrams |

**Resources:**
- .NET: EF Core docs "How Queries Work", Julie Lerman Pluralsight courses
- AI: Jay Alammar "Illustrated Transformer", Karpathy "Let's build GPT"

---

### Week 7 (Sep 22-28): EF Core Advanced + GPT Architecture

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Raw SQL queries, FromSqlRaw, ExecuteSqlRaw | Build: complex reporting query mixing EF + raw |
| Tue | Value converters, owned types, table splitting | Code: DDD-style value objects with EF |
| Wed | Performance: AsNoTracking, projection, batching | Optimize a slow query (measure before/after) |
| Thu | Multi-tenancy with EF (query filters per tenant) | Build: tenant-isolated DbContext |
| Fri | Database-first vs Code-first, reverse engineering | — |
| Sat | Review: EF Core decision guide for your projects | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | GPT architecture: decoder-only, causal masking | Watch Karpathy "Let's build GPT" |
| Tue | Tokenization: BPE, SentencePiece, tiktoken | 🔨 **PROJECT: Build a BPE tokenizer from scratch** |
| Wed | KV Cache: why inference is O(n) without it | Implement: naive vs cached generation |
| Thu | Sampling: temperature, top-k, top-p, nucleus | Code: implement all sampling strategies |
| Fri | Scaling laws, emergent abilities, context windows | Read: Chinchilla paper summary |
| Sat | Review: I can explain how ChatGPT works end-to-end | Write 1-page explanation |

**Resources:**
- .NET: Julie Lerman's advanced EF courses, .NET Conf EF talks
- AI: Karpathy "Let's build GPT" (full video), Lilian Weng's blog

---

### Week 8 (Sep 29 - Oct 5): ASP.NET Core Internals + Prompt Engineering & RAG

*SD Overlap: SD is covering design problems — use RAG knowledge when SD discusses search systems*

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Kestrel server internals: connection handling, HTTP/2 | Read source, understand the pipeline |
| Tue | Model binding, validation, custom binders | Build: custom model binder for complex query params |
| Wed | Filters: Action, Result, Exception, Resource | Build: global exception filter + timing filter |
| Thu | Output caching, Response caching, ETags | Implement: conditional GET with ETags |
| Fri | Minimal APIs vs Controllers: when to use which | Benchmark both, understand tradeoffs |
| Sat | Review: full ASP.NET request pipeline diagram | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Prompt engineering: system/user/assistant roles | Practice: 10 different prompt patterns |
| Tue | Few-shot, chain-of-thought, ReAct pattern | Code: implement CoT in a real task |
| Wed | RAG overview: why, when, architecture | Draw: full RAG architecture diagram |
| Thu | Chunking strategies: fixed, semantic, recursive | Code: implement 3 chunking approaches, compare |
| Fri | Vector stores: FAISS, ChromaDB, pgvector | Build: index your own docs with ChromaDB |
| Sat | Review: RAG vs fine-tuning decision matrix | — |

**Resources:**
- .NET: David Fowler's ASP.NET talks, "ASP.NET Core in Action" Ch 5-8
- AI: LangChain docs, llamaindex docs, Pinecone learning center

---

### Week 9 (Oct 6-12): Distributed Patterns + RAG Pipeline Build

*SD Overlap: SD covers infrastructure this month — directly applicable to distributed patterns*

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Outbox pattern: reliable messaging without 2PC | Code: implement outbox with EF + background service |
| Tue | Saga pattern: orchestration vs choreography | Design: saga for multi-service order flow |
| Wed | Idempotency: idempotency keys, deduplication | Build: idempotent API endpoint with Redis |
| Thu | Eventual consistency: conflict resolution strategies | Code: last-writer-wins vs merge strategies |
| Fri | Circuit breaker deep: Polly v8, bulkhead, timeout | Build: resilient HTTP client with all policies |
| Sat | Review: draw your ProviderSearch system with these patterns | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Retrieval: dense vs sparse vs hybrid search | Code: implement BM25 + dense, compare |
| Tue | Reranking: cross-encoders, Cohere rerank | Add reranker to your pipeline |
| Wed | RAG evaluation: faithfulness, relevance, recall | Implement: RAGAS-style evaluation |
| Thu | Hallucination detection and mitigation | Build: citation extraction + verification |
| Fri | 🔨 **PROJECT: Full RAG pipeline with eval** | End-to-end on your PolicyCompiler docs |
| Sat | Review: compare with Mnemo's search — what's different? | — |

**Resources:**
- .NET: Jimmy Bogard's "Domain Events" talks, Particular Software (NServiceBus patterns)
- AI: RAGAS docs, LlamaIndex evaluation module, Anthropic RAG best practices

---

### Week 10 (Oct 13-19): Cosmos DB Deep + Fine-tuning

**.NET / Azure (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Cosmos DB: Partition key strategy, logical vs physical | Redesign: your ProviderSearch partition keys |
| Tue | RU calculation: reads, writes, queries, indexing cost | Measure: actual RU consumption for your queries |
| Wed | Consistency levels: Strong → Eventual, when to use each | Code: demo consistency difference with SDK |
| Thu | Indexing policies: include/exclude, composite indexes | Optimize: your existing Cosmos containers |
| Fri | Change Feed: real-time processing, materialized views | Build: change feed processor for audit trail |
| Sat | Review: Cosmos DB decision guide (vs SQL vs Mongo) | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | When to fine-tune vs prompt vs RAG | Decision framework |
| Tue | Data preparation: formatting, quality, deduplication | Prepare a dataset from your PolicyCompiler data |
| Wed | LoRA: how low-rank adaptation works | Read the LoRA paper, understand the math |
| Thu | QLoRA: quantization + LoRA, why it's practical | Setup: QLoRA with Hugging Face PEFT |
| Fri | 🔨 **PROJECT: Fine-tune a small model** | Fine-tune Phi-3 or Llama-3 on your domain data |
| Sat | Evaluation: compare base vs fine-tuned | Benchmark on held-out test set |

**Resources:**
- Azure: Cosmos DB docs "Partitioning", "Request Units", Azure Cosmos DB Conf talks
- AI: Hugging Face PEFT docs, Sebastian Raschka "LLM from Scratch" Ch 5-6

---

### Week 11 (Oct 20-26): Azure Advanced + LLM Evaluation

**.NET / Azure (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Azure Functions: scaling (consumption vs premium), cold start | Measure cold start, implement warm-up |
| Tue | Durable Functions: orchestration patterns | Build: fan-out/fan-in, human interaction pattern |
| Wed | Service Bus: topics, subscriptions, dead-letter, sessions | Build: ordered message processing with sessions |
| Thu | Event Grid vs Service Bus vs Event Hub: when to use | Decision matrix with code samples |
| Fri | APIM policies deep: caching, rate-limit, transform, mock | Write complex policy expressions |
| Sat | Review: Azure service selection guide | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Evaluation metrics: BLEU, ROUGE, BERTScore | Implement each, understand limitations |
| Tue | LLM-as-judge: using GPT to evaluate outputs | Build: automated eval pipeline |
| Wed | Human evaluation: annotation guidelines, inter-rater | Design eval rubric for your domain |
| Thu | Benchmarking: MMLU, HumanEval, domain-specific | Run your fine-tuned model on benchmarks |
| Fri | A/B testing LLMs in production | Design: how you'd A/B test PolicyCompiler |
| Sat | Review: full evaluation strategy document | — |

**Resources:**
- Azure: Azure Functions docs, Azure Cosmos DB Conf 2024, Jeff Hollan's talks
- AI: LMSYS Chatbot Arena, Hugging Face evaluate library, EleutherAI lm-eval

---

### Week 12 (Oct 27 - Nov 2): Performance + AI Agents

**.NET (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | BenchmarkDotNet: setup, attributes, memory diagnoser | Benchmark your existing solutions |
| Tue | dotnet-trace, dotnet-dump, profiling in production | Profile InternalAttestationApi locally |
| Wed | Object pooling, string interning, StringBuilder | Refactor: hot path optimization |
| Thu | Source generators: compile-time code gen | Build: simple source generator for DTOs |
| Fri | Minimal allocation patterns: ref struct, stackalloc | Code: parse HTTP headers zero-alloc |
| Sat | Review: performance checklist for production .NET | — |

**AI (45 min/day)**
| Day | Topic | Action |
|-----|-------|--------|
| Mon | Agent architectures: ReAct, Plan-and-Execute, LATS | Compare with your Ship/firstmate design |
| Tue | Tool use: function calling, structured output | Build: agent that calls real APIs |
| Wed | Memory in agents: short-term, long-term, episodic | Compare: how Mnemo does it vs LangChain |
| Thu | Multi-agent patterns: debate, delegation, hierarchy | Relate to your kiro-council pattern |
| Fri | 🔨 **PROJECT: Build an agent with tools + memory** | Healthcare domain: prior auth assistant |
| Sat | Review: agent design patterns document | — |

**Resources:**
- .NET: Adam Sitnik's performance blogs, "Pro .NET Memory Management" (Kokosa)
- AI: LangGraph docs, CrewAI, Andrew Ng's agent course (DeepLearning.ai)

---

### Week 13 (Nov 3-9): Review + Mock Interviews + Capstone

**.NET (All week — review mode)**
| Day | Topic |
|-----|-------|
| Mon | Mock: explain async/await internals in 5 minutes |
| Tue | Mock: whiteboard the ProviderSearch architecture |
| Wed | Mock: optimize a slow EF Core query live |
| Thu | Mock: design a resilient microservice from scratch |
| Fri | Mock: explain Cosmos DB partition strategy for 10M documents |
| Sat | Gap identification: what do I still not own? |

**AI (All week — review mode)**
| Day | Topic |
|-----|-------|
| Mon | Mock: explain transformer architecture from scratch |
| Tue | Mock: when to use RAG vs fine-tuning vs prompt engineering |
| Wed | Mock: design an AI system for document classification |
| Thu | Mock: evaluate and improve a RAG pipeline |
| Fri | 🔨 **CAPSTONE: Healthcare AI Agent** — combines RAG + tools + .NET backend |
| Sat | Phase 1 retrospective: what worked, what to adjust for Phase 2 |

---

## Phase 2: Deep Mastery (Nov 10 – Feb 2027) — 13 Weeks

### High-Level Topics (detailed plan built after Phase 1 retrospective)

| Week | .NET Track | AI Track |
|------|-----------|----------|
| 14-15 | gRPC, SignalR deep, real-time patterns | MLOps: serving, monitoring, versioning |
| 16-17 | Microservices patterns: CQRS, Event Sourcing | Vector databases: pgvector, Pinecone, Weaviate |
| 18-19 | .NET Aspire, Cloud-native patterns | Multi-modal: vision + text, audio models |
| 20-21 | Security: OAuth2/OIDC deep, API security | Safety & alignment: guardrails, red-teaming |
| 22-23 | Kubernetes deep: operators, service mesh, observability | Production LLM systems: caching, routing, fallback |
| 24-25 | Architecture: Clean Architecture, DDD tactical | Research papers: read 1/week, implement key ideas |
| 26 | Staff-level design exercise | Open source contribution (Docling or similar) |

---

## Projects Summary

| # | Week | Project | Stack | Outcome |
|---|------|---------|-------|---------|
| 1 | 2 | Linear Regression from scratch | Python, NumPy | Understand gradient descent |
| 2 | 3 | MNIST classifier (no frameworks) | Python, NumPy | Understand neural networks |
| 3 | 4 | Build a DI Container from scratch | C# | Understand how DI actually works |
| 4 | 5 | Custom Middleware Library (rate limiter + logging) | C#, ASP.NET Core | Own the pipeline |
| 5 | 7 | Multi-tenant query system with EF Core | C#, EF Core | Master EF internals |
| 6 | 7 | BPE Tokenizer | Python | Understand LLM input |
| 7 | 9 | Outbox Pattern + Saga implementation | C#, EF Core, Background Services | Distributed patterns |
| 8 | 9 | Full RAG pipeline with eval | Python, ChromaDB, OpenAI | End-to-end RAG |
| 9 | 10 | Cosmos DB Change Feed processor | C#, Azure Cosmos DB | Real-time event processing |
| 10 | 10 | Fine-tune a small model | Python, HuggingFace, QLoRA | Understand training |
| 11 | 12 | High-perf API (zero-alloc, benchmarked) | C#, BenchmarkDotNet | Performance mastery |
| 12 | 12 | Agent with tools + memory | Python, LangGraph | Applied agents |
| 13 | 13 | Healthcare AI Agent (Capstone) | C# + Python, RAG + .NET API | Both pillars combined |

---

## Resources Master List

### .NET
- 📹 Nick Chapsas YouTube (internals, performance)
- 📹 Raw Coding YouTube (ASP.NET deep dives)
- 📖 "Concurrency in C# Cookbook" — Stephen Cleary
- 📖 "Pro .NET Memory Management" — Konrad Kokosa
- 📖 Andrew Lock's blog (andrewlock.net)
- 🔧 Sharplab.io (see compiled output)
- 🔧 BenchmarkDotNet

### AI/ML
- 📹 Andrej Karpathy "Neural Networks: Zero to Hero" (FREE, YouTube)
- 📹 3Blue1Brown "Neural Networks" series (FREE)
- 📖 Jay Alammar's blog (illustrated guides)
- 📖 Sebastian Raschka "Build an LLM from Scratch" (book)
- 📹 Andrew Ng's DeepLearning.ai courses (agents, RAG)
- 📹 Hugging Face NLP course (FREE)
- 🔧 PyTorch, Hugging Face Transformers, LangChain/LangGraph

### System Design (overlap)
- AlgoMaster course (already planned)
- ByteByteGo YouTube
- "Designing Data-Intensive Applications" (Kleppmann)

---

## Integration with Existing Plans

```
Timeline:
Aug 11 ──────── Sep 3 ──────── Nov 7 ──────── Feb 2027
  │                │               │               │
  ├─ DSA ──────────┘               │               │
  ├─ System Design ─────────────────┘               │
  └─ Stack Mastery ─────────────────────────────────┘
     (.NET + AI + Frontend)

Daily Schedule (Aug 15 – Sep 3, peak overlap):
  Morning:    DSA (2 hrs)
  Afternoon:  System Design (1 hr)
  Evening:    Stack Mastery (1.5 hrs — .NET/AI alternating)
  Saturday:   Frontend (1.5-2 hrs)

Daily Schedule (Sep 4 – Nov 7, post-DSA):
  Morning:    Stack Mastery (1.5 hrs)
  Afternoon:  System Design (1.5 hrs)
  Evening:    Free / revision / projects
  Saturday:   Frontend (1.5-2 hrs)

Daily Schedule (Nov 8+, post-SD):
  Morning:    Stack Mastery Phase 2 (2 hrs)
  Evening:    Revision + mock interviews (1 hr)
  Saturday:   Frontend continued / Framework deep dive
```

---

## Frontend Track (Saturdays, 1.5–2 hrs)

### Weeks 1-4: JavaScript Fundamentals

| Week | Topics | Hands-on |
|------|--------|----------|
| 1 | Event loop: call stack, task queue, microtask queue, requestAnimationFrame | Code: predict output of nested setTimeout/Promise/queueMicrotask puzzles |
| 2 | Closures, lexical scope, IIFE, module pattern. `this` binding (4 rules) | Code: implement debounce, throttle, memoize from scratch |
| 3 | Prototypal inheritance, `Object.create`, ES6 class under the hood | Code: implement `new`, `instanceof`, basic class system without `class` keyword |
| 4 | Promises deep: implement Promise from scratch, async/await compilation, error handling patterns | 🔨 Code: build a Promise implementation that passes A+ spec tests |

### Weeks 5-7: TypeScript Advanced

| Week | Topics | Hands-on |
|------|--------|----------|
| 5 | Generics: constraints, inference, conditional types, `infer` keyword | Code: implement `DeepPartial<T>`, `Paths<T>`, type-safe event emitter |
| 6 | Mapped types, template literal types, discriminated unions, exhaustive checks | Code: build a type-safe router, form validator with inferred types |
| 7 | Declaration merging, module augmentation, `satisfies`, `const` assertions, variance | Code: type a complex API response (like your ProviderSearch payloads) |

### Weeks 8-10: DOM & Browser Internals

| Week | Topics | Hands-on |
|------|--------|----------|
| 8 | Rendering pipeline: DOM → CSSOM → Layout → Paint → Composite. Reflows vs repaints | Code: build infinite scroll with IntersectionObserver (zero frameworks) |
| 9 | Event system: capturing, bubbling, delegation, passive listeners, custom events | Code: build a dropdown/modal system with event delegation only |
| 10 | Web APIs: Fetch/AbortController, Web Workers, SharedArrayBuffer, Broadcast Channel | Code: offload heavy computation to Web Worker, cancel in-flight requests |

### Weeks 11-12: Frontend System Design

| Week | Topics | Hands-on |
|------|--------|----------|
| 11 | Component architecture patterns, state management (flux, signals, atoms), micro-frontends | Design: draw your Osprey app's state architecture, identify improvements |
| 12 | Performance: Core Web Vitals, lazy loading, code splitting, tree shaking, caching strategies (SW) | Audit: run Lighthouse on your portfolio site, fix all issues |

### Week 13: Framework Refresh Sprint

| Day | Action |
|-----|--------|
| Pick Angular OR Vue based on target companies | Speed-run: internals, change detection/reactivity, DI, routing, testing |

### Frontend Resources
- 📹 "JavaScript: The Hard Parts" — Will Sentance (Frontend Masters)
- 📹 Akshay Saini "Namaste JavaScript" (FREE, YouTube — excellent for event loop/closures)
- 📖 javascript.info (deep, free, covers everything)
- 📖 Matt Pocock's TypeScript tutorials (Total TypeScript)
- 📹 "Web Performance Fundamentals" (Frontend Masters)
- 🔧 TypeScript Playground, Chrome DevTools Performance tab

---

## Tracking

Progress tracked in the same UI at http://localhost:3150 (Stack Mastery tab).
Each day's topic can be marked done. Projects have their own checkpoints.

---

## Notes

- If a System Design topic overlaps with Stack Mastery that week, merge them (count once)
- Weekend projects can spill into 2 days — quality over speed
- Every 4 weeks: 30-min mock interview session (explain a topic cold)
- Keep a "concepts I struggled with" list — revisit in Phase 2
- After DSA finishes (Sep 3), you get back ~2 hrs/day — use for deeper project work
