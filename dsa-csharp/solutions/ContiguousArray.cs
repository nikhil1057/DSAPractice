// 525. Contiguous Array
// https://leetcode.com/problems/contiguous-array/
//
// Given a binary array nums, return the maximum length of a contiguous subarray
// with an equal number of 0 and 1.
//
// APPROACH: Prefix sum with HashMap
//
// KEY INSIGHT: Track the difference (ones - zeros) as we iterate.
// If the same difference appears at two indices i and j, it means the subarray
// from i+1 to j has equal 0s and 1s (because the difference didn't change,
// so we added equal 0s and 1s in between).
//
// WHY it works: If at index 3 we have (ones - zeros = 2) and at index 7
// we again have (ones - zeros = 2), then between index 4 and 7, we must have
// added equal numbers of 0s and 1s.
//
// TIME: O(n) — single pass through the array
// SPACE: O(n) — HashMap can store up to n different difference values

public class ContiguousArray
{
    public int FindMaxLength(int[] nums)
    {
        int zero = 0;   // running count of zeros seen so far
        int one = 0;    // running count of ones seen so far
        int result = 0; // longest subarray found

        // Maps each (ones - zeros) difference to the FIRST index where we saw it
        // We store only the first occurrence because we want the LONGEST subarray
        Dictionary<int,int> diff = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            // Update counts
            if(nums[i] == 0) zero++; else one++;

            // Store this difference only if we haven't seen it before
            // (first occurrence gives longest subarray later)
            if(!diff.ContainsKey(one - zero))
            {
                diff[one - zero] = i;
            }

            // Special case: from index 0 to i, we have equal 0s and 1s
            // The entire prefix is a valid subarray
            if(one == zero) result = one + zero;

            else
            {
                // We've seen this difference before at some earlier index
                // The subarray between that index+1 and current index has equal 0s and 1s
                int index = diff[one - zero];
                result = Math.Max(result, i - index);
            } 
        }

        return result;
        
    }
}
