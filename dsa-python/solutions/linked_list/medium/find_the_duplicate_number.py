# 287. Find the Duplicate Number
# https://leetcode.com/problems/find-the-duplicate-number/
#
# Given an array of integers nums containing n + 1 integers where each integer is in
# the range [1, n] inclusive. There is only one repeated number in nums, return this
# repeated number.
#
# APPROACH: Floyd's Cycle Detection (Tortoise and Hare).
# Treat array as a linked list: nums[i] = next pointer.
# Duplicate means two indices point to the same "node" → cycle exists.
# Phase 1: Find meeting point (slow/fast inside cycle).
# Phase 2: Find cycle entrance (one pointer from start, one from meeting point,
#           same speed — they meet at the duplicate).
#
# TIME: O(n) — Floyd's algorithm
# SPACE: O(1) — constant extra space


class FindTheDuplicateNumber:
    def find_duplicate(self, nums: list[int]) -> int:
        # Phase 1: Find meeting point inside the cycle
        slow, fast = nums[0], nums[0]

        while True:
            slow = nums[slow]          # one hop
            fast = nums[nums[fast]]    # two hops
            if slow == fast:
                break

        # Phase 2: Find cycle entrance (= the duplicate)
        slow2 = nums[0]
        while slow2 != slow:
            slow = nums[slow]
            slow2 = nums[slow2]

        return slow
