# 703. Kth Largest Element in a Stream
# https://leetcode.com/problems/kth-largest-element-in-a-stream/
#
# Design a class to find the kth largest element in a stream. Note that it is
# the kth largest element in the sorted order, not the kth distinct element.
#
# Implement KthLargest class:
# - KthLargest(int k, int[] nums) Initializes the object with the integer k
#   and the stream of integers nums.
# - int add(int val) Appends the integer val to the stream and returns the
#   element representing the kth largest element in the stream.
#
# Example 1:
#   Input: ["KthLargest", "add", "add", "add", "add", "add"]
#          [[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
#   Output: [null, 4, 5, 5, 8, 8]
#
# Constraints:
# - 1 <= k <= 10^4
# - 0 <= nums.length <= 10^4
# - -10^4 <= nums[i] <= 10^4
# - -10^4 <= val <= 10^4
# - At most 10^4 calls will be made to add.
# - It is guaranteed that there will be at least k elements in the array when
#   you search for the kth element.

# APPROACH: Min-heap of size k
# Keep only the k largest elements in a min-heap. The top (smallest of the k)
# is always the kth largest overall. On add: push, if size > k pop smallest.
#
# TIME: O(n log k) init, O(log k) per add
# SPACE: O(k) for the heap

import heapq

class KthLargestElementInAStream:
    def __init__(self, k: int, nums: list[int]):
        self.k = k
        self.heap = []  # min-heap holding the top k elements

        for num in nums:
            heapq.heappush(self.heap, num)
            if(len(self.heap) > self.k):
                heapq.heappop(self.heap)  # evict smallest, keep top k

    def add(self, val: int) -> int:
        heapq.heappush(self.heap, val)
        if(len(self.heap) > self.k):
            heapq.heappop(self.heap)  # maintain size k
        return self.heap[0]  # top of min-heap = kth largest
