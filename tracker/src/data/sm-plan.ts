export interface SMItem {
  name: string
  track: 'dotnet' | 'ai' | 'fe'
}

export interface SMDay {
  day: number
  date: string
  items: SMItem[]
}

export interface SMWeek {
  week: number
  title: string
  track: string
  days: SMDay[]
}

export interface SMProject {
  name: string
  week: number
  track: 'dotnet' | 'ai' | 'fe' | 'both'
  status: string
}

export const SM_PLAN: SMWeek[] = [
  { week: 1, title: ".NET: async/await Internals · AI: ML Math", track: "dotnet+ai", days: [
    { day: 1, date: "Aug 11", items: [{ name: "async/await state machine (Sharplab)", track: "dotnet" },{ name: "Vectors, dot product, cosine similarity", track: "ai" }]},
    { day: 2, date: "Aug 12", items: [{ name: "Task vs ValueTask benchmark", track: "dotnet" },{ name: "Matrix multiplication (NumPy)", track: "ai" }]},
    { day: 3, date: "Aug 13", items: [{ name: "SynchronizationContext, ConfigureAwait", track: "dotnet" },{ name: "Derivatives, chain rule refresher", track: "ai" }]},
    { day: 4, date: "Aug 14", items: [{ name: "TaskCompletionSource, custom awaitables", track: "dotnet" },{ name: "Partial derivatives, gradients", track: "ai" }]},
    { day: 5, date: "Aug 15", items: [{ name: "ExecutionContext, AsyncLocal<T>", track: "dotnet" },{ name: "Loss functions: MSE, Cross-entropy", track: "ai" }]},
    { day: 6, date: "Aug 16", items: [{ name: "Review + 1-page async summary", track: "dotnet" },{ name: "JS: Event loop, call stack, microtasks", track: "fe" }]}
  ]},
  { week: 2, title: ".NET: Threading · AI: Gradient Descent", track: "dotnet+ai", days: [
    { day: 7, date: "Aug 18", items: [{ name: "ThreadPool internals, work stealing", track: "dotnet" },{ name: "Gradient descent explanation (Karpathy micrograd)", track: "ai" }]},
    { day: 8, date: "Aug 19", items: [{ name: "CancellationToken patterns", track: "dotnet" },{ name: "Implement GD for linear regression", track: "ai" }]},
    { day: 9, date: "Aug 20", items: [{ name: "Channels: producer-consumer", track: "dotnet" },{ name: "Learning rate experiments, convergence", track: "ai" }]},
    { day: 10, date: "Aug 21", items: [{ name: "SemaphoreSlim, rate limiting", track: "dotnet" },{ name: "SGD vs Mini-batch GD", track: "ai" }]},
    { day: 11, date: "Aug 22", items: [{ name: "IAsyncEnumerable, streaming", track: "dotnet" },{ name: "\u{1F528} PROJECT: Linear Regression from scratch", track: "ai" }]},
    { day: 12, date: "Aug 23", items: [{ name: "Review: async + threading model", track: "dotnet" },{ name: "JS: Closures, this binding, debounce/throttle", track: "fe" }]}
  ]},
  { week: 3, title: ".NET: GC & Memory · AI: Neural Networks", track: "dotnet+ai", days: [
    { day: 13, date: "Aug 25", items: [{ name: "GC generations, LOH, pinning", track: "dotnet" },{ name: "Perceptron from scratch", track: "ai" }]},
    { day: 14, date: "Aug 26", items: [{ name: "GC modes, dotnet-counters profiling", track: "dotnet" },{ name: "Multi-layer perceptron, forward pass", track: "ai" }]},
    { day: 15, date: "Aug 27", items: [{ name: "Span<T>, Memory<T>, stackalloc", track: "dotnet" },{ name: "Backpropagation: chain rule applied", track: "ai" }]},
    { day: 16, date: "Aug 28", items: [{ name: "ArrayPool<T>, MemoryPool<T>", track: "dotnet" },{ name: "Implement backprop in code", track: "ai" }]},
    { day: 17, date: "Aug 29", items: [{ name: "ref struct, unsafe, high-perf parsing", track: "dotnet" },{ name: "Activation functions: ReLU, Sigmoid, Softmax", track: "ai" }]},
    { day: 18, date: "Aug 30", items: [{ name: "Benchmark: memory optimization before/after", track: "dotnet" },{ name: "\u{1F528} PROJECT: MNIST classifier (pure numpy)", track: "ai" },{ name: "JS: Prototypes, Object.create, implement new", track: "fe" }]}
  ]},
  { week: 4, title: ".NET: DI Container · AI: Optimizers & PyTorch", track: "dotnet+ai", days: [
    { day: 19, date: "Sep 1", items: [{ name: "Build minimal DI container from scratch", track: "dotnet" },{ name: "Optimizers: SGD, Momentum, Adam", track: "ai" }]},
    { day: 20, date: "Sep 2", items: [{ name: "Lifetimes: captive dependency bug demo", track: "dotnet" },{ name: "Implement Adam optimizer", track: "ai" }]},
    { day: 21, date: "Sep 3", items: [{ name: "DI container with scopes", track: "dotnet" },{ name: "Regularization: L1, L2, Dropout", track: "ai" }]},
    { day: 22, date: "Sep 4", items: [{ name: "Keyed services, IServiceScopeFactory", track: "dotnet" },{ name: "Batch Normalization", track: "ai" }]},
    { day: 23, date: "Sep 5", items: [{ name: "Options pattern: IOptions vs Snapshot vs Monitor", track: "dotnet" },{ name: "PyTorch: tensors, autograd, nn.Module", track: "ai" }]},
    { day: 24, date: "Sep 6", items: [{ name: "Review: DI lifecycle diagram", track: "dotnet" },{ name: "\u{1F528} Rebuild MNIST in PyTorch (compare)", track: "ai" },{ name: "JS: Promise from scratch (A+ spec)", track: "fe" }]}
  ]},
  { week: 5, title: ".NET: Middleware · AI: Embeddings & CNNs", track: "dotnet+ai", days: [
    { day: 25, date: "Sep 8", items: [{ name: "Middleware pipeline: Use/Map/Run internals", track: "dotnet" },{ name: "Word2Vec: Skip-gram, CBOW", track: "ai" }]},
    { day: 26, date: "Sep 9", items: [{ name: "Custom middleware: timing + correlation ID", track: "dotnet" },{ name: "Train Word2Vec, explore analogies", track: "ai" }]},
    { day: 27, date: "Sep 10", items: [{ name: "Middleware ordering bugs, exception handling", track: "dotnet" },{ name: "Sentence embeddings vs TF-IDF comparison", track: "ai" }]},
    { day: 28, date: "Sep 11", items: [{ name: "Custom route constraints", track: "dotnet" },{ name: "CNNs: convolution, pooling, feature maps", track: "ai" }]},
    { day: 29, date: "Sep 12", items: [{ name: "\u{1F528} PROJECT: Middleware library (rate limit + logging)", track: "dotnet" },{ name: "1D CNN for text classification", track: "ai" }]},
    { day: 30, date: "Sep 13", items: [{ name: "Review: full request lifecycle", track: "dotnet" },{ name: "TS: Generics, conditional types, infer", track: "fe" }]}
  ]},
  { week: 6, title: ".NET: EF Core Internals · AI: Transformers", track: "dotnet+ai", days: [
    { day: 31, date: "Sep 15", items: [{ name: "Change Tracker states, DbContext lifecycle", track: "dotnet" },{ name: "Attention mechanism (read paper)", track: "ai" }]},
    { day: 32, date: "Sep 16", items: [{ name: "Query pipeline: LINQ \u2192 Expression \u2192 SQL", track: "dotnet" },{ name: "Self-attention: Q, K, V from scratch", track: "ai" }]},
    { day: 33, date: "Sep 17", items: [{ name: "Loading strategies, N+1 detection", track: "dotnet" },{ name: "Multi-head attention", track: "ai" }]},
    { day: 34, date: "Sep 18", items: [{ name: "Compiled queries, interceptors", track: "dotnet" },{ name: "Positional encoding", track: "ai" }]},
    { day: 35, date: "Sep 19", items: [{ name: "Migrations internals, concurrency tokens", track: "dotnet" },{ name: "Full Transformer encoder block from scratch", track: "ai" }]},
    { day: 36, date: "Sep 20", items: [{ name: "Review: EF vs Dapper decision matrix", track: "dotnet" },{ name: "TS: Mapped types, template literals, discriminated unions", track: "fe" }]}
  ]},
  { week: 7, title: ".NET: EF Advanced · AI: GPT Architecture", track: "dotnet+ai", days: [
    { day: 37, date: "Sep 22", items: [{ name: "Raw SQL, value converters, owned types", track: "dotnet" },{ name: "GPT decoder-only, causal masking (Karpathy)", track: "ai" }]},
    { day: 38, date: "Sep 23", items: [{ name: "Performance: AsNoTracking, projection, batching", track: "dotnet" },{ name: "\u{1F528} PROJECT: BPE tokenizer from scratch", track: "ai" }]},
    { day: 39, date: "Sep 24", items: [{ name: "Multi-tenancy with EF query filters", track: "dotnet" },{ name: "KV Cache: naive vs cached generation", track: "ai" }]},
    { day: 40, date: "Sep 25", items: [{ name: "DDD value objects with EF", track: "dotnet" },{ name: "Sampling: temperature, top-k, top-p", track: "ai" }]},
    { day: 41, date: "Sep 26", items: [{ name: "Database-first vs Code-first", track: "dotnet" },{ name: "Scaling laws, context windows", track: "ai" }]},
    { day: 42, date: "Sep 27", items: [{ name: "Review: EF Core decision guide", track: "dotnet" },{ name: "TS: Module augmentation, satisfies, variance", track: "fe" }]}
  ]},
  { week: 8, title: ".NET: ASP.NET Internals · AI: RAG Fundamentals", track: "dotnet+ai", days: [
    { day: 43, date: "Sep 29", items: [{ name: "Kestrel server internals, HTTP/2", track: "dotnet" },{ name: "Prompt engineering patterns (10 patterns)", track: "ai" }]},
    { day: 44, date: "Sep 30", items: [{ name: "Model binding, custom binders", track: "dotnet" },{ name: "Few-shot, Chain-of-thought, ReAct", track: "ai" }]},
    { day: 45, date: "Oct 1", items: [{ name: "Filters: Action, Exception, Resource", track: "dotnet" },{ name: "RAG architecture overview", track: "ai" }]},
    { day: 46, date: "Oct 2", items: [{ name: "Output caching, ETags", track: "dotnet" },{ name: "Chunking strategies (3 approaches)", track: "ai" }]},
    { day: 47, date: "Oct 3", items: [{ name: "Minimal APIs vs Controllers tradeoffs", track: "dotnet" },{ name: "Vector stores: FAISS, ChromaDB, pgvector", track: "ai" }]},
    { day: 48, date: "Oct 4", items: [{ name: "Review: ASP.NET request pipeline", track: "dotnet" },{ name: "DOM: Rendering pipeline, reflows, IntersectionObserver", track: "fe" }]}
  ]},
  { week: 9, title: ".NET: Distributed Patterns · AI: RAG Build", track: "dotnet+ai", days: [
    { day: 49, date: "Oct 6", items: [{ name: "Outbox pattern with EF + background service", track: "dotnet" },{ name: "Dense vs sparse vs hybrid retrieval", track: "ai" }]},
    { day: 50, date: "Oct 7", items: [{ name: "Saga pattern: orchestration vs choreography", track: "dotnet" },{ name: "Reranking with cross-encoders", track: "ai" }]},
    { day: 51, date: "Oct 8", items: [{ name: "Idempotency keys + Redis deduplication", track: "dotnet" },{ name: "RAG evaluation: RAGAS metrics", track: "ai" }]},
    { day: 52, date: "Oct 9", items: [{ name: "Eventual consistency, conflict resolution", track: "dotnet" },{ name: "Hallucination detection + citation", track: "ai" }]},
    { day: 53, date: "Oct 10", items: [{ name: "Circuit breaker: Polly v8, bulkhead, timeout", track: "dotnet" },{ name: "\u{1F528} PROJECT: Full RAG pipeline with eval", track: "ai" }]},
    { day: 54, date: "Oct 11", items: [{ name: "Review: ProviderSearch + distributed patterns", track: "dotnet" },{ name: "DOM: Event delegation, custom events, passive", track: "fe" }]}
  ]},
  { week: 10, title: "Azure: Cosmos DB Deep · AI: Fine-tuning", track: "dotnet+ai", days: [
    { day: 55, date: "Oct 13", items: [{ name: "Cosmos: Partition key strategy, physical vs logical", track: "dotnet" },{ name: "Fine-tune vs prompt vs RAG decision framework", track: "ai" }]},
    { day: 56, date: "Oct 14", items: [{ name: "Cosmos: RU calculation, indexing cost", track: "dotnet" },{ name: "Data preparation for fine-tuning", track: "ai" }]},
    { day: 57, date: "Oct 15", items: [{ name: "Cosmos: Consistency levels deep", track: "dotnet" },{ name: "LoRA: low-rank adaptation (read paper)", track: "ai" }]},
    { day: 58, date: "Oct 16", items: [{ name: "Cosmos: Indexing policies, composite indexes", track: "dotnet" },{ name: "QLoRA setup with HuggingFace PEFT", track: "ai" }]},
    { day: 59, date: "Oct 17", items: [{ name: "Cosmos: Change Feed processor", track: "dotnet" },{ name: "\u{1F528} PROJECT: Fine-tune small model (Phi-3)", track: "ai" }]},
    { day: 60, date: "Oct 18", items: [{ name: "Review: Cosmos decision guide", track: "dotnet" },{ name: "Web Workers, AbortController, Broadcast Channel", track: "fe" }]}
  ]},
  { week: 11, title: "Azure: Functions/Bus/Grid · AI: Evaluation", track: "dotnet+ai", days: [
    { day: 61, date: "Oct 20", items: [{ name: "Functions: consumption vs premium, cold start", track: "dotnet" },{ name: "Eval metrics: BLEU, ROUGE, BERTScore", track: "ai" }]},
    { day: 62, date: "Oct 21", items: [{ name: "Durable Functions: fan-out/fan-in patterns", track: "dotnet" },{ name: "LLM-as-judge evaluation pipeline", track: "ai" }]},
    { day: 63, date: "Oct 22", items: [{ name: "Service Bus: topics, dead-letter, sessions", track: "dotnet" },{ name: "Human eval: annotation guidelines", track: "ai" }]},
    { day: 64, date: "Oct 23", items: [{ name: "Event Grid vs Service Bus vs Event Hub", track: "dotnet" },{ name: "Benchmarking fine-tuned model", track: "ai" }]},
    { day: 65, date: "Oct 24", items: [{ name: "APIM policies: caching, rate-limit, transform", track: "dotnet" },{ name: "A/B testing LLMs in production", track: "ai" }]},
    { day: 66, date: "Oct 25", items: [{ name: "Review: Azure service selection", track: "dotnet" },{ name: "FE System Design: Component arch, state at scale", track: "fe" }]}
  ]},
  { week: 12, title: ".NET: Performance · AI: Agents", track: "dotnet+ai", days: [
    { day: 67, date: "Oct 27", items: [{ name: "BenchmarkDotNet setup + profiling", track: "dotnet" },{ name: "Agent architectures: ReAct, Plan-and-Execute", track: "ai" }]},
    { day: 68, date: "Oct 28", items: [{ name: "dotnet-trace, dotnet-dump in production", track: "dotnet" },{ name: "Tool use: function calling, structured output", track: "ai" }]},
    { day: 69, date: "Oct 29", items: [{ name: "Object pooling, string interning, StringBuilder", track: "dotnet" },{ name: "Memory in agents: short/long-term, episodic", track: "ai" }]},
    { day: 70, date: "Oct 30", items: [{ name: "Source generators for DTOs", track: "dotnet" },{ name: "Multi-agent patterns: debate, delegation", track: "ai" }]},
    { day: 71, date: "Oct 31", items: [{ name: "Zero-alloc patterns: ref struct, stackalloc", track: "dotnet" },{ name: "\u{1F528} PROJECT: Agent with tools + memory", track: "ai" }]},
    { day: 72, date: "Nov 1", items: [{ name: "Review: performance checklist", track: "dotnet" },{ name: "FE: Performance audit, Core Web Vitals, Lighthouse", track: "fe" }]}
  ]},
  { week: 13, title: "Review + Mock Interviews + Capstone", track: "all", days: [
    { day: 73, date: "Nov 3", items: [{ name: "Mock: explain async/await internals (5 min)", track: "dotnet" },{ name: "Mock: explain transformer architecture", track: "ai" }]},
    { day: 74, date: "Nov 4", items: [{ name: "Mock: whiteboard ProviderSearch architecture", track: "dotnet" },{ name: "Mock: RAG vs fine-tuning decision", track: "ai" }]},
    { day: 75, date: "Nov 5", items: [{ name: "Mock: optimize slow EF query live", track: "dotnet" },{ name: "Mock: design AI document classification system", track: "ai" }]},
    { day: 76, date: "Nov 6", items: [{ name: "Mock: design resilient microservice", track: "dotnet" },{ name: "Mock: evaluate and improve RAG pipeline", track: "ai" }]},
    { day: 77, date: "Nov 7", items: [{ name: "Mock: Cosmos partition strategy for 10M docs", track: "dotnet" },{ name: "\u{1F528} CAPSTONE: Healthcare AI Agent (.NET + RAG)", track: "ai" }]},
    { day: 78, date: "Nov 8", items: [{ name: "Phase 1 retrospective", track: "dotnet" },{ name: "Gap identification + Phase 2 planning", track: "ai" },{ name: "Framework refresh sprint (Angular or Vue)", track: "fe" }]}
  ]}
]

