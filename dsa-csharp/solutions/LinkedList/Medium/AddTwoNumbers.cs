// 2. Add Two Numbers
// https://leetcode.com/problems/add-two-numbers/
//
// You are given two non-empty linked lists representing two non-negative integers.
// The digits are stored in reverse order, and each node contains a single digit.
// Add the two numbers and return the sum as a linked list.
//
// APPROACH: Digit-by-digit addition with carry (like how we add numbers on paper)
// 
// WHY reverse order helps: Since digits are already reversed (ones place first),
// we can just iterate from the head and add digit by digit — no need to reverse anything.
//
// WHY dummy node: We don't know what the first digit of the result will be upfront.
// A dummy node lets us build the list without special-casing the head.
//
// TIME: O(max(n, m)) — one pass through both lists
// SPACE: O(max(n, m)) — the result list

public class AddTwoNumbers
{
    public ListNode? AddTwoNumbersSolution(ListNode? l1, ListNode? l2)
    {
        // Dummy node acts as a placeholder so we don't have to handle head separately
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        int carry = 0;

        // Keep going as long as there are digits left in either list OR there's a carry
        // (e.g., 99 + 1 = 100 — the final carry creates an extra digit)
        while(l1 != null || l2 != null || carry != 0)
        {
            // Start with the carry from previous addition
            int sum = carry;

            // Add digit from l1 if available, then move l1 forward
            if(l1 != null) { sum += l1.val; l1 = l1.next;}

            // Add digit from l2 if available, then move l2 forward
            if(l2 != null) { sum += l2.val; l2 = l2.next;}

            // carry = how much to pass to the next digit (0 or 1, since max sum = 9+9+1 = 19)
            carry = sum / 10;

            // sum % 10 = the digit we keep for this position (e.g., 15 % 10 = 5)
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        // Skip the dummy node and return the actual result
        return dummy.next;
    }
}
