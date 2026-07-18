# 150. Evaluate Reverse Polish Notation
# https://leetcode.com/problems/evaluate-reverse-polish-notation/
#
# You are given an array of strings tokens that represents an arithmetic expression
# in Reverse Polish Notation. Evaluate the expression and return an integer that
# represents the value of the expression.
#
# Valid operators are +, -, *, /. Each operand may be an integer or another expression.
# Division between two integers truncates toward zero.
#
# CATEGORY: Stack (Medium)
#
# HINTS:
# - Use a stack. Push numbers onto it.
# - When you encounter an operator, pop two numbers, apply the operator, and push the result.
# - Be careful with division: use int(a/b) to truncate toward zero in Python.
#
# TIME: O(n) — single pass through tokens
# SPACE: O(n) — stack space


class EvaluateReversePolishNotation:
    def eval_rpn(self, tokens: list[str]) -> int:
        # TODO: Implement using a stack
        pass
