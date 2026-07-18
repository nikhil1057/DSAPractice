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
// CATEGORY: Stack (Medium)
//
// HINTS:
// - Sort cars by position in descending order.
// - Calculate time to reach target for each car: (target - position) / speed.
// - Use a stack. If current car's time > stack top, it forms a new fleet (push).
// - If current car's time <= stack top, it joins the fleet ahead (don't push).
//
// TIME: O(n log n) — sorting dominates
// SPACE: O(n) — stack space

public class CarFleet
{
    public int CarFleetMethod(int target, int[] position, int[] speed)
    {
        // TODO: Implement using a monotonic stack
        throw new NotImplementedException();
    }
}
