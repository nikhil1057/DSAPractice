# 36. Valid Sudoku
# https://leetcode.com/problems/valid-sudoku/
#
# Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be
# validated according to the following rules:
# - Each row must contain the digits 1-9 without repetition.
# - Each column must contain the digits 1-9 without repetition.
# - Each of the nine 3 x 3 sub-boxes must contain the digits 1-9 without repetition.
#
# Note: A Sudoku board (partially filled) could be valid but is not necessarily solvable.
#
# APPROACH: Single HashSet with encoded keys
#
# KEY INSIGHT: Encode (value, location) as a tuple key. If we try to add
# a key that already exists, it means we've seen that number in that
# row/col/box before → invalid.
#
# HOW IT WORKS:
# - For each filled cell, create 3 keys: (val, "row", i), (val, "col", j), (val, "box", i//3, j//3)
# - If any key already exists in the set → duplicate → return False.
# - i//3, j//3 maps any cell to its 3×3 sub-box (0-2 range).
#
# TIME: O(81) = O(1) — fixed 9×9 board
# SPACE: O(81) = O(1) — at most 3×81 keys in the set


class ValidSudoku:
    def is_valid_sudoku(self, board: list[list[str]]) -> bool:
        seen = set()

        for i in range(9):
            for j in range(9):
                val = board[i][j]
                if val != '.':
                    row_key = (val, "row", i)           # Unique key for this value in this row
                    col_key = (val, "col", j)           # Unique key for this value in this col
                    box_key = (val, "box", i//3, j//3)  # Unique key for this value in this box

                    if(row_key in seen or col_key in seen or box_key in seen):
                        return False                    # Duplicate found → invalid
                    seen.add(row_key)
                    seen.add(col_key)
                    seen.add(box_key)
        return True
