export interface Problem {
  name: string
  difficulty: 'easy' | 'medium' | 'hard'
  category: string
}

export interface Day {
  day: number
  date: string
  problems: Problem[]
}

export interface Week {
  week: number
  title: string
  days: Day[]
}

export const DSA_PLAN: Week[] = [
  { week: 1, title: "Arrays & Hashing · Two Pointers · Sliding Window", days: [
    { day: 1, date: "Jul 18", problems: [{ name: "Contains Duplicate", difficulty: "easy", category: "Arrays & Hashing" },{ name: "Valid Anagram", difficulty: "easy", category: "Arrays & Hashing" },{ name: "Two Sum", difficulty: "easy", category: "Arrays & Hashing" }]},
    { day: 2, date: "Jul 19", problems: [{ name: "Group Anagrams", difficulty: "medium", category: "Arrays & Hashing" },{ name: "Top K Frequent Elements", difficulty: "medium", category: "Arrays & Hashing" },{ name: "Encode and Decode Strings", difficulty: "medium", category: "Arrays & Hashing" }]},
    { day: 3, date: "Jul 20", problems: [{ name: "Product of Array Except Self", difficulty: "medium", category: "Arrays & Hashing" },{ name: "Valid Sudoku", difficulty: "medium", category: "Arrays & Hashing" },{ name: "Longest Consecutive Sequence", difficulty: "medium", category: "Arrays & Hashing" }]},
    { day: 4, date: "Jul 21", problems: [{ name: "Valid Palindrome", difficulty: "easy", category: "Two Pointers" },{ name: "Two Sum II", difficulty: "medium", category: "Two Pointers" },{ name: "3Sum", difficulty: "medium", category: "Two Pointers" }]},
    { day: 5, date: "Jul 22", problems: [{ name: "Container With Most Water", difficulty: "medium", category: "Two Pointers" },{ name: "Trapping Rain Water", difficulty: "hard", category: "Two Pointers" },{ name: "Longest Substring Without Repeating Characters", difficulty: "medium", category: "Sliding Window" }]},
    { day: 6, date: "Jul 23", problems: [{ name: "Longest Repeating Character Replacement", difficulty: "medium", category: "Sliding Window" },{ name: "Permutation In String", difficulty: "medium", category: "Sliding Window" },{ name: "Minimum Window Substring", difficulty: "hard", category: "Sliding Window" }]},
    { day: 7, date: "Jul 24", problems: [{ name: "Sliding Window Maximum", difficulty: "hard", category: "Sliding Window" },{ name: "Valid Parentheses", difficulty: "easy", category: "Stack" },{ name: "Min Stack", difficulty: "medium", category: "Stack" }]}
  ]},
  { week: 2, title: "Stack · Binary Search · Linked List", days: [
    { day: 8, date: "Jul 25", problems: [{ name: "Evaluate Reverse Polish Notation", difficulty: "medium", category: "Stack" },{ name: "Daily Temperatures", difficulty: "medium", category: "Stack" },{ name: "Car Fleet", difficulty: "medium", category: "Stack" }]},
    { day: 9, date: "Jul 26", problems: [{ name: "Largest Rectangle In Histogram", difficulty: "hard", category: "Stack" },{ name: "Binary Search", difficulty: "easy", category: "Binary Search" },{ name: "Search a 2D Matrix", difficulty: "medium", category: "Binary Search" }]},
    { day: 10, date: "Jul 27", problems: [{ name: "Koko Eating Bananas", difficulty: "medium", category: "Binary Search" },{ name: "Find Minimum In Rotated Sorted Array", difficulty: "medium", category: "Binary Search" },{ name: "Search In Rotated Sorted Array", difficulty: "medium", category: "Binary Search" }]},
    { day: 11, date: "Jul 28", problems: [{ name: "Time Based Key Value Store", difficulty: "medium", category: "Binary Search" },{ name: "Median of Two Sorted Arrays", difficulty: "hard", category: "Binary Search" },{ name: "Reorder List", difficulty: "medium", category: "Linked List" }]},
    { day: 12, date: "Jul 29", problems: [{ name: "Remove Nth Node From End of List", difficulty: "medium", category: "Linked List" },{ name: "Copy List With Random Pointer", difficulty: "medium", category: "Linked List" },{ name: "Find The Duplicate Number", difficulty: "medium", category: "Linked List" }]},
    { day: 13, date: "Jul 30", problems: [{ name: "LRU Cache", difficulty: "medium", category: "Linked List" },{ name: "Reverse Nodes In K Group", difficulty: "hard", category: "Linked List" },{ name: "Invert Binary Tree", difficulty: "easy", category: "Trees" }]},
    { day: 14, date: "Jul 31", problems: [{ name: "Maximum Depth of Binary Tree", difficulty: "easy", category: "Trees" },{ name: "Diameter of Binary Tree", difficulty: "easy", category: "Trees" },{ name: "Balanced Binary Tree", difficulty: "easy", category: "Trees" }]}
  ]},
  { week: 3, title: "Trees · Tries · Heap", days: [
    { day: 15, date: "Aug 1", problems: [{ name: "Same Tree", difficulty: "easy", category: "Trees" },{ name: "Subtree of Another Tree", difficulty: "easy", category: "Trees" },{ name: "Lowest Common Ancestor of a BST", difficulty: "medium", category: "Trees" }]},
    { day: 16, date: "Aug 2", problems: [{ name: "Binary Tree Level Order Traversal", difficulty: "medium", category: "Trees" },{ name: "Binary Tree Right Side View", difficulty: "medium", category: "Trees" },{ name: "Count Good Nodes In Binary Tree", difficulty: "medium", category: "Trees" }]},
    { day: 17, date: "Aug 3", problems: [{ name: "Validate Binary Search Tree", difficulty: "medium", category: "Trees" },{ name: "Kth Smallest Element In a BST", difficulty: "medium", category: "Trees" },{ name: "Construct Binary Tree From Preorder And Inorder", difficulty: "medium", category: "Trees" }]},
    { day: 18, date: "Aug 4", problems: [{ name: "Binary Tree Maximum Path Sum", difficulty: "hard", category: "Trees" },{ name: "Serialize And Deserialize Binary Tree", difficulty: "hard", category: "Trees" },{ name: "Implement Trie Prefix Tree", difficulty: "medium", category: "Tries" }]},
    { day: 19, date: "Aug 5", problems: [{ name: "Design Add And Search Words", difficulty: "medium", category: "Tries" },{ name: "Word Search II", difficulty: "hard", category: "Tries" },{ name: "Kth Largest Element In a Stream", difficulty: "easy", category: "Heap" }]},
    { day: 20, date: "Aug 6", problems: [{ name: "Last Stone Weight", difficulty: "easy", category: "Heap" },{ name: "K Closest Points to Origin", difficulty: "medium", category: "Heap" },{ name: "Kth Largest Element In An Array", difficulty: "medium", category: "Heap" }]},
    { day: 21, date: "Aug 7", problems: [{ name: "Task Scheduler", difficulty: "medium", category: "Heap" },{ name: "Design Twitter", difficulty: "medium", category: "Heap" },{ name: "Find Median From Data Stream", difficulty: "hard", category: "Heap" }]}
  ]},
  { week: 4, title: "Backtracking · Graphs", days: [
    { day: 22, date: "Aug 8", problems: [{ name: "Subsets", difficulty: "medium", category: "Backtracking" },{ name: "Combination Sum", difficulty: "medium", category: "Backtracking" },{ name: "Combination Sum II", difficulty: "medium", category: "Backtracking" }]},
    { day: 23, date: "Aug 9", problems: [{ name: "Permutations", difficulty: "medium", category: "Backtracking" },{ name: "Subsets II", difficulty: "medium", category: "Backtracking" },{ name: "Generate Parentheses", difficulty: "medium", category: "Backtracking" }]},
    { day: 24, date: "Aug 10", problems: [{ name: "Word Search", difficulty: "medium", category: "Backtracking" },{ name: "Palindrome Partitioning", difficulty: "medium", category: "Backtracking" },{ name: "Letter Combinations of a Phone Number", difficulty: "medium", category: "Backtracking" }]},
    { day: 25, date: "Aug 11", problems: [{ name: "N Queens", difficulty: "hard", category: "Backtracking" },{ name: "Number of Islands", difficulty: "medium", category: "Graphs" },{ name: "Max Area of Island", difficulty: "medium", category: "Graphs" }]},
    { day: 26, date: "Aug 12", problems: [{ name: "Clone Graph", difficulty: "medium", category: "Graphs" },{ name: "Walls And Gates", difficulty: "medium", category: "Graphs" },{ name: "Rotting Oranges", difficulty: "medium", category: "Graphs" }]},
    { day: 27, date: "Aug 13", problems: [{ name: "Pacific Atlantic Water Flow", difficulty: "medium", category: "Graphs" },{ name: "Surrounded Regions", difficulty: "medium", category: "Graphs" },{ name: "Course Schedule", difficulty: "medium", category: "Graphs" }]},
    { day: 28, date: "Aug 14", problems: [{ name: "Course Schedule II", difficulty: "medium", category: "Graphs" },{ name: "Graph Valid Tree", difficulty: "medium", category: "Graphs" },{ name: "Number of Connected Components", difficulty: "medium", category: "Graphs" }]}
  ]},
  { week: 5, title: "Graphs · Advanced Graphs · 1-D DP", days: [
    { day: 29, date: "Aug 15", problems: [{ name: "Redundant Connection", difficulty: "medium", category: "Graphs" },{ name: "Word Ladder", difficulty: "hard", category: "Graphs" },{ name: "Network Delay Time", difficulty: "medium", category: "Adv. Graphs" }]},
    { day: 30, date: "Aug 16", problems: [{ name: "Reconstruct Itinerary", difficulty: "hard", category: "Adv. Graphs" },{ name: "Min Cost to Connect All Points", difficulty: "medium", category: "Adv. Graphs" },{ name: "Swim In Rising Water", difficulty: "hard", category: "Adv. Graphs" }]},
    { day: 31, date: "Aug 17", problems: [{ name: "Alien Dictionary", difficulty: "hard", category: "Adv. Graphs" },{ name: "Cheapest Flights Within K Stops", difficulty: "medium", category: "Adv. Graphs" },{ name: "Climbing Stairs", difficulty: "easy", category: "1-D DP" }]},
    { day: 32, date: "Aug 18", problems: [{ name: "Min Cost Climbing Stairs", difficulty: "easy", category: "1-D DP" },{ name: "House Robber", difficulty: "medium", category: "1-D DP" },{ name: "House Robber II", difficulty: "medium", category: "1-D DP" }]},
    { day: 33, date: "Aug 19", problems: [{ name: "Longest Palindromic Substring", difficulty: "medium", category: "1-D DP" },{ name: "Palindromic Substrings", difficulty: "medium", category: "1-D DP" },{ name: "Decode Ways", difficulty: "medium", category: "1-D DP" }]},
    { day: 34, date: "Aug 20", problems: [{ name: "Coin Change", difficulty: "medium", category: "1-D DP" },{ name: "Maximum Product Subarray", difficulty: "medium", category: "1-D DP" },{ name: "Word Break", difficulty: "medium", category: "1-D DP" }]},
    { day: 35, date: "Aug 21", problems: [{ name: "Longest Increasing Subsequence", difficulty: "medium", category: "1-D DP" },{ name: "Partition Equal Subset Sum", difficulty: "medium", category: "1-D DP" },{ name: "Unique Paths", difficulty: "medium", category: "2-D DP" }]}
  ]},
  { week: 6, title: "2-D DP · Greedy", days: [
    { day: 36, date: "Aug 22", problems: [{ name: "Longest Common Subsequence", difficulty: "medium", category: "2-D DP" },{ name: "Buy/Sell Stock With Cooldown", difficulty: "medium", category: "2-D DP" },{ name: "Coin Change II", difficulty: "medium", category: "2-D DP" }]},
    { day: 37, date: "Aug 23", problems: [{ name: "Target Sum", difficulty: "medium", category: "2-D DP" },{ name: "Interleaving String", difficulty: "medium", category: "2-D DP" },{ name: "Longest Increasing Path In a Matrix", difficulty: "hard", category: "2-D DP" }]},
    { day: 38, date: "Aug 24", problems: [{ name: "Distinct Subsequences", difficulty: "hard", category: "2-D DP" },{ name: "Edit Distance", difficulty: "hard", category: "2-D DP" },{ name: "Burst Balloons", difficulty: "hard", category: "2-D DP" }]},
    { day: 39, date: "Aug 25", problems: [{ name: "Regular Expression Matching", difficulty: "hard", category: "2-D DP" },{ name: "Maximum Subarray", difficulty: "medium", category: "Greedy" },{ name: "Jump Game", difficulty: "medium", category: "Greedy" }]},
    { day: 40, date: "Aug 26", problems: [{ name: "Jump Game II", difficulty: "medium", category: "Greedy" },{ name: "Gas Station", difficulty: "medium", category: "Greedy" },{ name: "Hand of Straights", difficulty: "medium", category: "Greedy" }]},
    { day: 41, date: "Aug 27", problems: [{ name: "Merge Triplets to Form Target Triplet", difficulty: "medium", category: "Greedy" },{ name: "Partition Labels", difficulty: "medium", category: "Greedy" },{ name: "Valid Parenthesis String", difficulty: "medium", category: "Greedy" }]}
  ]},
  { week: 7, title: "Intervals · Math · Bit Manipulation", days: [
    { day: 42, date: "Aug 28", problems: [{ name: "Insert Interval", difficulty: "medium", category: "Intervals" },{ name: "Merge Intervals", difficulty: "medium", category: "Intervals" },{ name: "Non Overlapping Intervals", difficulty: "medium", category: "Intervals" }]},
    { day: 43, date: "Aug 29", problems: [{ name: "Meeting Rooms", difficulty: "easy", category: "Intervals" },{ name: "Meeting Rooms II", difficulty: "medium", category: "Intervals" },{ name: "Minimum Interval to Include Each Query", difficulty: "hard", category: "Intervals" }]},
    { day: 44, date: "Aug 30", problems: [{ name: "Rotate Image", difficulty: "medium", category: "Math" },{ name: "Spiral Matrix", difficulty: "medium", category: "Math" },{ name: "Set Matrix Zeroes", difficulty: "medium", category: "Math" }]},
    { day: 45, date: "Aug 31", problems: [{ name: "Happy Number", difficulty: "easy", category: "Math" },{ name: "Plus One", difficulty: "easy", category: "Math" },{ name: "Pow(x, n)", difficulty: "medium", category: "Math" }]},
    { day: 46, date: "Sep 1", problems: [{ name: "Multiply Strings", difficulty: "medium", category: "Math" },{ name: "Detect Squares", difficulty: "medium", category: "Math" },{ name: "Single Number", difficulty: "easy", category: "Bits" }]},
    { day: 47, date: "Sep 2", problems: [{ name: "Number of 1 Bits", difficulty: "easy", category: "Bits" },{ name: "Counting Bits", difficulty: "easy", category: "Bits" },{ name: "Reverse Bits", difficulty: "easy", category: "Bits" }]},
    { day: 48, date: "Sep 3", problems: [{ name: "Missing Number", difficulty: "easy", category: "Bits" },{ name: "Sum of Two Integers", difficulty: "medium", category: "Bits" },{ name: "Reverse Integer", difficulty: "medium", category: "Bits" }]}
  ]}
]

