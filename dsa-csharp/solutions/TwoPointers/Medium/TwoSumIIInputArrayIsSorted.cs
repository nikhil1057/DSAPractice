// 167. Two Sum II - Input Array Is Sorted
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
//
// Given a 1-indexed array of integers numbers that is already sorted in
// non-decreasing order, find two numbers such that they add up to a specific
// target number. Return the indices of the two numbers (1-indexed) as an
// integer array of length 2.
//
// APPROACH: Two Pointers converging from both ends
//
// KEY INSIGHT: Array is sorted → use two pointers.
// If sum > target → move right inward (need smaller number).
// If sum < target → move left inward (need bigger number).
//
// WHY NOT HASHMAP: Sorted array + O(1) space constraint → two pointers is optimal.
//
// TIME: O(n) — each pointer moves at most n times total
// SPACE: O(1) — just two variables

public class TwoSumIIInputArrayIsSorted
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            int sum = numbers[left] + numbers[right];   // Sum of current pair
            if(sum == target)
                return new int[] {left + 1, right + 1}; // Found! (1-indexed)
            else if(sum > target) right--;              // Too big → shrink from right
            else left++;                                // Too small → grow from left
        }

        return new int[] {};
    }
}
