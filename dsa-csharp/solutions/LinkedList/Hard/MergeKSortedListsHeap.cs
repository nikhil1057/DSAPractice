// 23. Merge k Sorted Lists (Min-Heap approach)
// https://leetcode.com/problems/merge-k-sorted-lists/
//
// APPROACH: Min-Heap (Priority Queue) — always pick the smallest head.
//
// KEY INSIGHT: At any point, the next node in the merged result must be
// the smallest among all current heads of the k lists. A min-heap lets
// us find that smallest in O(log k) instead of scanning all k heads.
//
// STEPS:
// 1. Push the head of each non-null list into a PriorityQueue.
// 2. Dequeue the smallest node, attach it to the result.
// 3. If that node has a .next, enqueue it.
// 4. Repeat until queue is empty.
//
// C# PriorityQueue<TElement, TPriority>:
//   - Enqueue(node, node.val) → O(log k)
//   - Dequeue()               → O(log k), returns smallest priority
//   - Count                   → O(1)
//
// TIME: O(N * log k) — N nodes total, each Enqueue/Dequeue is O(log k)
// SPACE: O(k) — heap holds at most k nodes at any time

public class MergeKSortedListsHeap
{
    public ListNode? MergeKLists(ListNode?[] lists)
    {
        // 1. Create a min-heap prioritized by node value
       var minHeap = new PriorityQueue<ListNode, int>();

        // 2. Push the head of each non-null list
       foreach(var heads in lists)
        {
            if(heads != null)
            minHeap.Enqueue(heads, heads.val);
        }
        // 3. Build result using dummy node
        ListNode dummy = new ListNode(0);
        var curr = dummy;
        // 4. Pop smallest, attach to result, push its .next
        while(minHeap.Count > 0)
        {
            var node = minHeap.Dequeue();
            curr.next = node;
            curr = curr.next;

            if(node.next != null)
            {
                minHeap.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}
