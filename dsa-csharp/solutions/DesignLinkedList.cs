// 707. Design Linked List
// https://leetcode.com/problems/design-linked-list/
//
// Implement a singly linked list with get, addAtHead, addAtTail, addAtIndex, deleteAtIndex.
//
// APPROACH: Standard singly linked list with a head pointer.
// Each node holds a value and a pointer to the next node.
//
// WHY no dummy node here: We track `Head` directly. This means we need to
// handle edge cases (empty list, insert at head) separately, but it's straightforward.
//
// TIME: Get/Add/Delete are all O(n) in worst case because we may traverse the entire list.
// SPACE: O(n) for storing n nodes.

public class MyLinkedList
{
    private Node Head;

    public MyLinkedList()
    {
        Head = null; // Start with an empty list
    }

    // Get the value at the given index (0-based). Return -1 if index is invalid.
    public int Get(int index)
    {
        if (Head == null) return -1;

        Node current = Head;

        // Move forward `index` times to reach the target node
        for (int i = 0; i < index; i++)
        {
            if (current == null) return -1; // index out of bounds
            current = current.next;
        }

        // If current is null, index was too large
        return current == null ? -1 : current.value;
    }

    // Insert a new node at the very beginning of the list
    public void AddAtHead(int val)
    {
        Node node = new Node(val);
        node.next = Head; // New node points to the old head
        Head = node;      // New node becomes the head
    }

    // Insert a new node at the end of the list
    public void AddAtTail(int val)
    {
        Node node = new Node(val);

        // If list is empty, the new node IS the head
        if (Head == null) { Head = new Node(val); return; }

        // Traverse to the last node
        Node current = Head;
        while (current.next != null)
        {
            current = current.next;
        }
        // Attach new node at the end
        current.next = node;
    }

    // Insert a new node BEFORE the node at `index`.
    // If index == 0, insert at head. If index > length, don't insert.
    public void AddAtIndex(int index, int val)
    {
        // Special case: inserting at position 0 means inserting at head
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        Node current = Head;

        // We need to stop at the node BEFORE the target index (index - 1)
        // so we can insert after it
        for (int i = 0; i < index - 1; i++)
        {
            if (current == null) return; // index out of bounds
            current = current.next;
        }

        if (current == null) return; // index out of bounds

        // Insert: new node points to current's next, current points to new node
        Node node = new Node(val);
        node.next = current.next;
        current.next = node;
    }

    // Delete the node at the given index
    public void DeleteAtIndex(int index)
    {
        if (Head == null) return;

        // Special case: deleting head — just move head to next
        if (index == 0)
        {
            Head = Head?.next;
            return;
        }

        Node current = Head;

        // Navigate to the node BEFORE the one we want to delete
        for (int i = 0; i < index - 1; i++) 
        {
            if (current.next == null) return; // index out of bounds
            current = current.next;
        }

        if (current.next == null) return; // nothing to delete

        // Skip over the target node: prev.next = target.next
        current.next = current.next.next;
    }
}


public class Node
{
    public Node next;
    public int value;

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}
/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */
