// 739. Daily Temperatures
// https://leetcode.com/problems/daily-temperatures/
//
// Given an array of integers temperatures represents the daily temperatures,
// return an array answer such that answer[i] is the number of days you have to wait
// after the ith day to get a warmer temperature. If there is no future day for which
// this is possible, keep answer[i] == 0 instead.
//
// APPROACH: Monotonic decreasing stack. Stack holds indices of days we haven't
// found a warmer day for yet. When a warmer day comes, it resolves all the
// cooler days waiting on the stack — distance between indices is the answer.
//
// TIME: O(n) — each element is pushed/popped at most once
// SPACE: O(n) — stack space

public class DailyTemperatures
{
    public int[] DailyTemperaturesMethod(int[] temperatures)
    {
        Stack<int> stack = new();  // stores indices of days waiting for a warmer day
        int[] answer = new int[temperatures.Length];  // default 0 means no warmer day found

        for (int i = 0; i < temperatures.Length; i++)
        {
            // If current temp is warmer than what's on top of stack,
            // it means we found the warmer day for those waiting indices
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                int index = stack.Pop();  // this day has been resolved
                answer[index] = i - index;  // distance = how many days waited
            }

            // Push current day — it's waiting for its warmer day
            stack.Push(i);
        }

        // Anything left in stack never found a warmer day → stays 0
        return answer;
    }
}
