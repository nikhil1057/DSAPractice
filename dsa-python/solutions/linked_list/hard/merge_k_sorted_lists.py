from solutions import ListNode


# 23. Merge k Sorted Lists
# https://leetcode.com/problems/merge-k-sorted-lists/
#
# APPROACH: Divide and Conquer — repeatedly merge pairs of lists.
#
# KEY INSIGHT: We already know how to merge TWO sorted lists (Problem 21).
# Merge k lists by pairing them up and merging each pair, halving the
# number of lists each round until only one remains. Like a tournament bracket.
#
# WHY Divide and Conquer over merging one-by-one (sequential):
#   - Sequential: merge(L1,L2)→result, merge(result,L3)→result, ...
#     The result grows each time, so later merges are heavier.
#     Total work: O(k * N) where N = total nodes.
#   - Divide & Conquer: Pair up → merge k/2 pairs → repeat.
#     Each round touches all N nodes, but only log(k) rounds needed.
#     Total work: O(N * log k) — much better when k is large.
#
# VISUAL for k=4 lists [L1, L2, L3, L4]:
#   Round 1: merge(L1,L2)→M1, merge(L3,L4)→M2  (2 pairs)
#   Round 2: merge(M1,M2)→Final                  (1 pair)
#   Done in log2(4) = 2 rounds.
#
# ODD COUNT: If there's an unpaired list (odd count), it gets a "bye" —
# merged with None, which just returns itself unchanged.
#
# TIME: O(N * log k) — N total nodes, log k merge rounds
# SPACE: O(1) — merge in-place by rewiring pointers (O(log k) for the list array)

class MergeKSortedLists:
    def merge_k_lists(self, lists: list[ListNode | None]) -> ListNode | None:
        if(len(lists) == 0): return None

        while(len(lists) > 1):
            merged = []

            for i in range(0, len(lists), 2):
                l1 = lists[i]
                l2 = lists[i + 1] if i + 1 < len(lists) else None
                merged.append(self._merge2LinkedLists(l1,l2))
            lists = merged
        return lists[0]

    def _merge2LinkedLists(self, list1: ListNode | None, list2: ListNode | None ) -> ListNode | None:
        dummy = ListNode(0)
        curr = dummy

        while(list1 and list2):
            if(list1.val <= list2.val):
                curr.next = list1
                list1 = list1.next

            else:
                curr.next = list2
                list2 = list2.next
            curr = curr.next
        
        curr.next = list1 or list2
        return dummy.next

