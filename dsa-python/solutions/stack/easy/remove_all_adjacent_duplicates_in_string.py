# 1047. Remove All Adjacent Duplicates In String
# https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
#
# You are given a string s consisting of lowercase English letters.
# A duplicate removal consists of choosing two adjacent and equal letters and removing them.
# We repeatedly make duplicate removals on s until we no longer can.
# Return the final string after all such duplicate removals have been made.
#
# CATEGORY: Stack (Easy)
#
# HINTS:
# - Use a stack. Iterate through each character.
# - If the stack is non-empty and the top equals the current char → pop (they cancel).
# - Otherwise → push the current char.
# - At the end, the stack contains the remaining characters in order.
#
# EXAMPLE:
# "abbaca" → push a, push b, b==b pop → "a", push a, a==a pop → "", push c, push a → "ca"
#
# TIME: O(n) — each character is pushed/popped at most once
# SPACE: O(n) — stack can hold up to n characters

class RemoveAllAdjacentDuplicatesInString:
    def remove_duplicates(self, s: str) -> str:
        stack = []

        for char in s:
            if stack and stack[-1] == char:
                stack.pop()
            else:
                stack.append(char)
        
        return ''.join(stack)
