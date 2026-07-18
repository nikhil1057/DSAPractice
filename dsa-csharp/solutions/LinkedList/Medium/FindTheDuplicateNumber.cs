// 287. Find the Duplicate Number
// https://leetcode.com/problems/find-the-duplicate-number/
//
// Given an array of integers nums containing n + 1 integers where each integer is in
// the range [1, n] inclusive. There is only one repeated number in nums, return this
// repeated number.
//
// You must solve the problem without modifying the array nums and using only constant
// extra space.
//
// CATEGORY: Linked List (Medium)
//
// HINTS:
// - Treat the array as a linked list where nums[i] is the next pointer.
// - Since there's a duplicate, there must be a cycle.
// - Use Floyd's cycle detection (tortoise and hare) to find the cycle.
// - Then find the entrance to the cycle, which is the duplicate number.
//
// TIME: O(n) — Floyd's algorithm
// SPACE: O(1) — constant extra space

public class FindTheDuplicateNumber
{
    public int FindDuplicate(int[] nums)
    {
        // TODO: Implement using Floyd's cycle detection
        throw new NotImplementedException();
    }
}
