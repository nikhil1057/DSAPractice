from solutions import ListNode


# 206. Reverse Linked List
# https://leetcode.com/problems/reverse-linked-list/
#
# APPROACH: Three-pointer iterative reversal.
#
# KEY INSIGHT: To reverse a linked list, we flip each node's `next` pointer
# to point backwards instead of forwards. We need three pointers to do this
# without losing track of the rest of the list.
#
# HOW IT WORKS:
#   prev = the already-reversed portion (starts as None)
#   curr = the node we're currently processing
#   next = saved reference to the rest of the list (so we don't lose it)
#
# Each iteration:
#   1. Save next (curr.next) before we break the link
#   2. Reverse the pointer: curr.next = prev
#   3. Move prev forward to curr
#   4. Move curr forward to next
#
# WALKTHROUGH for [1 → 2 → 3]:
#   Start:  prev=None, curr=1
#   Step 1: next=2, 1.next=None, prev=1, curr=2     → None ← 1  2 → 3
#   Step 2: next=3, 2.next=1,    prev=2, curr=3     → None ← 1 ← 2  3
#   Step 3: next=None, 3.next=2, prev=3, curr=None  → None ← 1 ← 2 ← 3
#   Return prev (node 3) = new head
#
# TIME: O(n) — visit each node once
# SPACE: O(1) — just three pointers

class ReverseLinkedList:
    def reverse_list(self, head: ListNode | None) -> ListNode | None:
        next, prev = None, None
        curr = head

        while curr:
            next = curr.next      # Save the rest of the list
            curr.next = prev      # Reverse: point backwards
            prev = curr           # Move prev forward
            curr = next           # Move to next node
        
        head = prev  # prev is now the new head (last node of original)

        return head
