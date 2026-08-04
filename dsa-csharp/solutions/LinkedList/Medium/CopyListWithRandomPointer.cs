// 138. Copy List with Random Pointer
// https://leetcode.com/problems/copy-list-with-random-pointer/
//
// A linked list of length n is given such that each node contains an additional random
// pointer, which could point to any node in the list, or null.
//
// Construct a deep copy of the list. The deep copy should consist of exactly n brand new
// nodes, where each new node has its value set to the value of its corresponding original
// node. Both the next and random pointer of the new nodes should point to new nodes in
// the copied list such that the pointers in the original list and copied list represent
// the same list state.
//
// Return the head of the copied linked list.
//
// CATEGORY: Linked List (Medium)
//
// APPROACH: Two-pass with HashMap.
// Pass 1: Create a copy of each node (value only), store mapping original → copy.
// Pass 2: Use the map to wire up next and random pointers on the copies.
// The map lets us look up "given an original node, what's its copy?" in O(1).
//
// TIME: O(n) — two passes through the list
// SPACE: O(n) — dictionary for node mapping

public class CopyListWithRandomPointer
{
    public class Node
    {
        public int val;
        public Node? next;
        public Node? random;
        public Node(int val = 0, Node? next = null, Node? random = null)
        {
            this.val = val;
            this.next = next;
            this.random = random;
        }
    }

    public Node? CopyRandomList(Node? head)
    {
        if (head == null) return null;

        Dictionary<Node,Node> hashMap = new();

        Node? curr = head;

        while(curr != null)
        {
            hashMap[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;

        while(curr != null)
        {
            hashMap[curr].next = curr.next != null ? hashMap[curr.next] : null;
            hashMap[curr].random = curr.random != null ? hashMap[curr.random] : null;
            curr = curr.next;
        }

        return hashMap[head];
    }
}
