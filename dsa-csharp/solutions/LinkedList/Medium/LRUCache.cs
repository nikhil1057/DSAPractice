// 146. LRU Cache
// https://leetcode.com/problems/lru-cache/
//
// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
//
// Implement the LRUCache class:
// - LRUCache(capacity) Initialize the LRU cache with positive size capacity.
// - Get(key) Return the value of the key if the key exists, otherwise return -1.
// - Put(key, value) Update the value of the key if the key exists. Otherwise, add the
//   key-value pair to the cache. If the number of keys exceeds the capacity, evict the
//   least recently used key.
//
// The functions Get and Put must each run in O(1) average time complexity.
//
// CATEGORY: Linked List (Medium)
//
// HINTS:
// - Use a Dictionary + LinkedList (or custom doubly linked list).
// - Dictionary maps key → node for O(1) lookup.
// - Doubly linked list maintains order (most recent at head, least recent at tail).
// - On Get/Put, move the node to the head.
// - On Put (over capacity), remove the tail node.
//
// TIME: O(1) for both Get and Put
// SPACE: O(capacity) — for storing cache entries

public class LRUCache
{
    public LRUCache(int capacity)
    {
        // TODO: Initialize dictionary and doubly linked list
        throw new NotImplementedException();
    }

    public int Get(int key)
    {
        // TODO: Return value if exists, move to front, else return -1
        throw new NotImplementedException();
    }

    public void Put(int key, int value)
    {
        // TODO: Add/update key-value, evict LRU if over capacity
        throw new NotImplementedException();
    }
}
