# 33. Search in Rotated Sorted Array
# https://leetcode.com/problems/search-in-rotated-sorted-array/
#
# There is an integer array nums sorted in ascending order (with distinct values).
# Prior to being passed to your function, nums is possibly rotated at an unknown pivot.
# Given the array nums after the possible rotation and an integer target, return the
# index of target if it is in nums, or -1 if it is not in nums.
#
# APPROACH: Binary search. At any mid, one half is always sorted.
# Figure out which half is sorted, then check if target falls in that sorted range.
# If yes → search that half. If no → search the other half.
#
# WHY left <= right and mid ± 1?
# We check nums[mid] == target FIRST. If it matches, return immediately.
# If not, mid is NOT the answer — safe to discard with mid ± 1.
#
# TIME: O(log n) — binary search
# SPACE: O(1) — constant extra space


class SearchInRotatedSortedArray:
    def search(self, nums: list[int], target: int) -> int:
        left, right = 0, len(nums) - 1

        while left <= right:
            mid = (left + right) // 2

            # Found the target — return immediately
            if nums[mid] == target:
                return mid

            # Determine which half is sorted
            if nums[left] <= nums[mid]:
                # LEFT half is sorted [left...mid]
                # Is target in this sorted range?
                if nums[left] <= target < nums[mid]:
                    right = mid - 1  # yes → search left
                else:
                    left = mid + 1   # no → search right
            else:
                # RIGHT half is sorted [mid...right]
                # Is target in this sorted range?
                if nums[mid] < target <= nums[right]:
                    left = mid + 1   # yes → search right
                else:
                    right = mid - 1  # no → search left

        return -1  # target not found
