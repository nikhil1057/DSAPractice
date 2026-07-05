from solutions import ListNode


# 876. Middle of the Linked List
# https://leetcode.com/problems/middle-of-the-linked-list/
#
# APPROACH: Slow/Fast pointer (Floyd's technique)
#
# KEY INSIGHT: If slow moves 1 step and fast moves 2 steps, when fast reaches
# the end, slow is at the middle. Fast covers the list in half the iterations.
#
# WHY check `fast` AND `fast.next`: fast moves 2 steps, so both must be non-None.
# - Odd list [1,2,3,4,5]: fast ends at node 5 (not None), slow at node 3 ✓
# - Even list [1,2,3,4,5,6]: fast ends past the list (None), slow at node 4 ✓
#   (returns the SECOND middle as LeetCode requires)
#
# WHY NOT `fast.next and fast.next.next`: That stops one step too early on
# even-length lists, returning the first middle instead of the second.
#
# TIME: O(n) — single pass (slow visits n/2 nodes, fast visits n nodes)
# SPACE: O(1) — just two pointers

class MiddleOfTheLinkedList:
    def middle_node(self, head: ListNode | None) -> ListNode | None:
        slow, fast = head, head

        # fast moves 2x speed — when it reaches end, slow is at middle
        while(fast is not None and fast.next is not None):
            slow = slow.next
            fast = fast.next.next

        return slow
