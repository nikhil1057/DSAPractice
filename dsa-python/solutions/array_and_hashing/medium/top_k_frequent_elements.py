# 347. Top K Frequent Elements
# https://leetcode.com/problems/top-k-frequent-elements/
#
# Given an integer array nums and an integer k, return the k most frequent
# elements. You may return the answer in any order.
#
# APPROACH: Bucket Sort by frequency
#
# KEY INSIGHT: Max possible frequency is n (array length). Use frequency
# as the bucket index — then walk buckets from highest to lowest to get top k.
#
# HOW IT WORKS:
# 1. Count frequency of each element using a HashMap.
# 2. Create n+1 buckets where index = frequency, value = list of elements.
# 3. Walk buckets from right (highest freq) to left, collect k elements.
#
# WHY BUCKET SORT: Avoids O(n log n) sorting. Frequency is bounded by n,
# so we can use it as an array index directly.
#
# TIME: O(n) — counting + bucket placement + collection are all linear
# SPACE: O(n) — frequency map + bucket array


class TopKFrequentElements:
    def top_k_frequent(self, nums: list[int], k: int) -> list[int]:
        freq = {}  # Maps element → frequency

        for num in nums:
            freq[num] = freq.get(num, 0) + 1       # Count occurrences

        buckets = [[] for _ in range(len(nums) + 1)]  # index = frequency

        for key, value in freq.items():
            buckets[value].append(key)             # Place element in its frequency bucket

        result = []

        for i in range(len(buckets) - 1, -1, -1):  # Walk from highest frequency
            for num in buckets[i]:
                result.append(num)
                if len(result) == k:               # Got k elements → done
                    return result

        return result
