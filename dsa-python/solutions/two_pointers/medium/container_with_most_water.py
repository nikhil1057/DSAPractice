# 11. Container With Most Water
# https://leetcode.com/problems/container-with-most-water/
#
# You are given an integer array height of length n. There are n vertical lines
# drawn such that the two endpoints of the ith line are (i, 0) and
# (i, height[i]). Find two lines that together with the x-axis form a
# container, such that the container contains the most water. Return the
# maximum amount of water a container can store.
#
# APPROACH:
# Use two pointers starting at both ends. Calculate the water as
# (right - left) * min(height[left], height[right]). Move the pointer
# pointing to the shorter line inward, since moving the taller one can
# never increase the area (width decreases and height is still capped
# by the shorter side).
#
# TIME: O(n) - single pass with two pointers
# SPACE: O(1) - only constant extra space used


class ContainerWithMostWater:
    def max_area(self, height: list[int]) -> int:
        if len(height) < 2: return 0
        if len(height) == 2: return min(height)
        left,right = 0, len(height) - 1

        maxWater = 0

        while(left < right):
            calculatedWater = (right - left) * min(height[left],height[right])
            maxWater = max(calculatedWater, maxWater)

            if height[left] < height[right]: left += 1
            else: right -= 1
        return maxWater
