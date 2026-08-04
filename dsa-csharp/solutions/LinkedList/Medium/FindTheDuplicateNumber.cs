// 287. Find the Duplicate Number
// https://leetcode.com/problems/find-the-duplicate-number/
//
// Given an array of integers nums containing n + 1 integers where each integer is in
// the range [1, n] inclusive. There is only one repeated number in nums, return this
// repeated number.
//
// APPROACH: Floyd's Cycle Detection (Tortoise and Hare).
// Treat array as a linked list: nums[i] = next pointer.
// Duplicate means two indices point to the same "node" → cycle exists.
//
// Phase 1: Find meeting point inside the cycle.
//   slow moves one hop: slow = nums[slow]
//   fast moves two hops: fast = nums[nums[fast]]
//   They meet somewhere INSIDE the cycle (not necessarily at entrance).
//
// Phase 2: Find cycle entrance (= the duplicate).
//   One pointer from start, one from meeting point, both one hop at a time.
//   They meet at the entrance because:
//   distance(start → entrance) == distance(meeting point → entrance going around)
//
// TIME: O(n) — Floyd's algorithm
// SPACE: O(1) — constant extra space

public class FindTheDuplicateNumber
{
    public int FindDuplicate(int[] nums)
    {
        // Phase 1: Find meeting point inside the cycle
        int slow = nums[0];
        int fast = nums[0];

        while (true)
        {
            slow = nums[slow];          // one hop
            fast = nums[nums[fast]];    // two hops
            if (slow == fast) break;    // met somewhere inside the cycle
        }

        // Phase 2: Find cycle entrance (= the duplicate)
        // One from start, one from meeting point, same speed → meet at entrance
        int slow2 = nums[0];

        while (slow2 != slow)
        {
            slow = nums[slow];
            slow2 = nums[slow2];
        }

        return slow;  // entrance of cycle = duplicate number
    }
}
