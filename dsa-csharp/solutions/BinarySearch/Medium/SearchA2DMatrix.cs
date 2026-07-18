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
        // TODO: Implement using binary search on virtual flattened array
        throw new NotImplementedException();
    }
}
