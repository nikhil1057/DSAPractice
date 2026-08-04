# 19. Remove Nth Node From End of List
# https://leetcode.com/problems/remove-nth-node-from-end-of-list/
#
# Given the head of a linked list, remove the nth node from the end of the list
# and return its head.
#
# APPROACH: Two pointers with a gap of n between them.
# 1. Use a dummy node (handles edge case of removing head)
# 2. Move fast pointer n steps ahead
# 3. Move both until fast reaches end
# 4. slow is now just before the node to remove → skip it
#
# TIME: O(n) — single pass
# SPACE: O(1) — constant extra space

from solutions import ListNode


class RemoveNthNodeFromEndOfList:
    def remove_nth_from_end(self, head: ListNode | None, n: int) -> ListNode | None:
        # Dummy node handles the case when we need to remove the head itself
        dummy = ListNode(0)
        dummy.next = head

        # Move fast n steps ahead
        fast = head
        for i in range(n):
            fast = fast.next

        # Move both until fast reaches end
        slow = dummy
        while fast:
            slow = slow.next
            fast = fast.next

        # slow is now just before the node to remove — skip it
        slow.next = slow.next.next

        # Return dummy.next (not head — head might have been removed)
        return dummy.next
