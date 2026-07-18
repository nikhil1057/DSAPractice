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
# HINTS:
# - Use a hashmap to map original nodes to their copies.
# - First pass: create all copy nodes and store in the map.
# - Second pass: set next and random pointers using the map.
# - Alternatively, interleave copies in the original list (O(1) space).
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
        # TODO: Implement using hashmap or interleaving
        pass
