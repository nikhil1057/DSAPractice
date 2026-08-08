// 973. K Closest Points to Origin
// https://leetcode.com/problems/k-closest-points-to-origin/
//
// Given an array of points where points[i] = [xi, yi] represents a point on
// the X-Y plane and an integer k, return the k closest points to the origin (0, 0).
// The distance between two points is the Euclidean distance (sqrt(x^2 + y^2)).
// You may return the answer in any order.
//
// Example 1: Input: points = [[1,3],[-2,2]], k = 1 Output: [[-2,2]]
// Example 2: Input: points = [[3,3],[5,-1],[-2,4]], k = 2 Output: [[3,3],[-2,4]]
//
// Constraints:
// - 1 <= k <= points.length <= 10^4
// - -10^4 <= xi, yi <= 10^4

// APPROACH: Max-heap of size k (keep k closest points)
// Use max-heap (via reversed comparer) so the farthest of the k is at top.
// For each point, push to heap. If size > k, pop the farthest.
// Result: heap holds the k closest points.
//
// TIME: O(n log k) — push/pop is O(log k) for each of n points
// SPACE: O(k) for the heap

public class KClosestPointsToOrigin
{
    public int[][] KClosest(int[][] points, int k)
    {
        // Max-heap: farthest point at top (easiest to evict)
        PriorityQueue<int[],int> heap = new PriorityQueue<int[], int>(Comparer<int>.Create((a,b) => b - a));

        foreach(int[] row in points)
        {
            int dist = row[0] * row[0] + row[1] * row[1];  // x² + y² (no sqrt needed)
            heap.Enqueue(row, dist);
            if(heap.Count > k) heap.Dequeue();  // evict farthest
        }

        // Collect remaining k points
        var result = new int[k][];
        for(int i = 0; i < k; i++)
            result[i] = heap.Dequeue();
        return result;
    }
}
