# 981. Time Based Key-Value Store
# https://leetcode.com/problems/time-based-key-value-store/
#
# Design a time-based key-value data structure that can store multiple values for the
# same key at different time stamps and retrieve the key's value at a certain timestamp.
#
# APPROACH:
# - Store: Dictionary mapping key → list of (value, timestamp) tuples
# - Set: Just append — timestamps are strictly increasing so list stays sorted
# - Get: Binary search for the LARGEST timestamp ≤ given timestamp (rightmost valid)
#
# WHY left <= right with result variable?
# We're searching for the RIGHTMOST valid answer. If we used left = mid with left < right,
# it would infinite loop (floor mid biases left). So we use left = mid + 1 and store
# the answer separately. When no valid timestamp exists, result stays "".
#
# TIME: O(1) for set, O(log n) for get
# SPACE: O(n) — storing all key-value-timestamp triples

from collections import defaultdict


class TimeBasedKeyValueStore:
    def __init__(self):
        # defaultdict(list) auto-creates empty list for new keys — no if/else needed in set
        self.TimeMap = defaultdict(list)

    def set(self, key: str, value: str, timestamp: int) -> None:
        # Just append — timestamps are guaranteed strictly increasing, so list stays sorted
        self.TimeMap[key].append((value, timestamp))

    def get(self, key: str, timestamp: int) -> str:
        if key not in self.TimeMap:
            return ""

        values = self.TimeMap[key]
        left, right = 0, len(values) - 1
        result = ""  # stays "" if no timestamp ≤ target exists

        while left <= right:
            mid = (left + right) // 2

            if values[mid][1] <= timestamp:
                result = values[mid][0]  # valid! record this value, try to find bigger timestamp
                left = mid + 1           # search right for a larger valid timestamp
            else:
                right = mid - 1          # timestamp too big, search left

        return result
