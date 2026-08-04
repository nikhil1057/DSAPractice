# 84. Largest Rectangle in Histogram
# https://leetcode.com/problems/largest-rectangle-in-histogram/
#
# Given an array of integers heights representing the histogram's bar height where
# the width of each bar is 1, return the area of the largest rectangle in the histogram.
#
# APPROACH: Monotonic increasing stack (one pass). For each bar, when a shorter bar
# appears, it becomes the NSE (Next Smaller Element) of the stack top. The PSE
# (Previous Smaller Element) is sitting underneath in the stack. Width = NSE - PSE - 1.
#
# TIME: O(n) — each bar is pushed/popped at most once
# SPACE: O(n) — stack space


class LargestRectangleInHistogram:
    def largest_rectangle_area(self, heights: list[int]) -> int:
        stack = []  # stores indices in increasing order of heights
        max_area = 0

        for i in range(len(heights)):
            while stack and heights[stack[-1]] >= heights[i]:
                # You encountered a smaller element — it becomes the NSE of the stack top
                # Example: [3,2,10,11,5,10,6,3] — if you are at 5, then 11 can't go right
                # As 5 is smaller than 11, so 5 is NSE of 11
                # PSE of 11 is sitting under it inside the stack (we only keep smaller elements below)

                height = heights[stack.pop()]  # height of the popped bar

                # If stack is empty → no PSE, this bar can extend all the way to the left
                # If stack is not empty → stack top is the PSE
                # Width = NSE - PSE - 1 → i - stack[-1] - 1
                width = i if not stack else i - stack[-1] - 1

                max_area = max(max_area, height * width)

            stack.append(i)

        # Remaining elements in stack — no NSE was found for them during iteration
        # If there was a smaller element to their right, they would have been popped already
        while stack:
            height = heights[stack.pop()]

            # NSE doesn't exist → bar can extend all the way to the right → NSE = len(heights)
            # If stack is empty → no PSE either → width = len(heights) (smallest bar, spans entire array)
            # If stack is not empty → PSE = stack top → width = len(heights) - stack[-1] - 1
            width = len(heights) if not stack else len(heights) - stack[-1] - 1

            max_area = max(max_area, height * width)

        return max_area
