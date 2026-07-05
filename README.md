# DSA Practice

Daily DSA practice in Python and C# with tests.

## Structure

```
├── dsa-python/
│   ├── solutions/
│   │   ├── linked_list/
│   │   │   ├── easy/          ← Easy linked list problems
│   │   │   ├── medium/        ← Medium linked list problems
│   │   │   └── hard/          ← Hard linked list problems
│   │   ├── array_and_hashing/
│   │   │   ├── easy/
│   │   │   └── medium/
│   │   └── design/
│   │       └── easy/
│   └── tests/                 ← pytest test cases
├── dsa-csharp/
│   └── solutions/
│       ├── LinkedList/
│       │   ├── Easy/
│       │   ├── Medium/
│       │   └── Hard/
│       ├── ArrayAndHashing/
│       │   ├── Easy/
│       │   └── Medium/
│       └── Design/
│           └── Easy/
└── dsa-csharp-tests/          ← xUnit test cases
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

### Linked List

| # | Problem | Techniques |
|---|---------|-----------|
| 2 | Add Two Numbers | Math, Carry |
| 21 | Merge Two Sorted Lists | Two Pointers, Dummy Node |
| 23 | Merge k Sorted Lists | Divide and Conquer |
| 82 | Remove Duplicates from Sorted List II | Two Pointers |
| 83 | Remove Duplicates from Sorted List | Traversal |
| 141 | Linked List Cycle | Floyd's Cycle Detection |
| 160 | Intersection of Two Linked Lists | Two Pointers |
| 203 | Remove Linked List Elements | Dummy Node |
| 206 | Reverse Linked List | Iterative Pointer Reversal |
| 234 | Palindrome Linked List | Fast/Slow + Reverse |
| 707 | Design Linked List | Design |
| 876 | Middle of the Linked List | Floyd's (Fast/Slow) |
| 1290 | Convert Binary Number in Linked List | Bitwise |

### Array & Hashing

| # | Problem | Techniques |
|---|---------|-----------|
| 169 | Majority Element | Boyer-Moore Voting |
| 525 | Contiguous Array | HashMap, Prefix Sum |

### Design

| # | Problem | Techniques |
|---|---------|-----------|
| 705 | Design HashSet | Array/Hashing |
| 706 | Design HashMap | Array/Hashing |
