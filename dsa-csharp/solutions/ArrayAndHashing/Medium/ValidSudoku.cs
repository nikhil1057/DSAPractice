// 36. Valid Sudoku
// https://leetcode.com/problems/valid-sudoku/
//
// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be
// validated according to the following rules:
// - Each row must contain the digits 1-9 without repetition.
// - Each column must contain the digits 1-9 without repetition.
// - Each of the nine 3 x 3 sub-boxes must contain the digits 1-9 without repetition.
//
// APPROACH: Single HashSet with encoded string keys
//
// KEY INSIGHT: Encode (value, location) as a string key. HashSet.Add()
// returns false if the key already exists → duplicate found → invalid.
//
// HOW IT WORKS:
// - For each filled cell, try to add 3 keys: "val+row+i", "val+col+j", "val+box+i/3-j/3"
// - If any Add() returns false → that number already exists in that row/col/box → invalid.
// - i/3, j/3 maps any cell to its 3×3 sub-box (integer division).
//
// TIME: O(81) = O(1) — fixed 9×9 board
// SPACE: O(81) = O(1) — at most 3×81 keys in the set

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<String> seen = new();

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++)
            {
                char currentVal = board[i][j];
                if(currentVal != '.')
                {
                    // Add() returns false if already exists → duplicate!
                    if(!seen.Add(currentVal + "row" + i) ||
                       !seen.Add(currentVal + "col" + j) ||
                       !seen.Add(currentVal + "box" + i/3 + "-" + j/3))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
