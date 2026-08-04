# 125. Valid Palindrome
# https://leetcode.com/problems/valid-palindrome/
#
# A phrase is a palindrome if, after converting all uppercase letters into
# lowercase letters and removing all non-alphanumeric characters, it reads the
# same forward and backward. Alphanumeric characters include letters and numbers.
# Given a string s, return true if it is a palindrome, or false otherwise.
#
# APPROACH: Filter + Two Pointers from both ends
#
# KEY INSIGHT: Strip non-alphanumeric chars, lowercase everything, then
# check if it reads the same forwards and backwards using two pointers.
#
# HOW IT WORKS:
# - Build a cleaned list (only alphanumeric, lowercased).
# - Left pointer starts at 0, right at end.
# - If they ever mismatch → not a palindrome.
# - Move both inward until they meet.
#
# TIME: O(n) — one pass to filter, one pass to compare
# SPACE: O(n) — filtered array


class ValidPalindrome:
    def is_palindrome(self, s: str) -> bool:
        arr = [c.lower() for c in s if c.isalnum()]  # Filter + lowercase

        left, right = 0, len(arr) - 1
        while left < right:
            if arr[left] != arr[right]: return False  # Mismatch → not palindrome
            left += 1
            right -= 1
        return True
