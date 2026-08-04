# 567. Permutation in String
# https://leetcode.com/problems/permutation-in-string/
#
# Given two strings s1 and s2, return true if s2 contains a permutation of s1,
# or false otherwise. In other words, return true if one of s1's permutations
# is the substring of s2.
#
# APPROACH: Fixed sliding window of size len(s1) with a "matches" counter.
# Build frequency arrays for s1 and the first window of s2, count how many of
# 26 characters have equal frequency. Slide window one char at a time, updating
# matches in O(1) per step. When matches == 26, a permutation is found.
#
# TIME: O(n) where n = len(s2)
# SPACE: O(1) — two arrays of size 26


class PermutationInString:
    def check_inclusion(self, s1: str, s2: str) -> bool:
        if len(s1) > len(s2):
            return False

        s1_count = [0] * 26
        s2_count = [0] * 26

        for i in range(len(s1)):
            s1_count[ord(s1[i]) - ord('a')] += 1
            s2_count[ord(s2[i]) - ord('a')] += 1

        # count how many of 26 characters already match
        matches = 0
        for i in range(26):
            if s1_count[i] == s2_count[i]:
                matches += 1

        # slide the window
        l = 0
        for r in range(len(s1), len(s2)):
            if matches == 26:
                return True

            # add right character
            idx = ord(s2[r]) - ord('a')
            s2_count[idx] += 1
            if s2_count[idx] == s1_count[idx]:
                matches += 1
            elif s2_count[idx] == s1_count[idx] + 1:
                matches -= 1

            # remove left character
            idx = ord(s2[l]) - ord('a')
            s2_count[idx] -= 1
            if s2_count[idx] == s1_count[idx]:
                matches += 1
            elif s2_count[idx] == s1_count[idx] - 1:
                matches -= 1

            l += 1

        return matches == 26
