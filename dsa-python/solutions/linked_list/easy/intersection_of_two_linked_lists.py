from solutions import ListNode


# 160. Intersection of Two Linked Lists
# https://leetcode.com/problems/intersection-of-two-linked-lists/
#
# Given heads of two singly linked lists, return the node at which they intersect.
# If no intersection, return None.
#
# APPROACH: Two-pointer trick — both pointers traverse the same total distance.
#
# KEY INSIGHT: If list A has length `a` and list B has length `b`:
# - Pointer `a` travels: a nodes + b nodes = a + b
# - Pointer `b` travels: b nodes + a nodes = b + a
# Since a + b == b + a, both pointers reach the intersection at the same time.
#
# WHY it works: The difference in list lengths is eliminated by making each pointer
# traverse BOTH lists. After switching, they're "aligned" — same distance from the
# intersection (or from the end if there's no intersection).
#
# Example: A = [1,2,3,7,8], B = [4,5,7,8] (intersection at 7)
# Pointer a: 1→2→3→7→8→None→4→5→[7] (total 9 steps)
# Pointer b: 4→5→7→8→None→1→2→3→[7] (total 9 steps)
# They meet at 7!
#
# TIME: O(n + m) — each pointer visits each list once
# SPACE: O(1) — just two pointers

class IntersectionOfTwoLinkedLists:
    def get_intersection_node(self, head_a: ListNode | None, head_b: ListNode | None) -> ListNode | None:
        a = head_a
        b = head_b

        # Keep moving until both pointers meet (same node) or both become None
        while a is not b:
            # When pointer `a` reaches end of list A, redirect to head of list B
            a = head_b if a is None else a.next
            # When pointer `b` reaches end of list B, redirect to head of list A
            b = head_a if b is None else b.next
        
        # They either met at the intersection node, or both are None (no intersection)
        return a
