# 76. Minimum Window Substring
# https://leetcode.com/problems/minimum-window-substring/
#
# Given two strings s and t of lengths m and n respectively, return the minimum
# window substring of s such that every character in t (including duplicates)
# is included in the window. If there is no such substring, return the empty
# string "". The answer is guaranteed to be unique.
#
# APPROACH: Variable-size sliding window with "have" vs "need" counters.
# Expand right until window contains all of t, then shrink left to minimize.
# Track when each character's count meets its required frequency.
#
# TIME: O(m + n) where m = len(s), n = len(t)
# SPACE: O(n) for the frequency maps

from collections import Counter


class MinimumWindowSubstring:
    def min_window(self, s: str, t: str) -> str:
        if not t or not s:
            return ""

        # Dictionary to store the frequency of characters in target string t
        target_counts = Counter(t)

        # Number of unique characters in t that need to be present in the window
        need = len(target_counts)
        # Number of unique characters in the current window that match target_counts frequency
        have = 0
        # HashMap to keep track of characters in the current window
        window_counts = Counter()
        # Result tuple: (window_length, left_index, right_index)
        res = (float("inf"), 0, 0)
        left = 0

        # Expand the window by moving the right pointer
        for right in range(len(s)):
            char = s[right]

            window_counts[char] += 1

            if char in target_counts and window_counts[char] == target_counts[char]:
                have += 1

            while have == need:
                # Update result if this window is smaller
                if (right - left + 1) < res[0]:
                    res = (right - left + 1, left, right)

                left_char = s[left]

                # IF while shrinking we lose the character from t then we lose it from have
                if left_char in target_counts and window_counts[left_char] == target_counts[left_char]:
                    have -= 1
                window_counts[left_char] -= 1
                left += 1

        return s[res[1]:res[2] + 1] if res[0] != float("inf") else ""
