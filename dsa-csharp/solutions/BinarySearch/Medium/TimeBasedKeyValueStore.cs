// 981. Time Based Key-Value Store
// https://leetcode.com/problems/time-based-key-value-store/
//
// Design a time-based key-value data structure that can store multiple values for the
// same key at different time stamps and retrieve the key's value at a certain timestamp.
//
// Implement the TimeMap class:
// - TimeMap() Initializes the object.
// - Set(key, value, timestamp) Stores the key with the value at the given timestamp.
// - Get(key, timestamp) Returns a value such that Set was called previously with
//   timestamp_prev <= timestamp. If there are multiple such values, it returns the
//   value associated with the largest timestamp_prev. If there are no values, returns "".
//
// CATEGORY: Binary Search (Medium)
//
// HINTS:
// - Use a Dictionary mapping keys to a List of (timestamp, value) tuples.
// - Since timestamps are strictly increasing for Set calls, the list is already sorted.
// - For Get, use binary search to find the largest timestamp <= given timestamp.
//
// TIME: O(1) for Set, O(log n) for Get
// SPACE: O(n) — storing all key-value-timestamp triples

public class TimeBasedKeyValueStore
{
    public TimeBasedKeyValueStore()
    {
        // TODO: Initialize data structure
        throw new NotImplementedException();
    }

    public void Set(string key, string value, int timestamp)
    {
        // TODO: Store key-value at timestamp
        throw new NotImplementedException();
    }

    public string Get(string key, int timestamp)
    {
        // TODO: Get value at or before timestamp using binary search
        throw new NotImplementedException();
    }
}
