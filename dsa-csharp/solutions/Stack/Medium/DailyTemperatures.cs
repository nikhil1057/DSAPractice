// 739. Daily Temperatures
// https://leetcode.com/problems/daily-temperatures/
//
// Given an array of integers temperatures represents the daily temperatures,
// return an array answer such that answer[i] is the number of days you have to wait
// after the ith day to get a warmer temperature. If there is no future day for which
// this is possible, keep answer[i] == 0 instead.
//
// CATEGORY: Stack (Medium)
//
// HINTS:
// - Use a monotonic decreasing stack of indices.
// - Iterate through temperatures. For each temp, pop indices from the stack
//   while the current temp is greater than the temp at the stack's top index.
// - For each popped index, the answer is current_index - popped_index.
//
// TIME: O(n) — each element is pushed/popped at most once
// SPACE: O(n) — stack space

public class DailyTemperatures
{
    public int[] DailyTemperaturesMethod(int[] temperatures)
    {
        // TODO: Implement using a monotonic stack
        throw new NotImplementedException();
    }
}
