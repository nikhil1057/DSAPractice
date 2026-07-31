# 155. Min Stack
# https://leetcode.com/problems/min-stack/
#
# Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
#
# Implement the MinStack class:
# - MinStack() initializes the stack object.
# - push(val) pushes the element val onto the stack.
# - pop() removes the element on the top of the stack.
# - top() gets the top element of the stack.
# - get_min() retrieves the minimum element in the stack.
#
# APPROACH: Two stacks — one for values, one for tracking minimums.
# Only push to min_stack when val <= current min. Only pop from min_stack
# when popped value equals current min. Saves space.
#
# TIME: O(1) for all operations
# SPACE: O(n) — for storing elements and minimums


class MinStack:
    def __init__(self):
        self.stack = []
        self.min_stack = []

    def push(self, val: int) -> None:
        self.stack.append(val)
        if not self.min_stack or val <= self.min_stack[-1]:
            self.min_stack.append(val)

    def pop(self) -> None:
        val = self.stack.pop()
        if val == self.min_stack[-1]:
            self.min_stack.pop()

    def top(self) -> int:
        return self.stack[-1]

    def get_min(self) -> int:
        return self.min_stack[-1]
