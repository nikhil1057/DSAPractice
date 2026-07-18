# 20. Valid Parentheses
# https://leetcode.com/problems/valid-parentheses/
#
# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
# determine if the input string is valid.
#
# An input string is valid if:
# 1. Open brackets must be closed by the same type of brackets.
# 2. Open brackets must be closed in the correct order.
# 3. Every close bracket has a corresponding open bracket of the same type.
#
# CATEGORY: Stack (Easy)
#
# HINTS:
# - Use a stack to track opening brackets.
# - When you encounter a closing bracket, check if the top of the stack matches.
# - If the stack is empty at the end, the string is valid.
#
# TIME: O(n) — single pass through the string
# SPACE: O(n) — stack can hold up to n/2 opening brackets


class ValidParentheses:
    def is_valid(self, s: str) -> bool:
        # TODO: Implement using a stack
        pass
