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
// HINTS:
// - Use a Dictionary to map original nodes to their copies.
// - First pass: create all copy nodes and store in the map.
// - Second pass: set next and random pointers using the map.
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
        // TODO: Implement using hashmap
        throw new NotImplementedException();
    }
}
