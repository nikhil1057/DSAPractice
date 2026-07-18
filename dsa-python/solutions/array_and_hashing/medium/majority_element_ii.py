# 229. Majority Element II
# https://leetcode.com/problems/majority-element-ii/
#
# Given an integer array of size n, find all elements that appear more than
# ⌊n/3⌋ times. Return the answer in any order.
#
# APPROACH: Extended Boyer-Moore Voting Algorithm (two candidates)
#
# KEY INSIGHT: At most 2 elements can appear more than ⌊n/3⌋ times.
# We extend Boyer-Moore from 1 candidate to 2 candidates.
#
# HOW IT WORKS (two passes):
# Pass 1 — Find candidates:
# - Maintain two candidates with two counters.
# - If current matches candidate1 → increment count1.
# - If current matches candidate2 → increment count2.
# - If count1 == 0 → replace candidate1 with current.
# - If count2 == 0 → replace candidate2 with current.
# - Otherwise → decrement both counts (three-way cancellation).
#
# Pass 2 — Verify candidates:
# - Count actual occurrences of each candidate.
# - Only include those with count > ⌊n/3⌋.
#
# WHY TWO PASSES: Unlike Majority Element (>n/2), the >n/3 version
# doesn't guarantee candidates are valid — we must verify.
#
# TIME: O(n) — two passes
# SPACE: O(1) — constant extra space

class MajorityElementII:
    def majority_element(self, nums: list[int]) -> list[int]:
        candidate1, candidate2, count1, count2 = 0, 0, 0, 0

        for num in nums:
            if num == candidate1: count1 += 1
            elif num == candidate2: count2 += 1
            elif count1 == 0:
                candidate1 = num
                count1 += 1
            elif count2 == 0:
                candidate2 = num
                count2 += 1
            else:
                count1 -= 1
                count2 -= 1

        count1, count2 = 0, 0

        for num in nums:
            if num == candidate1: count1 += 1
            if num == candidate2: count2 += 1

        n = len(nums)
        result = []
        if count1 > n // 3: result.append(candidate1)
        if count2 > n // 3 and candidate2 != candidate1: result.append(candidate2)

        return result

