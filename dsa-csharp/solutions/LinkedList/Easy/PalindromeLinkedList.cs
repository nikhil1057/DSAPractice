// 234. Palindrome Linked List
// https://leetcode.com/problems/palindrome-linked-list/
//
// APPROACH: Find middle → Reverse second half → Compare both halves.
//
// KEY INSIGHT: A palindrome reads the same forwards and backwards.
// If we reverse the second half, it should match the first half node by node.
//
// STEPS:
// 1. Find the middle using slow/fast pointer.
// 2. Reverse the list from the middle onwards.
// 3. Compare first half (from head) with reversed second half.
// 4. If all nodes match → palindrome.
//
// WHY this works for odd length [1,2,3,2,1]:
//   Middle = 3, reverse from 3 → [1,2,3] and [1,2,3]
//   Compare: 1==1 ✓, 2==2 ✓, reversed half ends first → palindrome!
//
// WHY this works for even length [1,2,2,1]:
//   Middle = second 2, reverse from there → [1,2] and [1,2]
//   Compare: 1==1 ✓, 2==2 ✓ → palindrome!
//
// TIME: O(n) — find middle O(n) + reverse O(n/2) + compare O(n/2)
// SPACE: O(1) — all done in-place with pointer manipulation

public class PalindromeLinkedList
{
    public bool IsPalindrome(ListNode? head)
    {
        if(head == null) return false;

        // Single node is always a palindrome
        if(head.next == null) return true;

        // Step 1: Find middle node using slow/fast
        var middleNode = MiddleNode(head);

        // Step 2: Reverse the second half
        var middle = ReverseLinkedList(middleNode);

        // Step 3: Compare first half with reversed second half
        var current = head;
        while(middle != null && current != null)
        {
            if(middle.val != current.val) return false;
            
            current = current.next;
            middle = middle.next;
        }
        
        return true;
    }

    // Slow/fast pointer to find the middle node
    private ListNode MiddleNode(ListNode? head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    // Reverse a linked list — classic three-pointer technique
    // prev tracks the already-reversed portion
    // current is the node we're processing
    // next saves the rest of the list before we rewire
    private ListNode? ReverseLinkedList(ListNode? head)
    {
        ListNode? next = null;
        ListNode? prev = null;
        ListNode? current = head;

        while(current != null)
        {
            next = current.next;     // Save next node
            current.next = prev;     // Reverse pointer
            prev = current;          // Move prev forward
            current = next;          // Move to next node
        }

        head = prev;

        return head;
    }
}
