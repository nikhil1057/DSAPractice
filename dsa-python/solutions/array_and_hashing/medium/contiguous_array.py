# 525. Contiguous Array
# https://leetcode.com/problems/contiguous-array/
#
# APPROACH: Prefix sum (ones - zeros) with HashMap.
#
# KEY INSIGHT: Track the difference (ones - zeros) as we iterate.
# If the same difference appears at two indices i and j, the subarray
# from i+1 to j has equal 0s and 1s (because the difference didn't change,
# meaning we added equal 0s and 1s in between).
#
# WHY store first occurrence only: We want the LONGEST subarray,
# so the earlier we first saw a difference, the longer the subarray.
#
# SPECIAL CASE: When ones == zeros, the entire prefix from index 0 is valid.
#
# TIME: O(n) — single pass
# SPACE: O(n) — HashMap stores up to n different difference values

class ContiguousArray:
    def find_max_length(self, nums: list[int]) -> int:
        zero, one = 0, 0  # Running counts of zeros and ones
        diff = {}          # Maps (ones - zeros) → first index where this diff was seen
        result = 0         # Longest valid subarray found

        for i, n in enumerate(nums):
            # Update counts
            if(n == 0):
                zero += 1
            else: one += 1

            # If equal counts from the start, entire prefix is valid
            if(one == zero): 
                result = one + zero

            # We've seen this difference before → subarray between is balanced
            elif(one - zero in diff):
                result = max(result, i - diff[one - zero])

            # First time seeing this difference → store the index
            else:
                diff[one - zero] = i
        
        return result
