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
// HINTS:
// - Find the middle of the list using slow/fast pointers.
// - Reverse the second half of the list.
// - Merge the two halves by alternating nodes.
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
        // TODO: Implement using find middle + reverse + merge
        throw new NotImplementedException();
    }
}
