from solutions import ListNode


# 234. Palindrome Linked List
# https://leetcode.com/problems/palindrome-linked-list/
#
# APPROACH: Find middle → Reverse second half → Compare both halves.
#
# KEY INSIGHT: A palindrome reads the same forwards and backwards.
# If we reverse the second half, it should match the first half node by node.
#
# STEPS:
# 1. Find the middle using slow/fast pointer.
# 2. Reverse the list from the middle onwards.
# 3. Compare first half (from head) with reversed second half.
# 4. If all nodes match → palindrome.
#
# WHY this works for odd length [1,2,3,2,1]:
#   Middle = 3, reverse from 3 → [1,2,3] and [1,2,3]
#   Compare: 1==1 ✓, 2==2 ✓, middle doesn't matter → palindrome!
#
# WHY this works for even length [1,2,2,1]:
#   Middle = second 2, reverse from there → [1,2] and [1,2]
#   Compare: 1==1 ✓, 2==2 ✓ → palindrome!
#
# TIME: O(n) — find middle O(n) + reverse O(n/2) + compare O(n/2)
# SPACE: O(1) — all done in-place with pointer manipulation

class PalindromeLinkedList:
    def is_palindrome(self, head: ListNode | None) -> bool:
        if head is None:
            return False
        if head.next is None:
            return True

        # Step 1: Find the middle node
        middle = self._middle_node(head)

        # Step 2: Reverse the second half starting from middle
        reversed_half = self._reverse(middle)

        # Step 3: Compare first half with reversed second half
        curr = head
        while reversed_half is not None and curr is not None:
            if curr.val != reversed_half.val:
                return False
            curr = curr.next
            reversed_half = reversed_half.next

        return True

    def _middle_node(self, head: ListNode | None) -> ListNode | None:
        """Find middle using slow/fast pointer."""
        slow, fast = head, head
        while fast is not None and fast.next is not None:
            slow = slow.next
            fast = fast.next.next
        return slow

    def _reverse(self, head: ListNode | None) -> ListNode | None:
        """Reverse a linked list and return new head."""
        prev = None
        curr = head
        while curr:
            next_node = curr.next
            curr.next = prev
            prev = curr
            curr = next_node
        return prev
