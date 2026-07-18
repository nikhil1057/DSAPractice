# 33. Search in Rotated Sorted Array
# https://leetcode.com/problems/search-in-rotated-sorted-array/
#
# There is an integer array nums sorted in ascending order (with distinct values).
# Prior to being passed to your function, nums is possibly rotated at an unknown pivot.
# Given the array nums after the possible rotation and an integer target, return the
# index of target if it is in nums, or -1 if it is not in nums.
#
# You must write an algorithm with O(log n) runtime complexity.
#
# CATEGORY: Binary Search (Medium)
#
# HINTS:
# - Use binary search. Determine which half is sorted.
# - If nums[left] <= nums[mid], the left half is sorted.
#   Check if target is in [left, mid). If so, search left; otherwise search right.
# - Otherwise, the right half is sorted.
#   Check if target is in (mid, right]. If so, search right; otherwise search left.
#
# TIME: O(log n) — binary search
# SPACE: O(1) — constant extra space


class SearchInRotatedSortedArray:
    def search(self, nums: list[int], target: int) -> int:
        # TODO: Implement using modified binary search
        pass
