// 1046. Last Stone Weight
// https://leetcode.com/problems/last-stone-weight/
//
// You are given an array of integers stones where stones[i] is the weight of
// the ith stone. On each turn, choose the heaviest two stones and smash them.
// If x == y, both are destroyed. If x != y, the stone of weight x is destroyed,
// and the stone of weight y has new weight y - x.
// Return the weight of the last remaining stone. If there are no stones left, return 0.
//
// Example 1: Input: stones = [2,7,4,1,8,1] Output: 1
// Example 2: Input: stones = [1] Output: 1
//
// Constraints:
// - 1 <= stones.length <= 30
// - 1 <= stones[i] <= 1000

// APPROACH: Max-heap (via negative priority) — always smash the two heaviest
// Use negative priority to simulate max-heap with .NET's min PriorityQueue.
// Pop two largest, push remainder if non-zero. Repeat until ≤1 stone.
//
// TIME: O(n log n) — each push/pop is O(log n), at most n iterations
// SPACE: O(n) for the heap

public class LastStoneWeight
{
    public int LastStoneWeightMethod(int[] stones)
    {
        if(stones.Length == 1) return stones[0];

        // Max-heap via negative priority
        PriorityQueue<int,int> heap = new();

        foreach(int stone in stones)
            heap.Enqueue(stone, -stone);  // negate priority for max-heap
        
        while(heap.Count > 1)
        {
            int first = heap.Dequeue();   // largest
            int second = heap.Dequeue();  // second largest
            int result = first - second;

            if(result != 0)
                heap.Enqueue(result, -result);  // push remainder (negated)
        }

        return heap.Count == 1 ? heap.Peek() : 0;
    }
}
