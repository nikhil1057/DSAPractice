// 11. Container With Most Water
// https://leetcode.com/problems/container-with-most-water/
//
// You are given an integer array height of length n. There are n vertical lines
// drawn such that the two endpoints of the ith line are (i, 0) and
// (i, height[i]). Find two lines that together with the x-axis form a
// container, such that the container contains the most water. Return the
// maximum amount of water a container can store.
//
// APPROACH:
// Use two pointers starting at both ends. Calculate the water as
// (right - left) * min(height[left], height[right]). Move the pointer
// pointing to the shorter line inward, since moving the taller one can
// never increase the area (width decreases and height is still capped
// by the shorter side).
//
// TIME: O(n) - single pass with two pointers
// SPACE: O(1) - only constant extra space used

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int i = 0;
        int j = height.Length - 1;
        int max = int.MinValue;

        while(i < j)
        {
            int water = calculateWater(height[i],height[j], j - i);

            if(max < water)
            {
                max = water;
            }

            if(height[i] <= height[j])
            {
                i++;
            }
            else j--;
        }

        return max;
    }

    private int calculateWater(int a, int b, int diff)
    {
        return (a <= b) ? a*diff : b*diff;
    }
}
