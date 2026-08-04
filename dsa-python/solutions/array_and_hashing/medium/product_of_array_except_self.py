# 238. Product of Array Except Self
# https://leetcode.com/problems/product-of-array-except-self/
#
# Given an integer array nums, return an array answer such that answer[i] is
# equal to the product of all the elements of nums except nums[i]. The product
# of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
# You must write an algorithm that runs in O(n) time and without using the
# division operation.
#
# APPROACH: Left-Right product (two passes, no division)
#
# KEY INSIGHT: result[i] = (product of everything left of i) × (product of everything right of i).
# Compute left products in pass 1, then multiply right products on the fly in pass 2.
#
# HOW IT WORKS:
# Pass 1 (left→right): left[i] = product of nums[0..i-1]
# Pass 2 (right→left): multiply left[i] by running right product, update right.
#
# WHY NO EXTRA ARRAY: Right product is computed on the fly with a single variable.
#
# TIME: O(n) — two passes
# SPACE: O(1) — output array doesn't count as extra space per problem rules


class ProductOfArrayExceptSelf:
    def product_except_self(self, nums: list[int]) -> list[int]:
        n = len(nums)
        left = [1] * n                        # Will hold left products, then final result

        # Pass 1: left[i] = product of all elements to the LEFT of i
        for i in range(1, n):
            left[i] = left[i-1] * nums[i-1]   # Accumulate left product

        # Pass 2: Multiply by right product (computed on the fly)
        right = 1                              # Running product of elements to the right
        for i in range(n-1, -1, -1):
            left[i] = right * left[i]          # left × right = final answer
            right = right * nums[i]            # Update right product

        return left

