// 15. 3Sum
// https://leetcode.com/problems/3sum/
//
// Given an integer array nums, return all the triplets [nums[i], nums[j],
// nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] +
// nums[k] == 0. Notice that the solution set must not contain duplicate
// triplets.
//
// APPROACH:
// Sort the array first. For each element nums[i], use two pointers (left, right)
// to find pairs that sum to -nums[i]. Skip duplicates at all three positions
// to avoid duplicate triplets. If nums[i] > 0, break early since no valid
// triplet can exist with all positive numbers.
//
// TIME: O(n^2) - sorting is O(n log n), then O(n) two-pointer scan for each element
// SPACE: O(1) - ignoring the output array, only constant extra space used

public class ThreeSum
{
    public IList<IList<int>> ThreeSumSolution(int[] nums)
    {
        List<IList<int>> res = new List<IList<int>>();
        if(nums.Length == 0 || nums.Length < 3) return res;

        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i] > 0 || (i > 0 && nums[i] == nums[i-1]))
            continue;

            int left = i + 1; int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];
                if(sum == 0)
                {
                    res.Add(new List<int>{nums[i],nums[left],nums[right]});
                    left++;
                    right--;

                    while(left < right && nums[left - 1] == nums[left]) left++;
                    while(left < right && nums[right + 1 ] == nums[right]) right--;
                }

                else if(sum > 0) right--;

                else left++;
            }
        }

        return res;
    }
}
