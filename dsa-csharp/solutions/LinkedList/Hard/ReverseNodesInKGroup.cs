// 25. Reverse Nodes in k-Group
// https://leetcode.com/problems/reverse-nodes-in-k-group/
//
// Given the head of a linked list, reverse the nodes of the list k at a time,
// and return the modified list.
//
// APPROACH: Iteratively process k nodes at a time.
// 1. Check if k nodes exist ahead (if not, done — return dummy.next)
// 2. Reverse k nodes
// 3. Reconnect: prev_group_end → new head, old head (now tail) → next group start
// 4. Move slow to the new tail, repeat
//
// EXAMPLE: 1→2→3→4→5, k=2
//
// Initial:  dummy → 1 → 2 → 3 → 4 → 5
//           slow=dummy, fast moves 2 steps to node 2
//
// Group 1:  groupStart=1, nextGroupStart=3
//           Reverse(1→2): 2→1→null (1.next now points to null, 2 is new head)
//           slow.next = 2:      dummy → 2 → 1    (reconnect prev_group_end to new head)
//           groupStart.next = 3: dummy → 2 → 1 → 3 → 4 → 5  (old head connects to next group)
//           ↑ THIS is where 1→3 reconnects (the 2→3 link broke during reverse)
//           slow = 1 (move to new tail)
//
// Group 2:  slow=1, fast moves 2 steps to node 4
//           groupStart=3, nextGroupStart=5
//           Reverse(3→4): 4→3→null
//           slow.next = 4:      ... 1 → 4 → 3    (reconnect)
//           groupStart.next = 5: ... 1 → 4 → 3 → 5  (3→5 reconnects, 4→5 broke during reverse)
//           slow = 3
//
// Group 3:  slow=3, fast moves but hits null after 1 step → fewer than k, DONE!
//
// Result: dummy → 2 → 1 → 4 → 3 → 5
//
// TIME: O(n) — each node is visited a constant number of times
// SPACE: O(1) — iterative approach

public class ReverseNodesInKGroup
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode? ReverseKGroup(ListNode? head, int k)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode slow = dummy;  // prev_group_end

        while (true)
        {
            // Check if k nodes exist ahead
            ListNode? fast = slow;
            for (int i = 0; i < k; i++)
            {
                fast = fast.next;
                if (fast == null) return dummy.next;  // fewer than k remain, done!
            }

            // Save boundaries before reversing
            ListNode groupStart = slow.next;       // will become tail after reverse
            ListNode nextGroupStart = fast.next;   // first node of next group

            // Reverse k nodes, connect prev_group_end to new head
            slow.next = Reverse(slow.next, k);

            // Reconnect: old head (now tail) → next group
            groupStart.next = nextGroupStart;

            // Move slow to the new tail
            slow = groupStart;
        }
    }

    private ListNode Reverse(ListNode head, int k)
    {
        ListNode? prev = null;
        ListNode? curr = head;

        for (int i = 0; i < k; i++)
        {
            ListNode? next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;  // new head of reversed group
    }
}
