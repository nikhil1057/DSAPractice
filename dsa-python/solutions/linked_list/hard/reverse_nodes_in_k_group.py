# 25. Reverse Nodes in k-Group
# https://leetcode.com/problems/reverse-nodes-in-k-group/
#
# Given the head of a linked list, reverse the nodes of the list k at a time,
# and return the modified list.
#
# k is a positive integer and is less than or equal to the length of the linked list.
# If the number of nodes is not a multiple of k then left-out nodes, in the end,
# should remain as it is.
#
# APPROACH: Iteratively process k nodes at a time.
# 1. Check if k nodes exist ahead (if not, done — return dummy.next)
# 2. Reverse k nodes
# 3. Reconnect: prev_group_end → new head, old head (now tail) → next group start
# 4. Move slow to the new tail, repeat
#
# EXAMPLE: 1→2→3→4→5, k=2
#
# Initial:  dummy → 1 → 2 → 3 → 4 → 5
#           slow=dummy, fast moves 2 steps to node 2
#
# Group 1:  start_of_this_group=1, next_group_start=3
#           reverse(1→2): 2→1→null (1.next now points to null, 2 is new head)
#           slow.next = 2:                  dummy → 2 → 1    (reconnect prev_group_end to new head)
#           start_of_this_group.next = 3:   dummy → 2 → 1 → 3 → 4 → 5  (old head connects to next group)
#           ↑ THIS is where 1→3 reconnects (the 2→3 link broke during reverse)
#           slow = 1 (move to new tail)
#
# Group 2:  slow=1, fast moves 2 steps to node 4
#           start_of_this_group=3, next_group_start=5
#           reverse(3→4): 4→3→null
#           slow.next = 4:                  ... 1 → 4 → 3    (reconnect)
#           start_of_this_group.next = 5:   ... 1 → 4 → 3 → 5  (3→5 reconnects, 4→5 broke during reverse)
#           slow = 3
#
# Group 3:  slow=3, fast moves but hits None after 1 step → fewer than k, DONE!
#
# Result: dummy → 2 → 1 → 4 → 3 → 5
#
# TIME: O(n) — each node is visited a constant number of times
# SPACE: O(1) — iterative approach

from solutions import ListNode


class ReverseNodesInKGroup:
    def reverse_k_group(self, head: ListNode | None, k: int) -> ListNode | None:
        dummy = ListNode(0)
        dummy.next = head
        slow = dummy  # prev_group_end — always points to node before current group

        while True:
            # Check if k nodes exist ahead
            fast = slow
            for i in range(k):
                fast = fast.next
                if not fast:
                    return dummy.next  # fewer than k remain, done!

            # Save boundaries before reversing
            start_of_this_group = slow.next       # will become tail after reverse
            next_group_start = fast.next          # first node of next group

            # Reverse k nodes starting from slow.next
            slow.next = self._reverse(slow.next, k)  # connect prev_group_end to new head

            # Reconnect: old head (now tail) → next group
            start_of_this_group.next = next_group_start

            # Move slow to the new tail (which is start_of_this_group)
            slow = start_of_this_group

    def _reverse(self, head: ListNode | None, k: int):
        prev = None
        curr = head
        for i in range(k):
            next_node = curr.next
            curr.next = prev
            prev = curr
            curr = next_node
        return prev  # new head of reversed group
