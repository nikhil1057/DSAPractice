# DSA Practice

Daily DSA practice in Python and C# with tests. Following **NeetCode 150** roadmap.

## Structure

```
├── dsa-python/
│   ├── solutions/
│   │   ├── array_and_hashing/     ├── two_pointers/
│   │   ├── sliding_window/        ├── stack/
│   │   ├── binary_search/         ├── linked_list/
│   │   ├── trees/                 ├── tries/
│   │   ├── heap/                  ├── backtracking/
│   │   ├── graphs/                ├── advanced_graphs/
│   │   ├── dp_1d/                 ├── dp_2d/
│   │   ├── greedy/                ├── intervals/
│   │   ├── math_and_geometry/     ├── bit_manipulation/
│   │   └── design/
│   └── tests/                     ← pytest test cases
├── dsa-csharp/
│   └── solutions/
│       ├── ArrayAndHashing/       ├── TwoPointers/
│       ├── SlidingWindow/         ├── Stack/
│       ├── BinarySearch/          ├── LinkedList/
│       ├── Trees/                 ├── Tries/
│       ├── Heap/                  ├── Backtracking/
│       ├── Graphs/                ├── AdvancedGraphs/
│       ├── Dp1D/                  ├── Dp2D/
│       ├── Greedy/                ├── Intervals/
│       ├── MathAndGeometry/       ├── BitManipulation/
│       └── Design/
└── dsa-csharp-tests/              ← xUnit test cases
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

### Array & Hashing

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 1 | Two Sum | Easy | HashMap, Complement Lookup |
| 49 | Group Anagrams | Medium | HashMap, Frequency Tuple / Sorting |
| 121 | Best Time to Buy and Sell Stock | Easy | Greedy, Track Min Price |
| 169 | Majority Element | Easy | Boyer-Moore Voting |
| 217 | Contains Duplicate | Easy | HashSet, Early Exit |
| 229 | Majority Element II | Medium | Extended Boyer-Moore (Two Candidates) |
| 242 | Valid Anagram | Easy | HashMap, Frequency Count |
| 271 | Encode and Decode Strings | Medium | Length-Prefix Encoding |
| 347 | Top K Frequent Elements | Medium | Bucket Sort by Frequency |
| 525 | Contiguous Array | Medium | HashMap, Prefix Sum |

### Linked List

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 2 | Add Two Numbers | Medium | Math, Carry |
| 21 | Merge Two Sorted Lists | Medium | Two Pointers, Dummy Node |
| 23 | Merge k Sorted Lists | Hard | Divide and Conquer |
| 82 | Remove Duplicates from Sorted List II | Easy | Two Pointers |
| 83 | Remove Duplicates from Sorted List | Easy | Traversal |
| 141 | Linked List Cycle | Easy | Floyd's Cycle Detection |
| 160 | Intersection of Two Linked Lists | Easy | Two Pointers |
| 203 | Remove Linked List Elements | Easy | Dummy Node |
| 206 | Reverse Linked List | Easy | Iterative Pointer Reversal |
| 234 | Palindrome Linked List | Easy | Fast/Slow + Reverse |
| 707 | Design Linked List | Medium | Design |
| 876 | Middle of the Linked List | Easy | Floyd's (Fast/Slow) |
| 1290 | Convert Binary Number in Linked List | Easy | Bitwise |

### Stack

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 1047 | Remove All Adjacent Duplicates In String | Easy | Stack |

### Design

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 705 | Design HashSet | Easy | Array/Hashing |
| 706 | Design HashMap | Easy | Array/Hashing |

## Progress

**NeetCode 150:** 12 / 150 solved (not counting non-NeetCode problems)
