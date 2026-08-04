// 19. Remove Nth Node From End of List
// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
//
// Given the head of a linked list, remove the nth node from the end of the list
// and return its head.
//
// CATEGORY: Linked List (Medium)
//
// APPROACH: Two pointers with a gap of n between them.
// 1. Use a dummy node (handles edge case of removing head)
// 2. Move fast pointer n steps ahead
// 3. Move both until fast reaches end
// 4. slow is now just before the node to remove → skip it
//
// TIME: O(n) — single pass
// SPACE: O(1) — constant extra space

public class RemoveNthNodeFromEndOfList
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

    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        ListNode? fast = head;
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        for(int i = 0; i < n; i++) fast = fast.next;

        ListNode slow = dummy;
        while(fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}
