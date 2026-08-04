// 143. Reorder List
// https://leetcode.com/problems/reorder-list/
//
// You are given the head of a singly linked-list.
// The list can be represented as: L0 → L1 → … → Ln-1 → Ln
// Reorder the list to be on the following form:
// L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → …
// You may not modify the values in the list's nodes. Only nodes themselves may be changed.
//
// CATEGORY: Linked List (Medium)
//
// APPROACH: Three steps:
// 1. Find middle using slow/fast pointers
// 2. Reverse the second half (save reference BEFORE cutting)
// 3. Cut the list (slow.next = null) to separate the two halves
// 4. Merge two halves alternating (interleave)
//
// TIME: O(n) — three passes (find middle, reverse, merge)
// SPACE: O(1) — in-place modification

public class ReorderList
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public void ReorderListMethod(ListNode? head)
    {
        var slow = head;
        var fast = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var second = Reverse(slow.next);
        slow.next = null;  // Cut the list in two halves

        //Merge Two Linked List Alternatively
        var first = head;
        while(second != null)
        {
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }

    private ListNode Reverse(ListNode? head)
    {
        ListNode? next = null;
        ListNode? prev = null;
        ListNode? current = head;

        while(current != null)
        {
            next = current.next; // Save the rest of the list
            current.next = prev; // Reverse: point backwards
            prev = current; // Move prev forward
            current = next; // Move to next node
        }

        return prev;
    }
}
