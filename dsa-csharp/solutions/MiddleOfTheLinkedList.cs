// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/
//
// APPROACH: Two-pass — first count all nodes, then walk to the middle.
//
// HOW IT WORKS:
// 1. First pass: count total number of nodes.
// 2. Second pass: walk count/2 steps from head to reach the middle.
//
// WHY count/2: For odd-length [1,2,3,4,5], count=5, count/2=2 → lands on node 3 (middle).
// For even-length [1,2,3,4,5,6], count=6, count/2=3 → lands on node 4 (second middle).
// This matches LeetCode's requirement: "If two middle nodes, return the second one."
//
// ALTERNATIVE: Slow/fast pointer (one pass). Fast moves 2 steps, slow moves 1.
// When fast reaches end, slow is at middle. Same idea as Floyd's cycle detection.
//
// TIME: O(n) — two passes through the list
// SPACE: O(1) — just a counter and a pointer

public class MiddleOfTheLinkedList
{
    public ListNode? MiddleNode(ListNode? head)
    {
        if(head == null || head.next == null) return head;

        // First pass: count total nodes
        var curr = head;
        int count = 0;

        while(curr != null)
        {
            curr = curr.next;
            count++;
        }

        // Second pass: walk to the middle (count/2 steps from head)
        curr = head;
        int i = 0;

        while(i < count/2)
        {
            curr = curr.next;
            i++;
        }

        return curr;
    }
}
