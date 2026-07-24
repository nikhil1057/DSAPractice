# 424. Longest Repeating Character Replacement
# https://leetcode.com/problems/longest-repeating-character-replacement/
#
# You are given a string s and an integer k. You can choose any character of
# the string and change it to any other uppercase English letter. You can
# perform this operation at most k times. Return the length of the longest
# substring containing the same letter you can get after performing the above
# operations.
#
# APPROACH:
# Use a sliding window with a frequency map. The idea is: in any window,
# pick the most common character and replace everything else. If the number
# of replacements needed (window_size - max_freq) exceeds k, the window
# is too big — shrink it from the left.
#
# Think of it like: "what's the longest stretch where I only need to fix
# at most k characters to make them all the same?"
#
# max_freq never decreases — that's okay because we only care about finding
# a LONGER valid window, which can only happen when max_freq grows.
#
# TIME: O(n) - each character is visited at most twice (once by right, once by left)
# SPACE: O(1) - frequency map has at most 26 entries (uppercase English letters)


class LongestRepeatingCharacterReplacement:
    def character_replacement(self, s: str, k: int) -> int:
        count = {}
        left, result, max_freq = 0, 0, 0

        for right in range(len(s)):
            count[s[right]] = count.get(s[right], 0) + 1

            max_freq = max(max_freq, count[s[right]])

            while(right - left + 1) - max_freq > k:
                count[s[left]] -= 1
                left += 1
            result = max(result, right - left + 1)
        return result
