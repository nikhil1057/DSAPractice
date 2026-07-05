// 83. Remove Duplicates from Sorted List
// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
//
// Given the head of a sorted linked list, delete all duplicates such that
// each element appears only once. Return the linked list sorted as well.
//
// APPROACH: Single pointer — compare each node with its next neighbor.
//
// WHY it works: Since the list is SORTED, all duplicates are adjacent.
// We just need to check if current.val == current.next.val.
// If yes, skip the next node. If no, move forward.
//
// WHY we don't move forward when removing: After skipping a duplicate,
// the new `current.next` might ALSO be a duplicate. So we stay at `current`
// and check again. We only advance when current.next is different.
//
// TIME: O(n) — visit each node once
// SPACE: O(1) — in-place, no extra memory

public class RemoveDuplicatesFromSortedList
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        // Edge case: empty list or single node — no duplicates possible
        if(head == null || head.next == null) return head;

        ListNode current = head;

        while(current.next != null)
        {
            if(current.val == current.next.val)
                // Duplicate found! Skip the next node by pointing to the one after it
                // DON'T move current forward — the new next might also be a duplicate
                current.next = current.next.next;
            else
                // No duplicate — safe to move forward
                current = current.next;
        }

        return head;
    }
}

// 82. Remove Duplicates from Sorted List II
// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
//
// Given the head of a sorted linked list, delete ALL nodes that have duplicate
// numbers, leaving only distinct numbers. Return the linked list sorted as well.
//
// DIFFERENCE FROM PROBLEM 83: In #83 we keep one copy of duplicates.
// Here we remove ALL copies — if a number appeared more than once, remove it entirely.
//
// APPROACH: Dummy node + two pointers (prev and head).
//
// WHY dummy node: The head itself might be a duplicate and need to be removed.
// A dummy node before head gives us a safe anchor — prev always has a valid node
// to connect to when we skip duplicates.
//
// HOW IT WORKS:
// 1. `prev` points to the last confirmed unique node.
// 2. `head` scans forward. If head has duplicates (head.val == head.next.val),
//    we skip ALL nodes with that value.
// 3. After skipping, check if prev.next == head.
//    - YES: head had no duplicates, so advance prev to head.
//    - NO: head was part of a duplicate group, so connect prev.next to head.next (skip all).
//
// TIME: O(n) — single pass
// SPACE: O(1) — in-place

public class RemoveDuplicatesFromSortedListII
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        // Edge case: empty or single node — nothing to remove
        if(head == null || head.next == null) return head;

        // Dummy node protects against removing the head
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy; // prev = last node we're sure is unique

        while(head != null)
        {
            // Skip all nodes that have the same value as head
            // After this loop, head is at the LAST node of the duplicate group
            while(head.next != null && head.val == head.next.val)
            {
                head = head.next;
            }

            // Check: did prev.next move? If prev.next is still head,
            // it means head was NOT part of a duplicate group (no skipping happened)
            if(prev.next == head)
            {
                // No duplicates — this node is unique, advance prev
                prev = head;
            }
            else
            {
                // Duplicates found — skip the entire group
                // Connect prev directly to the node AFTER the duplicate group
                prev.next = head.next;
            }

            // Move head forward to process the next node
            head = head.next;
        }

        return dummy.next;
    }
}
