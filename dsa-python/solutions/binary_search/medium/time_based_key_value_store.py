# 981. Time Based Key-Value Store
# https://leetcode.com/problems/time-based-key-value-store/
#
# Design a time-based key-value data structure that can store multiple values for the
# same key at different time stamps and retrieve the key's value at a certain timestamp.
#
# Implement the TimeMap class:
# - TimeMap() Initializes the object.
# - set(key, value, timestamp) Stores the key with the value at the given timestamp.
# - get(key, timestamp) Returns a value such that set was called previously with
#   timestamp_prev <= timestamp. If there are multiple such values, it returns the
#   value associated with the largest timestamp_prev. If there are no values, returns "".
#
# CATEGORY: Binary Search (Medium)
#
# HINTS:
# - Use a dictionary mapping keys to a list of (timestamp, value) pairs.
# - Since timestamps are strictly increasing for set calls, the list is already sorted.
# - For get, use binary search to find the largest timestamp <= given timestamp.
#
# TIME: O(1) for set, O(log n) for get
# SPACE: O(n) — storing all key-value-timestamp triples


class TimeBasedKeyValueStore:
    def __init__(self):
        # TODO: Initialize data structure
        pass

    def set(self, key: str, value: str, timestamp: int) -> None:
        # TODO: Store key-value at timestamp
        pass

    def get(self, key: str, timestamp: int) -> str:
        # TODO: Get value at or before timestamp using binary search
        pass
