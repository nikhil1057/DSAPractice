# 15. 3Sum
# https://leetcode.com/problems/3sum/
#
# Given an integer array nums, return all the triplets [nums[i], nums[j],
# nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] +
# nums[k] == 0. Notice that the solution set must not contain duplicate
# triplets.
#
# APPROACH:
# Sort the array first. For each element nums[i], use two pointers (left, right)
# to find pairs that sum to -nums[i]. Skip duplicates at all three positions
# to avoid duplicate triplets. If nums[i] > 0, break early since no valid
# triplet can exist with all positive numbers.
#
# TIME: O(n^2) - sorting is O(n log n), then O(n) two-pointer scan for each element
# SPACE: O(1) - ignoring the output array, only constant extra space used


class ThreeSum:
    def three_sum(self, nums: list[int]) -> list[list[int]]:
        res = []

        if len(nums) == 0 or len(nums) < 3: return res

        list.sort(nums)

        for i in range(len(nums) - 2):
            if(nums[i] > 0 or (i > 0 and nums[i] == nums[i - 1])): continue

            left, right = i + 1, len(nums) - 1
            while left < right:
                sum = nums[i] + nums[right] + nums[left]

                if(sum == 0):
                    res.append([nums[i], nums[left], nums[right]])
                    left += 1
                    right -= 1
                    while(left < right and nums[left] == nums[left - 1]): left += 1
                    while(left < right and nums[right] == nums[right + 1]): right -= 1
                elif sum > 0: right -= 1
                else: left += 1
        
        return res
