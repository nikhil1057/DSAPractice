from solutions import ListNode


# 141. Linked List Cycle
# https://leetcode.com/problems/linked-list-cycle/
#
# APPROACH: Floyd's Tortoise and Hare (two pointers at different speeds)
#
# KEY INSIGHT: If there's a cycle, a fast pointer (2 steps) will eventually
# "lap" a slow pointer (1 step) and they'll meet inside the cycle.
# If there's no cycle, fast reaches the end (None) and we return False.
#
# WHY it works: Think of a circular track. If two runners start at the same point
# and one runs twice as fast, the fast runner will eventually catch up to the slow
# one from behind. The gap closes by 1 step each iteration.
#
# WHY check fast AND fast.next: fast moves 2 steps, so we need both to be non-null
# to avoid a null pointer error on fast.next.next.
#
# TIME: O(n) — fast pointer enters cycle and catches slow in at most n steps
# SPACE: O(1) — just two pointers (no extra data structure!)

class LinkedListCycle:
    def has_cycle(self, head: ListNode | None) -> bool:
        # Both start at head
        slow, fast = head, head

        # fast moves 2 steps, slow moves 1 step
        while(fast is not None and fast.next is not None):
            slow = slow.next        # 1 step
            fast = fast.next.next   # 2 steps
            # If they meet, there's a cycle
            if slow == fast: return True

        # fast reached the end — no cycle
        return False