export const DSA_TOTAL = 144

export const EXTRA_PROBLEMS: Array<{ name: string; difficulty: string; category: string; solvedDate: string }> = [
  { name: "Merge Two Sorted Lists", difficulty: "medium", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Linked List Cycle", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Reverse Linked List", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Palindrome Linked List", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Middle of the Linked List", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Remove Linked List Elements", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Intersection of Two Linked Lists", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Remove Duplicates from Sorted List", difficulty: "easy", category: "Linked List", solvedDate: "Jun 27 2026" },
  { name: "Design Linked List", difficulty: "medium", category: "Linked List", solvedDate: "Jun 27 2026" },
  { name: "Convert Binary Number in Linked List", difficulty: "easy", category: "Linked List", solvedDate: "Jun 28 2026" },
  { name: "Add Two Numbers", difficulty: "medium", category: "Linked List", solvedDate: "Jul 2 2026" },
  { name: "Merge K Sorted Lists", difficulty: "hard", category: "Linked List", solvedDate: "Jul 5 2026" },
  { name: "Design HashSet", difficulty: "easy", category: "Design", solvedDate: "Jun 28 2026" },
  { name: "Design HashMap", difficulty: "easy", category: "Design", solvedDate: "Jun 28 2026" },
  { name: "Majority Element", difficulty: "easy", category: "Arrays & Hashing", solvedDate: "Jul 2 2026" },
  { name: "Majority Element II", difficulty: "medium", category: "Arrays & Hashing", solvedDate: "Jul 16 2026" },
  { name: "Contiguous Array", difficulty: "medium", category: "Arrays & Hashing", solvedDate: "Jul 2 2026" },
  { name: "Best Time to Buy and Sell Stock", difficulty: "easy", category: "Arrays & Hashing", solvedDate: "Jul 16 2026" },
  { name: "Remove All Adjacent Duplicates In String", difficulty: "easy", category: "Stack", solvedDate: "Jul 8 2026" }
]

export const REVISION_CATEGORIES = [
  "Arrays & Hashing", "Two Pointers", "Sliding Window", "Stack", "Binary Search",
  "Linked List", "Trees", "Tries", "Heap", "Backtracking", "Graphs", "Adv. Graphs",
  "1-D DP", "2-D DP", "Greedy", "Intervals", "Math", "Bits"
]
