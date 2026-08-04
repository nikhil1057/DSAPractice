# 138. Copy List with Random Pointer
# https://leetcode.com/problems/copy-list-with-random-pointer/
#
# A linked list of length n is given such that each node contains an additional random
# pointer, which could point to any node in the list, or null.
#
# Construct a deep copy of the list. The deep copy should consist of exactly n brand new
# nodes, where each new node has its value set to the value of its corresponding original
# node. Both the next and random pointer of the new nodes should point to new nodes in
# the copied list such that the pointers in the original list and copied list represent
# the same list state.
#
# Return the head of the copied linked list.
#
# CATEGORY: Linked List (Medium)
#
# APPROACH: Two-pass with HashMap.
# Pass 1: Create a copy of each node (value only), store mapping original → copy.
# Pass 2: Use the map to wire up next and random pointers on the copies.
# The map lets us look up "given an original node, what's its copy?" in O(1).
#
# TIME: O(n) — two passes through the list
# SPACE: O(n) — hashmap for node mapping


class Node:
    def __init__(self, x: int, next: "Node | None" = None, random: "Node | None" = None):
        self.val = x
        self.next = next
        self.random = random


class CopyListWithRandomPointer:
    def copy_random_list(self, head: Node | None) -> Node | None:
        if not head:
            return None
        map = {}
        curr = head
        while curr:
            map[curr] = Node(curr.val)
            curr = curr.next
        curr = head
        while curr:
            map[curr].next = map[curr.next] if curr.next else None
            map[curr].random = map[curr.random] if curr.random else None
            curr = curr.next
        return map[head]
