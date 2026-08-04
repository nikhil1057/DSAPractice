// 84. Largest Rectangle in Histogram
// https://leetcode.com/problems/largest-rectangle-in-histogram/
//
// Given an array of integers heights representing the histogram's bar height where
// the width of each bar is 1, return the area of the largest rectangle in the histogram.
//
// CATEGORY: Stack (Hard)
//
// HINTS:
// - Use a monotonic increasing stack of indices.
// - For each bar, while the stack top is taller, pop and calculate area.
// - The width extends from the current index back to the new stack top + 1.
// - After iterating, pop remaining bars using n as the right boundary.
//
// TIME: O(n) — each bar is pushed/popped at most once
// SPACE: O(n) — stack space

public class LargestRectangleInHistogram
{
    public int LargestRectangleArea(int[] heights)
    {
        if(heights.Length == 1) return heights[0];

        Stack<int> stack = new();

        int maxArea = 0;

        for(int i = 0; i < heights.Length; i++)
        {
            while(stack.Count() > 0 && heights[stack.Peek()] > heights[i])
            {
                //3,2,10,11,5,10,6,3
                //You encountered the smaller element so that becomes the NSE of the Stack top element 
                //if you are at 5, then 11 can not go in the right to traverse, As 5 is smaller than 11, So 5 is NSE of 11
                //PSE of 11 would be sitting under it inside the stack, Cause we are only appending PSE

                int height = heights[stack.Pop()]; //height of the 11 bar
                //iF stack is empty then there is no PSE for 11 that means it is first element of array,
                //But if stack is not empty, that means there was a smaller element previousluy from 11
                //So now to calculate area for 11, we will take the NSE, traverse to PSE, and sum their widths
                //NSE = 5 index = 4, PSE = 10, index = 2, So 11 has only one width to calculate area, Becomes, NSE - PSE - 1 => i - Stack(TOP) - 1
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1; 

                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(i);
        }

        //If After Iteration you will leave with couple of elements
        //Whatever element is in the stack there was no smaller element came into picture with them
        //If there was a smaller element they would have popped as that element would have become their NSE
        while(stack.Count > 0)
        {
            int height = heights[stack.Pop()]; //We will take the top first
            int width = stack.Count == 0 ? heights.Length : heights.Length - stack.Peek() - 1; 
            //When we take the TOP and stack got empty that means this was the smallest element we had
            //It was the last PSE of all elements, so it's NSE would be all the way to the last cause it can traverse to the last, as All other elements are taller
            //If It was not the last element then the last element is PSE and NSE would be the till the last as there no other element left to traverse
            //So If stack gets empty NSE = Length of array, PSE = none, so Width = Length of array
            //If Stack is not empty NSE = Length of array, PSE = Element left on top, Width = NSE - PSE - 1 => Length of array - Stack(top) - 1
            maxArea = Math.Max(maxArea, height * width);
        }

        return maxArea;

    }
}
