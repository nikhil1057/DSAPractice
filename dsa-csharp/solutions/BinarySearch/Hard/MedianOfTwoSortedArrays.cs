// 4. Median of Two Sorted Arrays
// https://leetcode.com/problems/median-of-two-sorted-arrays/
//
// Given two sorted arrays nums1 and nums2 of size m and n respectively,
// return the median of the two sorted arrays.
// The overall run time complexity should be O(log (m+n)).
//
// APPROACH: Binary search on the shorter array to find the correct partition.
//
// The idea: median splits combined array into two equal halves.
// We binary search HOW MANY elements to take from shortArray into the left half.
// The rest come from longArray (totalLeftElements - mid1).
//
// At each partition, we check 4 boundary values:
//   leftShort  | rightShort     (last left vs first right of shortArray)
//   leftLong   | rightLong      (last left vs first right of longArray)
//
// Valid partition when: leftShort <= rightLong AND leftLong <= rightShort
// (everything on left ≤ everything on right)
//
// If leftShort > rightLong → took too many from short → move partition left
// If leftLong > rightShort → took too few from short → move partition right
//
// Edge cases: when mid1=0 or mid1=Length, use MinValue/MaxValue as "no boundary"
//
// WHY (totalLength + 1) / 2?
// For odd total (e.g., 5), left half gets 3, right gets 2.
// Median = max of left half. Without +1, left half would be too small.
//
// TIME: O(log(min(m,n))) — binary search on shorter array
// SPACE: O(1) — constant extra space

public class MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int totalLength = nums1.Length + nums2.Length;

        // Always binary search on the shorter array for O(log(min(m,n)))
        var shortArray = (nums1.Length <= nums2.Length) ? nums1 : nums2;
        var longArray = (nums1.Length <= nums2.Length) ? nums2 : nums1;

        // Left half should have (totalLength+1)/2 elements
        // +1 ensures odd totals put the extra element in the left half
        int totalLeftElements = (totalLength + 1) / 2;

        // Binary search: how many elements from shortArray go into left half?
        // Range: 0 (take nothing) to shortArray.Length (take all)
        int left = 0;
        int right = shortArray.Length;

        while (left <= right)
        {
            int mid1 = (left + right) / 2;             // elements from shortArray in left half
            int mid2 = totalLeftElements - mid1;        // elements from longArray in left half

            // Get 4 boundary values (use MinValue/MaxValue when partition is at edge)
            int leftShort = (mid1 > 0) ? shortArray[mid1 - 1] : int.MinValue;
            int rightShort = (mid1 < shortArray.Length) ? shortArray[mid1] : int.MaxValue;
            int leftLong = (mid2 > 0) ? longArray[mid2 - 1] : int.MinValue;
            int rightLong = (mid2 < longArray.Length) ? longArray[mid2] : int.MaxValue;

            if (leftShort <= rightLong && leftLong <= rightShort)
            {
                // Correct partition found!
                if (totalLength % 2 == 1)
                    return Math.Max(leftLong, leftShort);  // odd: median is max of left half
                else
                    return (Math.Max(leftLong, leftShort) + Math.Min(rightShort, rightLong)) / 2.0;  // even: average of two middle
            }
            else if (leftShort > rightLong)
                right = mid1 - 1;  // took too many from short → shrink
            else
                left = mid1 + 1;   // took too few from short → expand
        }

        return -1;  // should never reach here with valid input
    }
}
