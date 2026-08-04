# 153. Find Minimum in Rotated Sorted Array
# https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
#
# Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
# Given the sorted rotated array nums of unique elements, return the minimum element.
# You must write an algorithm that runs in O(log n) time.
#
# APPROACH: Binary search. Compare nums[mid] with nums[right] to figure out
# which half contains the rotation point (where the minimum lives).
#
# If nums[mid] > nums[right]:
#   → mid is in the LEFT sorted portion (the bigger half)
#   → minimum MUST be to the right → left = mid + 1
#
# If nums[mid] <= nums[right]:
#   → mid is in the RIGHT sorted portion (the smaller half)
#   → minimum is at mid or to the left → right = mid (don't discard mid, it could be the answer)
#
# When left == right, we found the minimum.
#
# TIME: O(log n) — binary search
# SPACE: O(1) — constant extra space


class FindMinimumInRotatedSortedArray:
    def find_min(self, nums: list[int]) -> int:
        left, right = 0, len(nums) - 1

        while left < right:
            mid = left + (right - left) // 2

            if nums[mid] > nums[right]:
                left = mid + 1    # min is in the right half
            else:
                right = mid       # min is at mid or left of mid

        # left == right — they converge at the minimum
        return nums[left]
