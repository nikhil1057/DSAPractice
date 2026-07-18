# 217. Contains Duplicate
# https://leetcode.com/problems/contains-duplicate/
#
# Given an integer array nums, return true if any value appears at least twice
# in the array, and return false if every element is distinct.
#
# APPROACH: HashSet with early exit
#
# KEY INSIGHT: A Set gives O(1) lookup. As we iterate, if we've already
# seen a number, we immediately know there's a duplicate.
#
# HOW IT WORKS:
# - Iterate through the array.
# - For each number, check if it's already in the set.
# - If yes → duplicate found, return True immediately.
# - If no → add it to the set and continue.
#
# WHY EARLY EXIT: We short-circuit on the first duplicate without
# processing the remaining elements.
#
# TIME: O(n) — single pass, O(1) average set lookup
# SPACE: O(n) — set stores up to n elements


class ContainsDuplicate:
    def contains_duplicate(self, nums: list[int]) -> bool:
        seen = set()                  # Track numbers we've encountered
        for num in nums:
            if num in seen: return True   # Already seen → duplicate exists
            else: seen.add(num)           # First time → remember it
        return False                  # No duplicates found
