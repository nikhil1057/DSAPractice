import heapq
from solutions import ListNode


# 23. Merge k Sorted Lists (Min-Heap approach)
# https://leetcode.com/problems/merge-k-sorted-lists/
#
# APPROACH: Min-Heap (Priority Queue) — always pick the smallest head.
#
# KEY INSIGHT: At any point, the next node in the merged result must be
# the smallest among all current heads of the k lists. A min-heap lets
# us find that smallest in O(log k) instead of scanning all k heads.
#
# STEPS:
# 1. Push the head of each non-null list into a min-heap.
# 2. Pop the smallest node, attach it to the result.
# 3. If that node has a .next, push it into the heap.
# 4. Repeat until heap is empty.
#
# WHY use a counter for tie-breaking: Python's heapq compares tuples
# element by element. If two nodes have the same val, it tries to compare
# the ListNode objects (which aren't comparable). A unique counter as the
# second tuple element breaks ties without ever comparing nodes.
#
# TIME: O(N * log k) — N nodes total, each push/pop is O(log k)
# SPACE: O(k) — heap holds at most k nodes at any time

class MergeKSortedListsHeap:
    def merge_k_lists(self, lists: list[ListNode | None]) -> ListNode | None:
        heap = []
        counter = 0 #Unique tie breaker

        #Push all heads
        for head in lists:
            if head:
                heapq.heappush(heap, (head.val, counter, head))
                counter += 1
        #Builde the result
        dummy = ListNode(0)
        curr = dummy

        while heap:
            val, _, node = heapq.heappop(heap)
            curr.next = node
            curr = curr.next

            if node.next:
                heapq.heappush(heap, (node.next.val, counter, node.next))
                counter += 1
        return dummy.next
