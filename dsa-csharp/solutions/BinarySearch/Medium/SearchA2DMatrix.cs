// 74. Search a 2D Matrix
// https://leetcode.com/problems/search-a-2d-matrix/
//
// You are given an m x n integer matrix with the following two properties:
// - Each row is sorted in non-decreasing order.
// - The first integer of each row is greater than the last integer of the previous row.
//
// Given an integer target, return true if target is in matrix or false otherwise.
// You must write a solution in O(log(m * n)) time complexity.
//
// CATEGORY: Binary Search (Medium)
//
// HINTS:
// - Treat the 2D matrix as a flattened sorted array.
// - Use binary search on indices 0 to m*n-1.
// - Convert flat index to row/col: row = idx / n, col = idx % n.
//
// TIME: O(log(m*n)) — binary search on flattened matrix
// SPACE: O(1) — constant extra space

public class SearchA2DMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int numberOfRows = matrix.Length; //This means how many array we have in the Matrix
        int numberOfCols = matrix[0].Length; //This means length of each array we have in matrix
        int left = 0;
        int right = numberOfRows * numberOfCols - 1;

        while(left <= right)
        {
            int mid = left + ((right - left) / 2);
            int row = mid / numberOfCols;  //Why numberOfCols, numberOfCols is the number of elements in each row, 
            // so everytime you want to know which row we are in we need to ask how many elements we have already crossed
            // that means if you crossed 9 elements and every row can have 4 element that means you are in 3rd row now that is exactly Your index / Length of one row.
            int col = mid % numberOfCols;

            if(matrix[row][col] > target) right = mid - 1;
            else if (matrix[row][col] < target) left = mid + 1;
            else return true;
        }

        return false;
    }
}
