# 84. Largest Rectangle in Histogram
# https://leetcode.com/problems/largest-rectangle-in-histogram/
#
# Given an array of integers heights representing the histogram's bar height where
# the width of each bar is 1, return the area of the largest rectangle in the histogram.
#
# CATEGORY: Stack (Hard)
#
# HINTS:
# - Use a monotonic increasing stack of indices.
# - For each bar, while the stack top is taller, pop and calculate area.
# - The width extends from the current index back to the new stack top + 1.
# - After iterating, pop remaining bars using n as the right boundary.
#
# TIME: O(n) — each bar is pushed/popped at most once
# SPACE: O(n) — stack space


class LargestRectangleInHistogram:
    def largest_rectangle_area(self, heights: list[int]) -> int:
        # TODO: Implement using a monotonic stack
        pass
