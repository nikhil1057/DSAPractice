# 153. Find Minimum in Rotated Sorted Array
# https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
#
# Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
# Given the sorted rotated array nums of unique elements, return the minimum element.
# You must write an algorithm that runs in O(log n) time.
#
# CATEGORY: Binary Search (Medium)
#
# HINTS:
# - Use binary search. The minimum is at the rotation point.
# - If nums[mid] > nums[right], the minimum is in the right half.
# - Otherwise, the minimum is in the left half (including mid).
# - Shrink the search space until left == right.
#
# TIME: O(log n) — binary search
# SPACE: O(1) — constant extra space


class FindMinimumInRotatedSortedArray:
    def find_min(self, nums: list[int]) -> int:
        # TODO: Implement using binary search
        pass
