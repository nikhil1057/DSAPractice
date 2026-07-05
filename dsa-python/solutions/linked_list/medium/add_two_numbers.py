from solutions import ListNode


# 2. Add Two Numbers
# https://leetcode.com/problems/add-two-numbers/
#
# APPROACH: Digit-by-digit addition with carry (like adding on paper).
#
# WHY reverse order helps: Digits are stored ones-place first, so we can
# just iterate from the head and add digit by digit — no need to reverse.
#
# WHY dummy node: We don't know the first digit of the result upfront.
# Dummy lets us build the list without special-casing the head.
#
# WHY carry != 0 in the loop condition: Handles cases like 99 + 1 = 100
# where the final carry creates an extra digit.
#
# TIME: O(max(n, m)) — one pass through both lists
# SPACE: O(max(n, m)) — the result list

class AddTwoNumbers:
    def add_two_numbers(self, l1: ListNode | None, l2: ListNode | None) -> ListNode | None:
        # Dummy node = placeholder so we don't need to handle head separately
        dummy = ListNode(0)
        curr = dummy
        carry = 0

        # Keep going while there are digits left OR there's a carry to process
        while(l1 is not None or l2 is not None or carry != 0):
            # Start with carry from previous digit's addition
            sum = carry

            # Add digit from l1 if available, move l1 forward
            if(l1 is not None): 
                sum += l1.val
                l1 = l1.next
            # Add digit from l2 if available, move l2 forward
            if(l2 is not None): 
                sum += l2.val
                l2 = l2.next

            # Integer division: carry is 0 or 1 (max sum = 9+9+1 = 19)
            carry = sum//10
            # Modulo: the digit we keep (e.g., 15 % 10 = 5)
            curr.next = ListNode(sum % 10)
            curr = curr.next

        # Skip dummy, return actual result
        return dummy.next
