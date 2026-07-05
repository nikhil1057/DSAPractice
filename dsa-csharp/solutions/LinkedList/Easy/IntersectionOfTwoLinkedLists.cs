// 160. Intersection of Two Linked Lists
// https://leetcode.com/problems/intersection-of-two-linked-lists/
//
// Given the heads of two singly linked-lists headA and headB,
// return the node at which the two lists intersect.
// If the two linked lists have no intersection, return null.
//
// APPROACH: Two-pointer trick — both pointers traverse the same total distance.
//
// KEY INSIGHT: If list A has length a and list B has length b:
// - Pointer `a` travels: a nodes + b nodes = a + b
// - Pointer `b` travels: b nodes + a nodes = b + a
// Since a + b == b + a, both pointers will meet at the intersection point
// (or both will be null at the same time if there's no intersection).
//
// WHY it works: The difference in lengths is eliminated by having each pointer
// traverse both lists. After switching lists, they're "aligned" — same distance
// from the intersection (or end).
//
// TIME: O(n + m) — each pointer visits each list once
// SPACE: O(1) — just two pointers

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x) { val = x; }
}

public class IntersectionOfTwoLinkedLists
{
    public ListNode? GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        ListNode a = headA;
        ListNode b = headB;

        // Keep moving both pointers until they meet (same node = intersection)
        // or both become null (no intersection)
        while(a != b)
        {
            // When pointer `a` reaches end of list A, redirect it to head of list B
            // When pointer `b` reaches end of list B, redirect it to head of list A
            // This equalizes the total distance both travel
            a = (a == null) ? headB : a.next;
            b = (b == null) ? headA : b.next;
        }

        // Either they met at intersection node, or both are null (no intersection)
        return a;
    }
}
