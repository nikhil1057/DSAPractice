# DSA Practice

Daily DSA practice in Python and C# with tests.

## Structure

```
├── dsa-python/
│   ├── solutions/         ← Python solutions (with detailed comments)
│   └── tests/             ← pytest test cases
├── dsa-csharp/
│   └── solutions/         ← C# solutions (with detailed comments)
└── dsa-csharp-tests/      ← xUnit test cases
```

## Running Tests

**Python:**
```bash
cd dsa-python
python3 -m pytest tests/ -v            # Run all tests
python3 -m pytest tests/test_<name>.py  # Run specific test
```

**C#:**
```bash
cd dsa-csharp-tests
dotnet test                              # Run all tests
dotnet test --filter "ClassName"         # Run specific test class
```

## Problems Solved

| # | Problem | Topics |
|---|---------|--------|
| 2 | Add Two Numbers | Linked List, Math |
| 83 | Remove Duplicates from Sorted List | Linked List |
| 82 | Remove Duplicates from Sorted List II | Linked List, Two Pointers |
| 160 | Intersection of Two Linked Lists | Linked List, Two Pointers |
| 169 | Majority Element | Array, Boyer-Moore Voting |
| 525 | Contiguous Array | Array, HashMap, Prefix Sum |
| 707 | Design Linked List | Linked List |
