// 347. Top K Frequent Elements
// https://leetcode.com/problems/top-k-frequent-elements/
//
// Given an integer array nums and an integer k, return the k most frequent
// elements. You may return the answer in any order.
//
// APPROACH: Bucket Sort by frequency
//
// KEY INSIGHT: Max possible frequency is n (array length). Use frequency
// as the bucket index — then walk buckets from highest to lowest to get top k.
//
// HOW IT WORKS:
// 1. Count frequency of each element using a HashMap.
// 2. Create n+1 buckets where index = frequency, value = list of elements.
// 3. Walk buckets from right (highest freq) to left, collect k elements.
//
// WHY BUCKET SORT: Avoids O(n log n) sorting. Frequency is bounded by n,
// so we can use it as an array index directly.
//
// TIME: O(n) — counting + bucket placement + collection are all linear
// SPACE: O(n) — frequency map + bucket array

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new();  // Maps element → frequency

        foreach(int num in nums)
        {
            if(!dict.ContainsKey(num))
                dict[num] = 1;              // First occurrence
            else
                dict[num]++;                // Increment count
        }

        List<int>[] bucket = new List<int>[nums.Length + 1];  // index = frequency

        foreach(var kvp in dict)
        {
            int freq = kvp.Value;
            if(bucket[freq] == null)
                bucket[freq] = new List<int>();
            bucket[freq].Add(kvp.Key);      // Place element in its frequency bucket
        }

        List<int> result = new();

        // Walk from highest frequency to lowest, collect k elements
        for(int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if(bucket[i] != null)
            {
                foreach(int num in bucket[i])
                {
                    result.Add(num);
                    if(result.Count == k) break;  // Got k elements → done
                }
            }
        }
        return result.ToArray();
    }
}