export const SM_PROJECTS: SMProject[] = [
  { name: "Linear Regression from scratch", week: 2, track: "ai", status: "pending" },
  { name: "MNIST classifier (pure numpy)", week: 3, track: "ai", status: "pending" },
  { name: "Build a DI Container from scratch", week: 4, track: "dotnet", status: "pending" },
  { name: "Custom Middleware Library (rate limiter + logging)", week: 5, track: "dotnet", status: "pending" },
  { name: "EF Core: Multi-tenant query system", week: 7, track: "dotnet", status: "pending" },
  { name: "BPE Tokenizer from scratch", week: 7, track: "ai", status: "pending" },
  { name: "Outbox Pattern + Saga implementation", week: 9, track: "dotnet", status: "pending" },
  { name: "Full RAG pipeline with eval", week: 9, track: "ai", status: "pending" },
  { name: "Cosmos DB Change Feed processor", week: 10, track: "dotnet", status: "pending" },
  { name: "Fine-tune small model (Phi-3/Llama)", week: 10, track: "ai", status: "pending" },
  { name: "High-perf API with BenchmarkDotNet (zero-alloc)", week: 12, track: "dotnet", status: "pending" },
  { name: "Agent with tools + memory", week: 12, track: "ai", status: "pending" },
  { name: "Healthcare AI Agent \u2014 Capstone (.NET + RAG)", week: 13, track: "both", status: "pending" }
]
