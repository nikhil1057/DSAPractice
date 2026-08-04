# 167. Two Sum II - Input Array Is Sorted
# https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
#
# Given a 1-indexed array of integers numbers that is already sorted in
# non-decreasing order, find two numbers such that they add up to a specific
# target number. Return the indices of the two numbers (1-indexed) as an
# integer array of length 2.
#
# APPROACH: Two Pointers converging from both ends
#
# KEY INSIGHT: Array is sorted → use two pointers.
# If sum > target → move right inward (need smaller number).
# If sum < target → move left inward (need bigger number).
#
# WHY NOT HASHMAP: Sorted array + O(1) space constraint → two pointers is optimal.
#
# TIME: O(n) — each pointer moves at most n times total
# SPACE: O(1) — just two variables


class TwoSumIIInputArrayIsSorted:
    def two_sum(self, numbers: list[int], target: int) -> list[int]:
        left, right = 0, len(numbers) - 1

        while left < right:
            total = numbers[left] + numbers[right]       # Sum of current pair
            if total == target: return [left+1, right+1] # Found! (1-indexed)
            elif total > target: right -= 1              # Too big → shrink from right
            else: left += 1                              # Too small → grow from left
        return []
