// 1. Two Sum
// https://leetcode.com/problems/two-sum/
//
// Given an array of integers nums and an integer target, return indices of the
// two numbers such that they add up to target. You may assume that each input
// would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
//
// APPROACH: HashMap storing complement → index
//
// KEY INSIGHT: For each number, we need (target - num) to complete the pair.
// Store the complement as a key so a future number can instantly find its match.
//
// HOW IT WORKS:
// - For each num, check if it exists as a key in the map.
// - If yes → we previously stored it as someone's complement → pair found.
// - If no → store (target - num) as key with current index as value.
//
// TIME: O(n) — single pass, O(1) average map lookup
// SPACE: O(n) — map stores up to n complements

public class TwoSum
{
    public int[] TwoSumSolution(int[] nums, int target)
    {
        Dictionary<int,int> dict = new();  // Maps complement (target - num) → index

        for(int i= 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))   // This num is someone's complement → pair found
            {
                return new int [] {dict[nums[i]], i};
            }

            else
            {
                dict[target - nums[i]] = i;  // Store what we need to complete this num's pair
            }
        }

        return new int[] {};
    }
}
