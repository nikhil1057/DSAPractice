// 169. Majority Element
// https://leetcode.com/problems/majority-element/
//
// Given an array nums of size n, return the majority element.
// The majority element is the element that appears more than ⌊n / 2⌋ times.
// You may assume that the majority element always exists in the array.
//
// APPROACH: Boyer-Moore Voting Algorithm
//
// KEY INSIGHT: The majority element appears MORE than n/2 times. So if we "cancel out"
// each occurrence of the majority with a non-majority element, the majority still survives.
//
// HOW IT WORKS:
// - Maintain a `candidate` and a `count`.
// - When count drops to 0, pick the current element as the new candidate.
// - If current element matches candidate, increment count (support).
// - If it doesn't match, decrement count (opposition cancels one support).
// - The majority element will always be the last candidate standing because
//   it has more supporters than all opposition combined.
//
// ANALOGY: Think of it as a battle. Each majority element is a soldier for one side.
// When two different elements meet, they cancel each other out (both die).
// Since majority has > n/2 soldiers, they always have survivors at the end.
//
// TIME: O(n) — single pass
// SPACE: O(1) — just two variables

public class MajorityElement
{
    public int MajorityElementSolution(int[] nums)
    {
        int count = 0;      // How many "votes" the current candidate has
        int candidate = -1; // Current candidate for majority element

        for(int i = 0; i< nums.Length; i++)
        {
            // If count is 0, the previous candidate was fully cancelled out.
            // Start fresh with the current element as the new candidate.
            if(count == 0) candidate = nums[i];

            // If current element is different from candidate, cancel one vote
            if(nums[i] != candidate) count--;
            // If current element matches candidate, add one vote
            else count++;
        }

        // The candidate left standing is guaranteed to be the majority element
        // (since the problem guarantees one exists)
        return candidate;
    }
}
