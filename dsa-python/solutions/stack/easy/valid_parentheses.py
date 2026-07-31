# 20. Valid Parentheses
# https://leetcode.com/problems/valid-parentheses/
#
# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
# determine if the input string is valid.
#
# APPROACH: Use a stack. When we see an opening bracket, push it.
# When we see a closing bracket, check if the top of stack is the matching opener.
# If not, or stack is empty → invalid. At the end, stack must be empty.
#
# TIME: O(n) — single pass through the string
# SPACE: O(n) — stack can hold up to n/2 opening brackets


class ValidParentheses:
    def is_valid(self, s: str) -> bool:
        stack = []
        # Map each closing bracket to its matching opening bracket
        matching = {')': '(', ']': '[', '}': '{'}

        for c in s:
            if c in matching:
                # Closing bracket — stack must not be empty and top must match
                if not stack or stack[-1] != matching[c]:
                    return False
                stack.pop()
            else:
                # Opening bracket — push onto stack
                stack.append(c)

        # Valid only if all opening brackets were matched
        return len(stack) == 0
