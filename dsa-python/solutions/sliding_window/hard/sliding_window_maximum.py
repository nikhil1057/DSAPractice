# 239. Sliding Window Maximum
# https://leetcode.com/problems/sliding-window-maximum/
#
# You are given an array of integers nums, there is a sliding window of size k
# which is moving from the very left of the array to the very right. You can
# only see the k numbers in the window. Each time the sliding window moves
# right by one position. Return the max sliding window.
#
# APPROACH: Monotonic decreasing deque. Keep indices in deque such that values
# are always decreasing from front to back. Front is always the current max.
# Kick out smaller elements from back, remove expired elements from front.
#
# TIME: O(n) — each element is added and removed from deque at most once
# SPACE: O(k) — deque holds at most k elements

from collections import deque


class SlidingWindowMaximum:
    def max_sliding_window(self, nums: list[int], k: int) -> list[int]:
        d = deque()
        result = []

        for i in range(len(nums)):
            # STEP 1 - Remove from back - kick out smaller elements
            # They'll never be the max while current element exists
            while d and nums[d[-1]] <= nums[i]:
                d.pop()

            # STEP 2: Add current index to back - as it is the maximum for now
            d.append(i)

            # STEP 3: Remove from front if outside window
            # i - k + 1 THIS TELLS THAT YOU ARE TRYING TO FIND THE LENGTH OF CURRENT WINDOW.
            # IF YOU ARE STANDING AT i=3 THEN YOUR WINDOW WILL BE 1,2,3 BECAUSE YOU TRAVERSED FROM 0 to 1, NOW k = 3 THAT MEANS i + 1 = 4, YOU ARE AT 4th ELEMENT
            # AND YOUR WINDOW IS 4 - k -> 4-3 = 1, 1st ELEMENT TO 4TH ELEMENT, THAT MEANS 0 ELEMENT SHOULD BE OUT OF THE WINDOW. IF THAT IS SITTING AT FRONT, KICK IT
            if d[0] < i - k + 1:
                d.popleft()

            # STEP 4: Record answer once window is full
            # THIS TELLS THAT YOU HAVE COMPLETED FIRST WINDOW FROM NOW ON YOU WILL BE ADDING ONE AND REMOVING ONE
            # SO THE ELEMENT AT FIRST OF DEQUE MUST BE THE MAXIMUM OF THAT WINDOW
            if i >= k - 1:
                result.append(nums[d[0]])

        return result
