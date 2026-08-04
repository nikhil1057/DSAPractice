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

using System.Data;

public class LRUCache
{
    private class DoubleNode
    {
            public int Key;
            public int Val;
            public DoubleNode? Prev;
            public DoubleNode? Next;
            public DoubleNode(int key, int val)
        {
            Key = key;
            Val = val;
        }
    }

    Dictionary<int, DoubleNode> map;
    private DoubleNode head;
    private DoubleNode tail;
    private int capacity;
    public LRUCache(int capacity) //Head ->DoublyLinkedList <- Tail
    {
        this.capacity = capacity;
        map = new Dictionary<int, DoubleNode>();
        head = new DoubleNode(0,0);
        tail = new DoubleNode(0,0);
        head.Next = tail;
        tail.Prev = head;
    }

    public int Get(int key)
    {
        if(!map.ContainsKey(key)) return -1;
        DoubleNode node = map[key];
        Remove(node);
        AddToFront(node);
        return node.Val;
        
    }

    public void Put(int key, int value)
    {
        if(map.ContainsKey(key))
        {
            Remove(map[key]);
        }

        DoubleNode node = new DoubleNode(key, value);
        AddToFront(node);
        map[key] = node;

        if(map.Count > capacity)
        {
            DoubleNode lru = tail.Prev;
            Remove(lru);
            map.Remove(lru.Key); //need key to be saved in node to be removed from map
        }
    }

    private void Remove(DoubleNode node)
    {
        //Unlink node from it's current position
        node.Prev.Next = node.Next;
        node.Next.Prev = node.Prev;
        
    }
    private void AddToFront(DoubleNode node)
    {
        //Insert right after dummy head
        node.Next = head.Next;
        node.Prev = head;
        head.Next.Prev = node;
        head.Next = node;
    }
}


