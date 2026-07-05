// 141. Linked List Cycle
// https://leetcode.com/problems/linked-list-cycle/
//
// APPROACH: Floyd's Tortoise and Hare (two pointers at different speeds)
//
// KEY INSIGHT: If there's a cycle, a fast pointer (2 steps) will eventually
// "lap" a slow pointer (1 step) and they'll meet inside the cycle.
// If there's no cycle, fast reaches null and we return false.
//
// WHY it works: On a circular track, a runner going 2x speed will eventually
// catch the slower one from behind. The gap closes by 1 each iteration.
//
// WHY check fast AND fast.next: fast moves 2 steps, so both must be non-null
// to avoid null reference on fast.next.next.
//
// TIME: O(n) — fast enters cycle and catches slow in at most n steps
// SPACE: O(1) — just two pointers (no HashSet needed!)

public class LinkedListCycle
{
    public bool HasCycle(ListNode? head)
    {
        // Both start at head
        var slow = head;
        var fast = head;

        // fast moves 2 steps, slow moves 1 step
        while(fast != null && fast.next != null)
        {
            slow = slow.next;       // 1 step
            fast = fast.next.next;  // 2 steps

            // If they meet, there's a cycle
            if(slow == fast) return true;
        }

        // fast reached the end — no cycle exists
        return false;
    }
}
