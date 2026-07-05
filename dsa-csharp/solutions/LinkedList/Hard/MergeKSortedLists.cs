// 23. Merge k Sorted Lists
// https://leetcode.com/problems/merge-k-sorted-lists/
//
// APPROACH: Divide and Conquer — repeatedly merge pairs of lists.
//
// KEY INSIGHT: We already know how to merge TWO sorted lists (Problem 21).
// Merge k lists by pairing them up and merging each pair, halving the
// number of lists each round until only one remains. Like a tournament bracket.
//
// WHY Divide and Conquer over merging one-by-one (sequential):
//   - Sequential: merge(L1,L2)→result, merge(result,L3)→result, ...
//     The result grows each time, so later merges are heavier.
//     Total work: O(k * N) where N = total nodes.
//   - Divide & Conquer: Pair up → merge k/2 pairs → repeat.
//     Each round touches all N nodes, but only log(k) rounds needed.
//     Total work: O(N * log k) — much better when k is large.
//
// VISUAL for k=4 lists [L1, L2, L3, L4]:
//   Round 1: merge(L1,L2)→M1, merge(L3,L4)→M2  (2 pairs)
//   Round 2: merge(M1,M2)→Final                  (1 pair)
//   Done in log2(4) = 2 rounds.
//
// ODD COUNT: If there's an unpaired list (odd count), it gets a "bye" —
// merged with null, which just returns itself unchanged.
//
// TIME: O(N * log k) — N total nodes, log k merge rounds
// SPACE: O(1) — merge in-place by rewiring pointers (O(log k) for the list)

public class MergeKSortedLists
{
    public ListNode? MergeKLists(ListNode?[] lists)
    {
        if(lists.Length == 0) return null;

        var current = lists.ToList();

        while(current.Count() > 1)
        {
            var merged = new List<ListNode?>();

            for(int i = 0; i < current.Count(); i += 2)
            {
                var list1 = current[i];
                var list2 = (i + 1 < current.Count()) ? current[i+1] : null;
                merged.Add(Merge2LinkedLists(list1,list2));
            }

            current = merged;
        }

        return current[0];
    }

    private ListNode? Merge2LinkedLists(ListNode? list1, ListNode? list2)
    {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

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

        curr.next = list1 ?? list2;

        return dummy.next;
    }
}
