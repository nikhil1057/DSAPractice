// 875. Koko Eating Bananas
// https://leetcode.com/problems/koko-eating-bananas/
//
// Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas.
// The guards have gone and will come back in h hours.
//
// Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile
// and eats k bananas from that pile. If the pile has less than k bananas, she eats all of
// them and will not eat any more bananas during this hour.
//
// Return the minimum integer k such that she can eat all the bananas within h hours.
//
// CATEGORY: Binary Search (Medium)
//
// HINTS:
// - Binary search on the answer (eating speed k).
// - Search range: 1 to max(piles).
// - For a given k, calculate hours needed: sum(ceil(pile/k) for pile in piles).
// - If hours <= h, try smaller k. Otherwise, try larger k.
//
// TIME: O(n * log(max(piles))) — binary search over speeds, linear check each
// SPACE: O(1) — constant extra space

public class KokoEatingBananas
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        // TODO: Implement using binary search on answer
        throw new NotImplementedException();
    }
}
