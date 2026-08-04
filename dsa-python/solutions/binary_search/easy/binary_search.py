# 704. Binary Search
# https://leetcode.com/problems/binary-search/
#
# Given an array of integers nums which is sorted in ascending order, and an integer target,
# write a function to search target in nums. If target exists, then return its index.
# Otherwise, return -1.
#
# APPROACH: Classic binary search. Maintain left and right pointers, calculate mid,
# compare nums[mid] with target. Halve the search space each iteration.
#
# TIME: O(log n) — halving the search space each step
# SPACE: O(1) — constant extra space


class BinarySearch:
    def search(self, nums: list[int], target: int) -> int:
        l, r = 0, len(nums) - 1

        while l <= r:
            m = (l + r) // 2  # safe in Python (no overflow), equivalent to l + (r - l) // 2

            if nums[m] > target:
                r = m - 1  # target is in the left half
            elif nums[m] < target:
                l = m + 1  # target is in the right half
            else:
                return m  # found it

        return -1  # target not in array
