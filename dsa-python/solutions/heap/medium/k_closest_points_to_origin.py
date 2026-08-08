# 973. K Closest Points to Origin
# https://leetcode.com/problems/k-closest-points-to-origin/
#
# Given an array of points where points[i] = [xi, yi] represents a point on
# the X-Y plane and an integer k, return the k closest points to the origin (0, 0).
# The distance between two points on the X-Y plane is the Euclidean distance
# (sqrt(x^2 + y^2)). You may return the answer in any order.
#
# Example 1: Input: points = [[1,3],[-2,2]], k = 1 Output: [[-2,2]]
# Example 2: Input: points = [[3,3],[5,-1],[-2,4]], k = 2 Output: [[3,3],[-2,4]]
#
# Constraints:
# - 1 <= k <= points.length <= 10^4
# - -10^4 <= xi, yi <= 10^4

# APPROACH: Max-heap of size k (keep k closest points)
# Use negative distance as priority in min-heap to simulate max-heap.
# For each point, push to heap. If size > k, pop the farthest (max distance).
# Result: heap holds the k closest points.
#
# TIME: O(n log k) — push/pop is O(log k) for each of n points
# SPACE: O(k) for the heap

import heapq
class KClosestPointsToOrigin:
    def k_closest(self, points: list[list[int]], k: int) -> list[list[int]]:
        heap = []

        for i, row in enumerate(points):
            dist = row[0]*row[0] + row[1]*row[1]  # x² + y² (no sqrt needed)
            heapq.heappush(heap, (-dist, i, row))  # i as tiebreaker for equal distances we are adding as tuple and tuple will be compared value by value
            if len(heap) > k:
                heapq.heappop(heap)  # evict farthest

        return [point for (_, _, point) in heap] #only need last value of tuple
