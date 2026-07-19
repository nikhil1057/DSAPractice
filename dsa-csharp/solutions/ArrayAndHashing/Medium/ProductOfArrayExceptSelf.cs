// 238. Product of Array Except Self
// https://leetcode.com/problems/product-of-array-except-self/
//
// Given an integer array nums, return an array answer such that answer[i] is
// equal to the product of all the elements of nums except nums[i]. The product
// of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
// You must write an algorithm that runs in O(n) time and without using the
// division operation.
//
// APPROACH: Left-Right product (two passes, no division)
//
// KEY INSIGHT: result[i] = (product of everything left of i) × (product of everything right of i).
// Compute left products in pass 1, then multiply right products on the fly in pass 2.
//
// HOW IT WORKS:
// Pass 1 (left→right): left[i] = product of nums[0..i-1]
// Pass 2 (right→left): multiply left[i] by running right product, update right.
//
// WHY NO EXTRA ARRAY: Right product is computed on the fly with a single variable.
//
// TIME: O(n) — two passes
// SPACE: O(1) — output array doesn't count as extra space per problem rules

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];

        // Pass 1: left[i] = product of all elements to the LEFT of i
        left[0] = 1;                                    // Nothing to the left of index 0
        for(int i = 1; i < nums.Length; i++)
        {
            left[i] = nums[i - 1] * left[i - 1];       // Accumulate left product
        }

        // Pass 2: Multiply by right product (computed on the fly)
        int right = 1;                                  // Running product of elements to the right
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            left[i] = left[i] * right;                  // left × right = final answer
            right = right * nums[i];                    // Update right product
        }

        return left;
    }
}
