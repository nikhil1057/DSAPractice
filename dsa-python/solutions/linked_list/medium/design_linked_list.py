from solutions import ListNode


# 707. Design Linked List
# https://leetcode.com/problems/design-linked-list/
#
# Implement a singly linked list with get, add_at_head, add_at_tail, add_at_index, delete_at_index.
#
# APPROACH: Standard singly linked list with a head pointer.
# We reuse the ListNode class (val, next) from __init__.py.
#
# WHY no dummy node: We track `head` directly. This means we handle edge cases
# (empty list, insert at head) as special cases.
#
# TIME: All operations are O(n) worst case (must traverse to find the position).
# SPACE: O(n) for storing n nodes.

class MyLinkedList:
    def __init__(self):
        self.head = None  # Start with an empty list

    def get(self, index: int) -> int:
        """Get value at index (0-based). Return -1 if index is invalid."""
        curr = self.head
        # Move forward `index` times to reach the target
        for _ in range(index):
            if curr is None:
                return -1  # index out of bounds
            curr = curr.next
        # If we landed on a valid node, return its value
        return curr.val if curr else -1

    def add_at_head(self, val: int) -> None:
        """Insert a new node at the beginning of the list."""
        new_node = ListNode(val)
        new_node.next = self.head  # New node points to old head
        self.head = new_node       # New node becomes the head

    def add_at_tail(self, val: int) -> None:
        """Insert a new node at the end of the list."""
        newNode = ListNode(val)

        # If list is empty, new node IS the head
        if(self.head is None):
            self.head = newNode
            return
        
        # Traverse to the last node
        curr_node = self.head
        while(curr_node.next):
            curr_node = curr_node.next
        
        # Attach new node at the end
        curr_node.next = newNode

    def add_at_index(self, index: int, val: int) -> None:
        """Insert a new node BEFORE the node at `index`.
        If index == 0, insert at head. If index > length, don't insert."""
        newNode = ListNode(val)

        # Special case: inserting at position 0 = inserting at head
        if(index == 0):
            self.add_at_head(val)
            return
        
        # Navigate to the node BEFORE the target index (index - 1)
        # so we can insert after it
        i = 0
        curr = self.head
        while(i < index - 1):
            if(curr is None):
                return  # index out of bounds
            curr = curr.next
            i = i + 1
        
        if(curr is None):
            return  # index out of bounds

        # Insert: new node points to curr's next, curr points to new node
        newNode.next = curr.next
        curr.next = newNode

    def delete_at_index(self, index: int) -> None:
        """Delete the node at the given index."""
        # Special case: deleting head — just move head forward
        if(index == 0):
            self.head = self.head.next
            return
        
        curr = self.head
        
        # Navigate to the node BEFORE the one we want to delete
        for _ in range(index - 1):
            if(curr is None):
                return  # index out of bounds
            curr = curr.next
        
        if(curr == None):
            return  # nothing to delete

        # Skip over the target: prev.next = target.next
        curr.next = curr.next.next
