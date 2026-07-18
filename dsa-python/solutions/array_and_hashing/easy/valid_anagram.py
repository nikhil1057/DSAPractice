# 242. Valid Anagram
# https://leetcode.com/problems/valid-anagram/
#
# Given two strings s and t, return true if t is an anagram of s, and false
# otherwise. An anagram is a word or phrase formed by rearranging the letters
# of a different word or phrase, typically using all the original letters
# exactly once.
#
# APPROACH: HashMap frequency count (increment for s, decrement for t)
#
# KEY INSIGHT: Two strings are anagrams iff they have identical character
# frequencies. Build frequency from s, then subtract using t — if anything
# goes negative, t has a char that s doesn't (or has more of it).
#
# HOW IT WORKS:
# - Early exit if lengths differ (can't be anagrams).
# - Pass 1: Count frequency of each char in s (increment).
# - Pass 2: Decrement for each char in t. If any count < 0 → not anagram.
#
# TIME: O(n) — two passes over the strings
# SPACE: O(1) — at most 26 entries in the map (bounded by alphabet size)


class ValidAnagram:
    def is_anagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): return False  # Different lengths → impossible

        # ALTERNATE: Fixed array approach (slightly faster, no hash overhead)
        # count = [0] * 26  # fixed array for a-z
        # for i in range(len(s)):
        #     count[ord(s[i]) - ord('a')] += 1   # ord maps char → index (a=0, b=1, ..., z=25)
        #     count[ord(t[i]) - ord('a')] -= 1
        # return all(c == 0 for c in count)

        count = {}  # Frequency map

        for char in s:
            count[char] = count.get(char, 0) + 1      # Count chars in s (increment)
        for char in t:
            count[char] = count.get(char, 0) - 1      # Subtract chars in t (decrement)
            if(count[char] < 0): return False          # t has extra char → not anagram
        return True  # All counts netted to zero → anagram confirmed
