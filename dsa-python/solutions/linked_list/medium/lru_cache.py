# 146. LRU Cache
# https://leetcode.com/problems/lru-cache/
#
# Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
#
# APPROACH: HashMap + Doubly Linked List.
# HashMap: key → Node for O(1) lookup.
# Doubly Linked List: maintains recency order (head = most recent, tail = least recent).
# Dummy head/tail avoid null checks when adding/removing.
#
# get: lookup in map, move to front, return value.
# put: if exists remove old, create new node, add to front, evict tail if over capacity.
#
# TIME: O(1) for both get and put
# SPACE: O(capacity) — for storing cache entries


class Node:
    def __init__(self, key: int, val: int):
        self.key = key
        self.val = val
        self.prev = None
        self.next = None


class LRUCache:
    def __init__(self, capacity: int):
        self.map = {}
        self.capacity = capacity
        self.head = Node(0, 0)  # dummy head (most recent side)
        self.tail = Node(0, 0)  # dummy tail (least recent side)
        self.head.next = self.tail
        self.tail.prev = self.head

    def get(self, key: int) -> int:
        if key not in self.map:
            return -1
        node = self.map[key]
        self._remove(node)
        self._add_to_front(node)
        return node.val

    def put(self, key: int, value: int) -> None:
        if key in self.map:
            self._remove(self.map[key])

        node = Node(key, value)
        self._add_to_front(node)
        self.map[key] = node

        if len(self.map) > self.capacity:
            lru = self.tail.prev  # least recently used
            self._remove(lru)
            del self.map[lru.key]  # need key to remove from map!

    def _remove(self, node):
        # Unlink node from its current position
        node.prev.next = node.next
        node.next.prev = node.prev

    def _add_to_front(self, node):
        # Insert right after dummy head
        node.next = self.head.next
        node.prev = self.head
        self.head.next.prev = node
        self.head.next = node
