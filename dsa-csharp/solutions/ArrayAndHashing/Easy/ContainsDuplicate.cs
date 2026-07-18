// 217. Contains Duplicate
// https://leetcode.com/problems/contains-duplicate/
//
// Given an integer array nums, return true if any value appears at least twice
// in the array, and return false if every element is distinct.
//
// APPROACH: HashSet with early exit
//
// KEY INSIGHT: A HashSet gives O(1) lookup. As we iterate, if we've already
// seen a number, we immediately know there's a duplicate.
//
// HOW IT WORKS:
// - Iterate through the array.
// - For each number, check if it's already in the set.
// - If yes → duplicate found, return true immediately.
// - If no → add it to the set and continue.
//
// WHY EARLY EXIT: We short-circuit on the first duplicate without
// processing the remaining elements.
//
// TIME: O(n) — single pass, O(1) average set lookup
// SPACE: O(n) — set stores up to n elements

public class ContainsDuplicate
{
    public bool ContainsDuplicateSolution(int[] nums)
    {
        if(nums.Length == 1) return false;  // Single element can't have duplicates

        var set = new HashSet<int>();       // Track numbers we've seen

        foreach(int num in nums)
        {
            if(set.Contains(num)) return true;  // Already seen → duplicate
            else set.Add(num);                  // First time → remember it
        }

        return false;  // No duplicates found
    }
}
