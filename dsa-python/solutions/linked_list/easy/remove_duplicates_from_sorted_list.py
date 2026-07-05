from solutions import ListNode


# 83. Remove Duplicates from Sorted List
# https://leetcode.com/problems/remove-duplicates-from-sorted-list/
#
# Given head of a sorted linked list, delete all duplicates such that
# each element appears only once. Return the sorted list.
#
# APPROACH: Single pointer — compare each node with its next neighbor.
#
# WHY it works: Since the list is SORTED, all duplicates are adjacent.
# We just check: does current.val == current.next.val?
# If yes → skip the next node. If no → move forward.
#
# WHY we don't move forward when removing: After skipping a duplicate,
# the new `curr.next` might ALSO be a duplicate (e.g., [1,1,1]).
# So we stay at `curr` and check again.
#
# TIME: O(n) — visit each node once
# SPACE: O(1) — in-place, no extra memory

class RemoveDuplicatesFromSortedList:
    def delete_duplicates(self, head: ListNode | None) -> ListNode | None:
        # Edge case: empty list or single node — nothing to deduplicate
        if head is None or head.next is None:
            return head
        
        curr = head

        while curr.next is not None:
            if curr.val == curr.next.val:
                # Duplicate! Skip the next node.
                # DON'T advance curr — new next might also be a duplicate.
                curr.next = curr.next.next
            else:
                # No duplicate — safe to move forward
                curr = curr.next
        
        return head


# 82. Remove Duplicates from Sorted List II
# https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
#
# Given head of sorted linked list, delete ALL nodes that have duplicate numbers.
# Leave only distinct numbers. Return the sorted list.
#
# DIFFERENCE FROM PROBLEM 83: In #83 we keep one copy. Here we remove ALL copies.
# If a number appeared more than once, it's gone completely.
#
# APPROACH: Dummy node + two pointers (prev and head).
#
# WHY dummy node: The head itself might need to be removed (e.g., [1,1,2]).
# Dummy gives us a safe anchor before the head.
#
# HOW IT WORKS:
# 1. `prev` = last confirmed unique node.
# 2. `head` scans forward. If head has duplicates (head.val == head.next.val),
#    skip ALL nodes with that value.
# 3. After skipping, check if prev.next == head:
#    - YES → head had no duplicates, advance prev.
#    - NO → head was part of a duplicate group, skip them all (prev.next = head.next).
#
# TIME: O(n) — single pass
# SPACE: O(1) — in-place

class RemoveDuplicatesFromSortedListII:
    def delete_duplicates(self, head: ListNode | None) -> ListNode | None:
        # Edge case: empty list or single node
        if head is None or head.next is None:
            return head
        
        # Dummy node protects against removing the original head
        dummy = ListNode(0)
        dummy.next = head
        prev = dummy  # prev = last node we're sure is unique

        while(head is not None):
            # Skip ALL nodes that share the same value as current head
            # After this, head is at the LAST node of the duplicate group
            while(head.next is not None and head.val == head.next.val):
                head = head.next

            # Did prev.next move? If prev.next is still head,
            # NO duplicates were found — head is unique, advance prev.
            if(prev.next is head):
                prev = head
            
            else:
                # Duplicates were found — skip the entire duplicate group.
                # Connect prev to the node AFTER the last duplicate.
                prev.next = head.next

            # Move head forward to process the next node
            head = head.next

        return dummy.next
