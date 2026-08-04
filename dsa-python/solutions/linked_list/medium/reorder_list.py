# 143. Reorder List
# https://leetcode.com/problems/reorder-list/
#
# You are given the head of a singly linked-list.
# The list can be represented as: L0 → L1 → … → Ln-1 → Ln
# Reorder the list to be on the following form:
# L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → …
# You may not modify the values in the list's nodes. Only nodes themselves may be changed.
#
# APPROACH: Three steps:
# 1. Find middle using slow/fast pointers
# 2. Reverse the second half
# 3. Merge two halves alternating (interleave)
#
# TIME: O(n) — three passes (find middle, reverse, merge)
# SPACE: O(1) — in-place modification

from solutions import ListNode


class ReorderList:
    def reorder_list(self, head: ListNode | None) -> None:
        # Step 1: Find middle
        slow, fast = head, head
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next

        # Step 2: Reverse second half
        second = self.reverse(slow.next)
        slow.next = None  # Cut the list in two halves

        # Step 3: Merge alternating
        first = head
        while second:
            temp1 = first.next
            temp2 = second.next
            first.next = second
            second.next = temp1
            first = temp1
            second = temp2

    def reverse(self, head: ListNode | None) -> ListNode:
        prev = None
        curr = head
        while curr:
            next_node = curr.next
            curr.next = prev
            prev = curr
            curr = next_node
        return prev
