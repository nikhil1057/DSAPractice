# 49. Group Anagrams
# https://leetcode.com/problems/group-anagrams/
#
# Given an array of strings strs, group the anagrams together. You can return
# the answer in any order. An anagram is a word or phrase formed by rearranging
# the letters of a different word or phrase, typically using all the original
# letters exactly once.
#
# APPROACH: Frequency tuple as HashMap key
#
# KEY INSIGHT: All anagrams have identical character frequencies.
# Use a tuple of 26 character counts as the unique key for each group.
#
# HOW IT WORKS:
# - For each string, build a frequency array (26 slots for a-z).
# - Convert to tuple (hashable) and use as dictionary key.
# - Append the original string to its group.
#
# ALT APPROACH: Sort each string as key — simpler but O(n * k log k).
# Frequency tuple is O(n * k) since no sorting needed.
#
# TIME: O(n * k) — n strings, k = average string length
# SPACE: O(n * k) — storing all strings in the map


class GroupAnagrams:
    def group_anagrams(self, strs: list[str]) -> list[list[str]]:
        groups = {}  # Maps frequency tuple → list of anagrams

        for s in strs:
            count = [0] * 26                       # Frequency array for a-z
            for c in s:
                count[ord(c) - ord('a')] += 1      # Count each character
            key = tuple(count)                     # Convert to hashable key
            if key not in groups:
                groups[key] = []                   # New group
            groups[key].append(s)                  # Add string to its anagram group

        return list(groups.values())  # Return all groups
