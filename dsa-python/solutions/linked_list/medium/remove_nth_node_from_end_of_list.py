# 19. Remove Nth Node From End of List
# https://leetcode.com/problems/remove-nth-node-from-end-of-list/
#
# Given the head of a linked list, remove the nth node from the end of the list
# and return its head.
#
# CATEGORY: Linked List (Medium)
#
# HINTS:
# - Use two pointers with a gap of n between them.
# - Advance the first pointer n steps ahead.
# - Then move both pointers until the first reaches the end.
# - The second pointer will be just before the node to remove.
# - Use a dummy node to handle edge cases (removing the head).
#
# TIME: O(n) — single pass
# SPACE: O(1) — constant extra space

from solutions import ListNode


class RemoveNthNodeFromEndOfList:
    def remove_nth_from_end(self, head: ListNode | None, n: int) -> ListNode | None:
        # TODO: Implement using two pointers with gap of n
        pass
