// 853. Car Fleet
// https://leetcode.com/problems/car-fleet/
//
// There are n cars going to the same destination along a one-lane road.
// The destination is target miles away. You are given two integer arrays position and speed,
// where position[i] is the position of the ith car and speed[i] is the speed of the ith car.
//
// A car can never pass another car ahead of it, but it can catch up and then travel at the
// same speed. A car fleet is some non-empty set of cars driving at the same position and speed.
// A single car is also a car fleet.
//
// Return the number of car fleets that will arrive at the destination.
//
// APPROACH: Sort cars by position, iterate from closest to target.
// If a car takes more time than the fleet ahead, it's a new fleet.
// If it takes less/equal time, it merges into the fleet ahead.
//
// TIME: O(n log n) — sorting dominates
// SPACE: O(n) — stack space (or O(1) with counter approach)

public class CarFleet
{
    public int CarFleetMethod(int target, int[] position, int[] speed)
    {
        // Sort both arrays by position (ascending), then iterate in reverse
        Array.Sort(position, speed);

        // ========== APPROACH 1: Stack ==========
        var stack = new Stack<double>();

        for (int i = position.Length - 1; i >= 0; i--)
        {
            double time = (double)(target - position[i]) / speed[i];

            if (stack.Count == 0 || time > stack.Peek())
                stack.Push(time);  // new fleet — slower than fleet ahead
            // else: merges into fleet ahead, don't push
        }

        return stack.Count;

        // ========== APPROACH 2: Counter (no stack needed) ==========
        // int fleets = 0;
        // double maxTime = 0;
        //
        // for (int i = position.Length - 1; i >= 0; i--)
        // {
        //     double time = (double)(target - position[i]) / speed[i];
        //
        //     if (time > maxTime)
        //     {
        //         fleets++;        // new fleet — slower than everything ahead
        //         maxTime = time;
        //     }
        //     // else: faster car, will merge into fleet ahead
        // }
        //
        // return fleets;
    }
}
