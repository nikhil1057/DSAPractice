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
# APPROACH: Use a stack. Push numbers onto it. When you encounter an operator,
# pop two numbers (first popped = right operand, second popped = left operand),
# apply the operator, and push the result back.
#
# TIME: O(n) — single pass through tokens
# SPACE: O(n) — stack space


class EvaluateReversePolishNotation:
    def eval_rpn(self, tokens: list[str]) -> int:
        stack = []

        for token in tokens:
            if token in "+-*/":
                value1 = stack.pop()  # right operand
                value2 = stack.pop()  # left operand

                result = 0
                if token == "+":
                    result = value2 + value1
                elif token == "-":
                    result = value2 - value1
                elif token == "*":
                    result = value2 * value1
                elif token == "/":
                    result = int(value2 / value1)  # truncate toward zero

                stack.append(result)
            else:
                stack.append(int(token))

        return stack.pop()
