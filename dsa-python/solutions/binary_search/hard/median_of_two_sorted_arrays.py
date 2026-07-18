# 4. Median of Two Sorted Arrays
# https://leetcode.com/problems/median-of-two-sorted-arrays/
#
# Given two sorted arrays nums1 and nums2 of size m and n respectively,
# return the median of the two sorted arrays.
# The overall run time complexity should be O(log (m+n)).
#
# CATEGORY: Binary Search (Hard)
#
# HINTS:
# - Binary search on the shorter array to find the correct partition.
# - Partition both arrays such that left elements <= right elements.
# - For the shorter array, binary search partition index i; j = (m+n+1)//2 - i.
# - Check if max_left <= min_right for both arrays at the partition.
# - Handle edge cases with -inf and +inf for boundaries.
#
# TIME: O(log(min(m,n))) — binary search on shorter array
# SPACE: O(1) — constant extra space


class MedianOfTwoSortedArrays:
    def find_median_sorted_arrays(self, nums1: list[int], nums2: list[int]) -> float:
        # TODO: Implement using binary search on partition
        pass
