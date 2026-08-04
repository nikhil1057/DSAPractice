// 704. Binary Search
// https://leetcode.com/problems/binary-search/
//
// Given an array of integers nums which is sorted in ascending order, and an integer target,
// write a function to search target in nums. If target exists, then return its index.
// Otherwise, return -1.
//
// You must write an algorithm with O(log n) runtime complexity.
//
// CATEGORY: Binary Search (Easy)
//
// APPROACH: Classic binary search. Maintain left and right pointers, calculate mid,
// compare nums[mid] with target. Halve the search space each iteration.
// Using left + (right - left) / 2 to avoid integer overflow when computing mid.
//
// TIME: O(log n) — halving the search space each step
// SPACE: O(1) — constant extra space

public class BinarySearch
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int mid = left + ((right - left) / 2); //Taking distance between right and left and then adding it to left 

            if(nums[mid] > target) right = mid - 1;
            else if(nums[mid] < target) left = mid + 1;
            else return mid;
        }

        return -1;
    }
}
