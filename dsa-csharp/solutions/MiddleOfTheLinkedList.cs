// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/
//
// APPROACH: Slow/Fast pointer (Floyd's technique)
//
// KEY INSIGHT: If slow moves 1 step and fast moves 2 steps, when fast reaches
// the end, slow is at the middle. Fast covers the list in half the iterations.
//
// WHY check `fast` AND `fast.next`: fast moves 2 steps, so both must be non-null.
// - Odd list [1,2,3,4,5]: fast ends at node 5, slow at node 3 ✓
// - Even list [1,2,3,4,5,6]: fast ends past the list (null), slow at node 4 ✓
//   (returns the SECOND middle as LeetCode requires)
//
// TIME: O(n) — single pass (slow visits n/2 nodes, fast visits n nodes)
// SPACE: O(1) — just two pointers

public class MiddleOfTheLinkedList
{
    public ListNode? MiddleNode(ListNode? head)
    {
        var slow = head;
        var fast = head;

        // fast moves 2x speed — when it reaches end, slow is at middle
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}
