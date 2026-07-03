from solutions import ListNode


# 203. Remove Linked List Elements
# https://leetcode.com/problems/remove-linked-list-elements/
#
# Remove all nodes from linked list that have value == val.
#
# APPROACH: Dummy node + single pointer checking curr.next.
#
# WHY dummy node: The head itself might need to be removed (e.g., [7,7,7,1], val=7).
# Dummy gives us a safe node before head so we don't special-case head removal.
#
# WHY check curr.next (not curr): We need to modify the PREVIOUS node's pointer
# to skip the target. By looking ahead at curr.next, we can do curr.next = curr.next.next.
#
# WHY not advance when removing: After skipping a node, the new curr.next might
# ALSO have val (e.g., [1,2,2,3], val=2). So we stay and check again.
# Only advance (else) when curr.next is safe.
#
# TIME: O(n) — visit each node once
# SPACE: O(1) — in-place, just rewire pointers

class RemoveLinkedListElements:
    def remove_elements(self, head: ListNode | None, val: int) -> ListNode | None:
        # Dummy protects against removing the head
        dummy = ListNode(0)
        dummy.next = head
        curr = dummy

        while curr:
            # Look ahead: if next node has target value, skip it
            if(curr.next is not None and curr.next.val == val):
                curr.next = curr.next.next
            # Otherwise, safe to move forward
            else: 
                curr = curr.next
        
        return dummy.next
