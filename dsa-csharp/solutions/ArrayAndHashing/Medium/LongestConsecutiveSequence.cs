// 128. Longest Consecutive Sequence
// https://leetcode.com/problems/longest-consecutive-sequence/
//
// Given an unsorted array of integers nums, return the length of the longest
// consecutive elements sequence. You must write an algorithm that runs in O(n)
// time.
//
// APPROACH: HashSet + smart start detection
//
// KEY INSIGHT: Only start counting from the BEGINNING of a sequence
// (where num-1 doesn't exist). This avoids redundant work.
//
// HOW IT WORKS:
// - Put all numbers in a set for O(1) lookup.
// - For each number, check if it's a sequence start (num-1 not in set).
// - If yes, count forward (num+1, num+2, ...) while they exist in the set.
// - Track the maximum length found.
//
// WHY O(n): Each number is visited at most twice — once in the loop,
// once during counting. Non-starts are skipped in O(1).
//
// TIME: O(n) — each element processed at most twice
// SPACE: O(n) — HashSet stores all elements

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = nums.ToHashSet();  // O(1) lookups

        int maxCount = 0;

        foreach(var num in nums)
        {
            int count = 0;
            if(!set.Contains(num - 1))                // It's the START of a sequence
            {
                count = 1;
                var candidate = num;
                while(set.Contains(num + count)) count++;  // Count forward
            }

            if(maxCount < count) maxCount = count;    // Update max
        }

        return maxCount;
    }
}
