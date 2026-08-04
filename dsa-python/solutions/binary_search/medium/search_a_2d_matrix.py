# 74. Search a 2D Matrix
# https://leetcode.com/problems/search-a-2d-matrix/
#
# You are given an m x n integer matrix with the following two properties:
# - Each row is sorted in non-decreasing order.
# - The first integer of each row is greater than the last integer of the previous row.
#
# Given an integer target, return true if target is in matrix or false otherwise.
# You must write a solution in O(log(m * n)) time complexity.
#
# APPROACH: Treat the 2D matrix as a flattened sorted array. Use binary search on
# indices 0 to m*n-1. Convert flat index to row/col using:
#   row = mid // cols (how many complete rows fit before this index)
#   col = mid % cols  (what's left over — that's the column)
#
# TIME: O(log(m*n)) — binary search on flattened matrix
# SPACE: O(1) — constant extra space


class SearchA2DMatrix:
    def search_matrix(self, matrix: list[list[int]], target: int) -> bool:
        number_of_rows, number_of_cols = len(matrix), len(matrix[0])
        left, right = 0, number_of_cols * number_of_rows - 1

        while left <= right:
            mid = left + (right - left) // 2
            row = mid // number_of_cols  # integer division to get row
            col = mid % number_of_cols   # remainder to get column

            if matrix[row][col] > target:
                right = mid - 1
            elif matrix[row][col] < target:
                left = mid + 1
            else:
                return True

        return False
