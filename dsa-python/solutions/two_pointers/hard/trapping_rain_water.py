# 42. Trapping Rain Water
# https://leetcode.com/problems/trapping-rain-water/
#
# Given n non-negative integers representing an elevation map where the width
# of each bar is 1, compute how much water it can trap after raining.
#
# APPROACH:
# Imagine you're standing between walls of different heights after it rains.
# Water stays on top of shorter walls because taller walls on both sides
# hold it in — like a bowl.
#
# At any position, the water level = the shorter of the two tallest walls
# on either side. Water trapped there = water level - wall height at that spot.
#
# We use two pointers (left and right) starting from both ends, walking inward.
# We also remember the tallest wall we've seen from the left (left_max) and
# from the right (right_max).
#
# The trick: if the left wall is shorter than the right wall, we KNOW the
# right side has something tall enough — so the bottleneck is on the left.
# We only need to compare with left_max to figure out trapped water.
# Same logic applies when the right wall is shorter.
#
# TIME: O(n) - we visit each bar exactly once
# SPACE: O(1) - just a few variables, no extra arrays needed


class TrappingRainWater:
    def trap(self, height: list[int]) -> int:
        left, right = 0, len(height) - 1          # start from both ends
        left_max, right_max, water = 0, 0, 0      # track tallest walls and total water

        while(left < right):
            # Process the shorter side — that's where the bottleneck is
            if(height[left] < height[right]):
                # Left side is shorter, so left_max decides the water level here
                if(height[left] >= left_max):
                    # This bar is taller than anything from the left
                    # No water can sit here — it would just flow off
                    left_max = height[left]
                else:
                    # This bar is shorter than left_max
                    # Water fills up to left_max level, trapped water = difference
                    water += left_max - height[left]
                left += 1  # move to the next bar from the left
            else:
                # Right side is shorter (or equal), so right_max decides water level
                if(height[right] >= right_max):
                    # Taller than anything from the right — no water here
                    right_max = height[right]
                else:
                    # Shorter bar — water fills the gap
                    water += right_max - height[right]
                right -= 1  # move to the next bar from the right
        
        return water
