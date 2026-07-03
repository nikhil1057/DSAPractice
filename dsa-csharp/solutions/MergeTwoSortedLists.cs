// 21. Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists/
//
// APPROACH: Dummy node + compare and attach the smaller node each time.
//
// KEY INSIGHT: Both lists are already sorted. We just pick the smaller head
// each iteration and attach it to our result. Like the merge step in merge sort.
//
// WHY dummy node: We don't know which list has the smaller first element.
// Dummy lets us build the result without special-casing the first node.
//
// WHY attach remaining at the end: Once one list is exhausted, the other
// is still sorted, so we just point to it directly (no iteration needed).
//
// WHY `list1 ?? list2`: C# null-coalescing — if list1 is not null, use it;
// otherwise use list2. One of them will have remaining nodes (or both null).
//
// TIME: O(n + m) — each node visited once
// SPACE: O(1) — reuse existing nodes, just rewire pointers

public class MergeTwoSortedLists
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        // Dummy node as anchor for the merged list
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        // Compare heads of both lists, attach the smaller one
        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }
            curr = curr.next;
        }

        // One list is done — attach whatever remains from the other
        curr.next = list1 ?? list2;

        // Skip dummy, return merged list
        return dummy.next;
    }
}
