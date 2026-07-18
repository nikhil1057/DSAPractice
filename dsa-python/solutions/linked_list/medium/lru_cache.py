# 146. LRU Cache
# https://leetcode.com/problems/lru-cache/
#
# Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
#
# Implement the LRUCache class:
# - LRUCache(capacity) Initialize the LRU cache with positive size capacity.
# - get(key) Return the value of the key if the key exists, otherwise return -1.
# - put(key, value) Update the value of the key if the key exists. Otherwise, add the
#   key-value pair to the cache. If the number of keys exceeds the capacity, evict the
#   least recently used key.
#
# The functions get and put must each run in O(1) average time complexity.
#
# CATEGORY: Linked List (Medium)
#
# HINTS:
# - Use a hashmap + doubly linked list.
# - Hashmap maps key → node for O(1) lookup.
# - Doubly linked list maintains order (most recent at head, least recent at tail).
# - On get/put, move the node to the head.
# - On put (over capacity), remove the tail node.
#
# TIME: O(1) for both get and put
# SPACE: O(capacity) — for storing cache entries


class LRUCache:
    def __init__(self, capacity: int):
        # TODO: Initialize hashmap and doubly linked list
        pass

    def get(self, key: int) -> int:
        # TODO: Return value if exists, move to front, else return -1
        pass

    def put(self, key: int, value: int) -> None:
        # TODO: Add/update key-value, evict LRU if over capacity
        pass
