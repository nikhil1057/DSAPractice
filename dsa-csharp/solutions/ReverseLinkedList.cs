// 206. Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list/
//
// APPROACH: Three-pointer iterative reversal.
//
// KEY INSIGHT: Flip each node's `next` pointer to point backwards.
// We need three pointers so we don't lose track of the rest of the list.
//
// HOW IT WORKS:
//   prev = the already-reversed portion (starts as null)
//   current = the node we're currently processing
//   next = saved reference to the rest of the list
//
// Each iteration:
//   1. Save next (current.next) before we break the link
//   2. Reverse the pointer: current.next = prev
//   3. Move prev forward to current
//   4. Move current forward to next
//
// WALKTHROUGH for [1 → 2 → 3]:
//   Start:  prev=null, current=1
//   Step 1: next=2, 1.next=null, prev=1, current=2     → null ← 1  2 → 3
//   Step 2: next=3, 2.next=1,    prev=2, current=3     → null ← 1 ← 2  3
//   Step 3: next=null, 3.next=2, prev=3, current=null  → null ← 1 ← 2 ← 3
//   Return prev (node 3) = new head
//
// TIME: O(n) — visit each node once
// SPACE: O(1) — just three pointers

public class ReverseLinkedList
{
    public ListNode? ReverseList(ListNode? head)
    {
        ListNode? next = null;
        ListNode? prev = null;
        ListNode? current = head;

        while(current != null)
        {
            next = current.next;     // Save the rest of the list
            current.next = prev;     // Reverse: point backwards
            prev = current;          // Move prev forward
            current = next;          // Move to next node
        }

        head = prev;  // prev is now the new head (last node of original)

        return head;
    }
}
