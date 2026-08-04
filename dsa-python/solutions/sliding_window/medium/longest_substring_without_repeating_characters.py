# 3. Longest Substring Without Repeating Characters
# https://leetcode.com/problems/longest-substring-without-repeating-characters/
#
# Given a string s, find the length of the longest substring without repeating
# characters.
#
# APPROACH:
# Use a sliding window with a set to track characters in the current window.
# Expand the window by moving the right pointer — if the new char isn't in
# the set, add it and update the max length. If it IS in the set, we have
# a duplicate — shrink the window from the left by removing chars until
# the duplicate is gone.
#
# Think of it like: keep growing a window of unique chars. The moment you
# see a repeat, start removing from the left until it's unique again.
#
# TIME: O(n) - each character is added and removed from the set at most once
# SPACE: O(min(n, m)) - where m is the size of the character set (e.g. 26 for lowercase)


class LongestSubstringWithoutRepeatingCharacters:
    def length_of_longest_substring(self, s: str) -> int:
        if s is None: return 0

        i, j, currmax = 0, 0, 0       # i = left pointer, j = right pointer
        seen = set()                    # characters currently in our window

        while(j < len(s)):
            if s[j] not in seen:
                # No duplicate — expand the window
                seen.add(s[j])
                j += 1
                currmax = max(currmax, j - i)  # update best length
            else:
                # Duplicate found — shrink from left until it's gone
                seen.remove(s[i])
                i += 1

        return currmax
