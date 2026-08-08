# DSA & System Design Practice

Daily DSA practice in Python and C# with tests. Following **NeetCode 150** roadmap.

## Structure

```
├── dsa-python/
│   ├── solutions/                 ← Python solutions by category
│   └── tests/                     ← pytest test cases
├── dsa-csharp/
│   └── solutions/                 ← C# solutions by category
├── dsa-csharp-tests/              ← xUnit test cases
└── tracker/                       ← Progress tracker UI (localhost:3150)
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

## Tracker UI

```bash
cd tracker && node server.js
# Open http://localhost:3150
```

## Problems Solved

### Array & Hashing

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 1 | Two Sum | Easy | HashMap, Complement Lookup |
| 49 | Group Anagrams | Medium | HashMap, Frequency Tuple / Sorting |
| 121 | Best Time to Buy and Sell Stock | Easy | Greedy, Track Min Price |
| 128 | Longest Consecutive Sequence | Medium | HashSet, Expand Sequence |
| 169 | Majority Element | Easy | Boyer-Moore Voting |
| 217 | Contains Duplicate | Easy | HashSet, Early Exit |
| 229 | Majority Element II | Medium | Extended Boyer-Moore (Two Candidates) |
| 238 | Product of Array Except Self | Medium | Prefix/Suffix Products |
| 242 | Valid Anagram | Easy | HashMap, Frequency Count |
| 271 | Encode and Decode Strings | Medium | Length-Prefix Encoding |
| 347 | Top K Frequent Elements | Medium | Bucket Sort by Frequency |
| 36 | Valid Sudoku | Medium | HashSet per Row/Col/Box |
| 525 | Contiguous Array | Medium | HashMap, Prefix Sum |

### Two Pointers

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 11 | Container With Most Water | Medium | Two Pointers, Shrink Shorter |
| 15 | 3Sum | Medium | Sort + Two Pointers |
| 42 | Trapping Rain Water | Hard | Two Pointers / DP |
| 125 | Valid Palindrome | Easy | Two Pointers, isalnum |
| 167 | Two Sum II | Medium | Two Pointers (sorted) |

### Sliding Window

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 3 | Longest Substring Without Repeating Characters | Medium | Variable Window + HashSet |
| 76 | Minimum Window Substring | Hard | Variable Window + Have/Need |
| 239 | Sliding Window Maximum | Hard | Monotonic Decreasing Deque |
| 424 | Longest Repeating Character Replacement | Medium | Fixed Window + Max Freq |
| 567 | Permutation In String | Medium | Fixed Window + Matches Counter |

### Stack

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 20 | Valid Parentheses | Easy | Stack Matching |
| 84 | Largest Rectangle In Histogram | Hard | Monotonic Stack, PSE/NSE |
| 150 | Evaluate Reverse Polish Notation | Medium | Stack + Operators |
| 155 | Min Stack | Medium | Two Stacks |
| 739 | Daily Temperatures | Medium | Monotonic Decreasing Stack |
| 853 | Car Fleet | Medium | Sort + Stack/Counter |
| 1047 | Remove All Adjacent Duplicates In String | Easy | Stack |

### Binary Search

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 4 | Median of Two Sorted Arrays | Hard | Partition Binary Search |
| 33 | Search In Rotated Sorted Array | Medium | Identify Sorted Half |
| 74 | Search a 2D Matrix | Medium | Flattened Binary Search |
| 153 | Find Minimum In Rotated Sorted Array | Medium | Compare Mid vs Right |
| 704 | Binary Search | Easy | Classic |
| 875 | Koko Eating Bananas | Medium | Binary Search on Answer Space |
| 981 | Time Based Key Value Store | Medium | Rightmost Binary Search |

### Linked List

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 2 | Add Two Numbers | Medium | Math, Carry |
| 19 | Remove Nth Node From End | Medium | Two Pointer Gap |
| 21 | Merge Two Sorted Lists | Medium | Two Pointers, Dummy Node |
| 23 | Merge k Sorted Lists | Hard | Divide and Conquer |
| 82 | Remove Duplicates from Sorted List II | Easy | Two Pointers |
| 83 | Remove Duplicates from Sorted List | Easy | Traversal |
| 138 | Copy List With Random Pointer | Medium | HashMap Two-Pass |
| 141 | Linked List Cycle | Easy | Floyd's Cycle Detection |
| 143 | Reorder List | Medium | Find Mid + Reverse + Merge |
| 160 | Intersection of Two Linked Lists | Easy | Two Pointers |
| 203 | Remove Linked List Elements | Easy | Dummy Node |
| 206 | Reverse Linked List | Easy | Iterative Pointer Reversal |
| 234 | Palindrome Linked List | Easy | Fast/Slow + Reverse |
| 707 | Design Linked List | Medium | Design |
| 876 | Middle of the Linked List | Easy | Floyd's (Fast/Slow) |
| 1290 | Convert Binary Number in Linked List | Easy | Bitwise |

### Trees

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 100 | Same Tree | Easy | Recursion, Compare Both |
| 102 | Binary Tree Level Order Traversal | Medium | BFS, Queue |
| 104 | Maximum Depth of Binary Tree | Easy | Postorder Recursion |
| 105 | Construct Tree from Preorder/Inorder | Medium | HashMap + Recursion |
| 110 | Balanced Binary Tree | Easy | Postorder, Height Check |
| 124 | Binary Tree Maximum Path Sum | Hard | Postorder, Track Global Max |
| 199 | Binary Tree Right Side View | Medium | BFS, Last Node Per Level |
| 226 | Invert Binary Tree | Easy | Preorder, Swap Children |
| 230 | Kth Smallest Element In BST | Medium | Inorder Traversal |
| 235 | Lowest Common Ancestor of BST | Medium | BST Property, Traverse |
| 297 | Serialize and Deserialize Binary Tree | Hard | BFS/Preorder + Queue |
| 543 | Diameter of Binary Tree | Easy | Postorder, Track Max(left+right) |
| 572 | Subtree of Another Tree | Easy | DFS + Same Tree Check |
| 98 | Validate Binary Search Tree | Medium | DFS, Min/Max Bounds |
| 1448 | Count Good Nodes | Medium | DFS, Track Max on Path |

### Tries

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 208 | Implement Trie (Prefix Tree) | Medium | Dict-based nodes, is_end flag |
| 211 | Design Add and Search Words | Medium | Trie + DFS for '.' wildcard |
| 212 | Word Search II | Hard | Trie + Backtracking, Pruning |

### Design

| # | Problem | Difficulty | Techniques |
|---|---------|-----------|-----------|
| 705 | Design HashSet | Easy | Array/Hashing |
| 706 | Design HashMap | Easy | Array/Hashing |

## Progress

**NeetCode 150:** 51 / 150 solved
