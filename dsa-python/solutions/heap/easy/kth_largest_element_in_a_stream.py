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


class KthLargestElementInAStream:
    def __init__(self, k: int, nums: list[int]):
        pass

    def add(self, val: int) -> int:
        pass
