# 1046. Last Stone Weight
# https://leetcode.com/problems/last-stone-weight/
#
# You are given an array of integers stones where stones[i] is the weight of
# the ith stone. We are playing a game with the stones. On each turn, we choose
# the heaviest two stones and smash them together. If x == y, both are destroyed.
# If x != y, the stone of weight x is destroyed, and the stone of weight y has
# new weight y - x. At the end of the game, there is at most one stone left.
# Return the weight of the last remaining stone. If there are no stones left, return 0.
#
# Example 1: Input: stones = [2,7,4,1,8,1] Output: 1
# Example 2: Input: stones = [1] Output: 1
#
# Constraints:
# - 1 <= stones.length <= 30
# - 1 <= stones[i] <= 1000

# APPROACH: Max-heap (via negation) — always smash the two heaviest
# Negate values to simulate max-heap with Python's min-heap.
# Pop two largest, push remainder if non-zero. Repeat until ≤1 stone.
#
# TIME: O(n log n) — each push/pop is O(log n), at most n iterations
# SPACE: O(n) for the heap

import heapq
class LastStoneWeight:
    def last_stone_weight(self, stones: list[int]) -> int:
        if len(stones) == 1: return stones[0]
        heap = []

        for stone in stones:
            heapq.heappush(heap, -stone)  # negate for max-heap
        
        while len(heap) > 1:
            first = -heapq.heappop(heap)   # largest
            second = -heapq.heappop(heap)  # second largest

            if first != second:
                heapq.heappush(heap, second - first)  # remainder (already negative)

        return -heap[0] if heap else 0