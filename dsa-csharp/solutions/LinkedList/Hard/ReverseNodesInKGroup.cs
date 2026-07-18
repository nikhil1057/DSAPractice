// 25. Reverse Nodes in k-Group
// https://leetcode.com/problems/reverse-nodes-in-k-group/
//
// Given the head of a linked list, reverse the nodes of the list k at a time,
// and return the modified list.
//
// k is a positive integer and is less than or equal to the length of the linked list.
// If the number of nodes is not a multiple of k then left-out nodes, in the end,
// should remain as it is.
//
// You may not alter the values in the list's nodes, only nodes themselves may be changed.
//
// CATEGORY: Linked List (Hard)
//
// HINTS:
// - Count k nodes ahead. If fewer than k remain, don't reverse.
// - Reverse k nodes iteratively.
// - Recursively (or iteratively) process the rest of the list.
// - Connect the reversed group to the next group's result.
//
// TIME: O(n) — each node is visited a constant number of times
// SPACE: O(1) — iterative approach (O(n/k) if recursive)

public class ReverseNodesInKGroup
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

    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        // TODO: Implement by reversing k nodes at a time
        throw new NotImplementedException();
    }
}
