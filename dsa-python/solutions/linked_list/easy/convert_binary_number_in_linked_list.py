from solutions import ListNode


# 1290. Convert Binary Number in a Linked List to Integer
# https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
#
# APPROACH: Bitwise left shift + OR to build the decimal value bit by bit.
#
# KEY INSIGHT: As we read bits left to right (MSB to LSB), each new bit means
# the previous result must shift left (make room) and we OR in the new bit.
#
# HOW IT WORKS step by step for 1→0→1:
#   result = (0 << 1) | 1 = 1   (decimal 1)
#   result = (1 << 1) | 0 = 2   (decimal 2)
#   result = (2 << 1) | 1 = 5   (decimal 5) ✓
#
# WHY << 1: Left shift = multiply by 2 = "move all existing bits one position
# left to make room for the next bit in the ones place."
#
# WHY | val: OR sets the lowest bit to the new digit. Since shifting always
# fills the lowest bit with 0, OR safely places our new bit there.
#
# TIME: O(n) — single pass through the list
# SPACE: O(1) — just one integer variable

class ConvertBinaryNumberInLinkedList:
    def get_decimal_value(self, head: ListNode | None) -> int:
        result = 0

        while head:
            # Shift existing bits left (make room) then place new bit
            result = (result << 1) | head.val
            head = head.next

        return result
