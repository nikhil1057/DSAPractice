# 4. Median of Two Sorted Arrays
# https://leetcode.com/problems/median-of-two-sorted-arrays/
#
# Given two sorted arrays nums1 and nums2 of size m and n respectively,
# return the median of the two sorted arrays.
# The overall run time complexity should be O(log (m+n)).
#
# APPROACH: Binary search on the shorter array to find the correct partition.
# The median splits combined array into two equal halves.
# Binary search HOW MANY elements to take from shortArray into left half.
# Check 4 boundary values to validate the partition.
#
# WHY (totalLength + 1) // 2?
# For odd total (e.g., 5), left half gets 3, right gets 2.
# Median = max of left half. Without +1, left half would be too small.
#
# TIME: O(log(min(m,n))) — binary search on shorter array
# SPACE: O(1) — constant extra space


class MedianOfTwoSortedArrays:
    def find_median_sorted_arrays(self, nums1: list[int], nums2: list[int]) -> float:
        totalLength = len(nums1) + len(nums2)
        totalLeftElements = (totalLength + 1) // 2

        # Always binary search on the shorter array
        shortArray = nums1 if len(nums1) <= len(nums2) else nums2
        longArray = nums2 if len(nums1) <= len(nums2) else nums1

        # Range: 0 (take nothing) to len(shortArray) (take all)
        left, right = 0, len(shortArray)

        while left <= right:
            mid1 = (left + right) // 2            # elements from shortArray in left half
            mid2 = totalLeftElements - mid1        # elements from longArray in left half

            # Get 4 boundary values (use -inf/inf when partition is at edge)
            leftShort = shortArray[mid1 - 1] if mid1 > 0 else float('-inf')
            rightShort = shortArray[mid1] if mid1 < len(shortArray) else float('inf')
            leftLong = longArray[mid2 - 1] if mid2 > 0 else float('-inf')
            rightLong = longArray[mid2] if mid2 < len(longArray) else float('inf')

            if leftShort <= rightLong and leftLong <= rightShort:
                # Correct partition found!
                if totalLength % 2 == 1:
                    return max(leftShort, leftLong)  # odd: median is max of left half
                else:
                    return (max(leftShort, leftLong) + min(rightShort, rightLong)) / 2.0
            elif leftShort > rightLong:
                right = mid1 - 1  # took too many from short → shrink
            else:
                left = mid1 + 1   # took too few from short → expand

        return -1
