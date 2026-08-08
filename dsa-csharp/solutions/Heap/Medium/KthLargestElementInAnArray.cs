// 215. Kth Largest Element in an Array
// https://leetcode.com/problems/kth-largest-element-in-an-array/
//
// Given an integer array nums and an integer k, return the kth largest element
// in the array. Note that it is the kth largest element in the sorted order,
// not the kth distinct element. Can you solve it without sorting?
//
// Example 1: Input: nums = [3,2,1,5,6,4], k = 2 Output: 5
// Example 2: Input: nums = [3,2,3,1,2,4,5,5,6], k = 4 Output: 4
//
// Constraints:
// - 1 <= k <= nums.length <= 10^5
// - -10^4 <= nums[i] <= 10^4

// APPROACH: Min-heap of size k
// Keep only the k largest elements in a min-heap.
// Top of heap = smallest of the k largest = kth largest overall.
//
// TIME: O(n log k) — push/pop is O(log k) for each of n elements
// SPACE: O(k) for the heap

public class KthLargestElementInAnArray
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int,int> heap = new();  // min-heap by default

        foreach(int num in nums)
        {
            heap.Enqueue(num, num);
            if(heap.Count > k) heap.Dequeue();  // evict smallest, keep top k
        }

        return heap.Peek();  // top of min-heap = kth largest
    }
}
