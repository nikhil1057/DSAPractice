from solutions import ListNode


# 21. Merge Two Sorted Lists
# https://leetcode.com/problems/merge-two-sorted-lists/
#
# APPROACH: Dummy node + compare and attach the smaller node each time.
#
# KEY INSIGHT: Both lists are already sorted. We just pick the smaller head
# each iteration and attach it to our result. Like merging in merge sort.
#
# WHY dummy node: We don't know which list has the smaller first element.
# Dummy lets us build the result without special-casing the first node.
#
# WHY attach remaining list at the end: Once one list is exhausted, the other
# is still sorted, so we just point to it directly — no need to iterate.
#
# TIME: O(n + m) — each node visited once
# SPACE: O(1) — we reuse existing nodes, just rewire pointers

class MergeTwoSortedLists:
    def merge_two_lists(self, list1: ListNode | None, list2: ListNode | None) -> ListNode | None:
        # Dummy node as anchor for the merged list
        dummy = ListNode(0)
        curr = dummy

        # Compare heads of both lists, attach the smaller one
        while(list1 and list2):
            if(list1.val <= list2.val): 
                curr.next = list1
                list1 = list1.next
            else: 
                curr.next = list2
                list2 = list2.next
            curr = curr.next

        # One list is done — attach whatever remains from the other
        if list1: curr.next = list1 
        else: curr.next = list2

        # Skip dummy, return merged list
        return dummy.next
