// 703. Kth Largest Element in a Stream
// https://leetcode.com/problems/kth-largest-element-in-a-stream/
//
// Design a class to find the kth largest element in a stream. Note that it is
// the kth largest element in the sorted order, not the kth distinct element.
//
// Implement KthLargest class:
// - KthLargest(int k, int[] nums) Initializes the object with the integer k
//   and the stream of integers nums.
// - int Add(int val) Appends the integer val to the stream and returns the
//   element representing the kth largest element in the stream.
//
// Example 1:
//   Input: ["KthLargest", "add", "add", "add", "add", "add"]
//          [[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
//   Output: [null, 4, 5, 5, 8, 8]
//
// Constraints:
// - 1 <= k <= 10^4
// - 0 <= nums.length <= 10^4
// - -10^4 <= nums[i] <= 10^4
// - -10^4 <= val <= 10^4
// - At most 10^4 calls will be made to Add.

// APPROACH: Min-heap of size k
// Keep only the k largest elements in a min-heap. The top (smallest of the k)
// is always the kth largest overall. On add: push, if size > k pop smallest.
//
// TIME: O(n log k) init, O(log k) per Add
// SPACE: O(k) for the heap

public class KthLargestElementInAStream
{
    private PriorityQueue<int,int> _heap;  // min-heap by default
    private int _k;

    public KthLargestElementInAStream(int k, int[] nums)
    {
        _k = k;
        _heap = new PriorityQueue<int, int>();

        foreach(int num in nums)
        {
            _heap.Enqueue(num, num);
            if(_heap.Count > _k) _heap.Dequeue();  // evict smallest, keep top k
        }
    }

    public int Add(int val)
    {
        _heap.Enqueue(val, val);
        if(_heap.Count > _k) _heap.Dequeue();  // maintain size k
        return _heap.Peek();  // top of min-heap = kth largest
    }
}
