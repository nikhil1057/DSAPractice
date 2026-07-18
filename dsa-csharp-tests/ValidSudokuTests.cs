public class ValidSudokuTests
{
    [Fact]
    public void Example1_Valid()
    {
        var board = new char[][]
        {
            ['5','3','.','.','7','.','.','.','.'],
            ['6','.','.','1','9','5','.','.','.'],
            ['.','9','8','.','.','.','.','6','.'],
            ['8','.','.','.','6','.','.','.','3'],
            ['4','.','.','8','.','3','.','.','1'],
            ['7','.','.','.','2','.','.','.','6'],
            ['.','6','.','.','.','.','2','8','.'],
            ['.','.','.','4','1','9','.','.','5'],
            ['.','.','.','.','8','.','.','7','9']
        };
        Assert.True(new ValidSudoku().IsValidSudoku(board));
    }

    [Fact]
    public void Example2_Invalid()
    {
        var board = new char[][]
        {
            ['8','3','.','.','7','.','.','.','.'],
            ['6','.','.','1','9','5','.','.','.'],
            ['.','9','8','.','.','.','.','6','.'],
            ['8','.','.','.','6','.','.','.','3'],
            ['4','.','.','8','.','3','.','.','1'],
            ['7','.','.','.','2','.','.','.','6'],
            ['.','6','.','.','.','.','2','8','.'],
            ['.','.','.','4','1','9','.','.','5'],
            ['.','.','.','.','8','.','.','7','9']
        };
        Assert.False(new ValidSudoku().IsValidSudoku(board));
    }

    [Fact]
    public void DuplicateInRow()
    {
        var board = CreateEmptyBoard();
        board[0][0] = '1';
        board[0][1] = '1';
        Assert.False(new ValidSudoku().IsValidSudoku(board));
    }

    [Fact]
    public void DuplicateInColumn()
    {
        var board = CreateEmptyBoard();
        board[0][0] = '1';
        board[1][0] = '1';
        Assert.False(new ValidSudoku().IsValidSudoku(board));
    }

    [Fact]
    public void DuplicateInBox()
    {
        var board = CreateEmptyBoard();
        board[0][0] = '1';
        board[2][2] = '1';
        Assert.False(new ValidSudoku().IsValidSudoku(board));
    }

    [Fact]
    public void AllEmpty()
    {
        var board = CreateEmptyBoard();
        Assert.True(new ValidSudoku().IsValidSudoku(board));
    }

    private char[][] CreateEmptyBoard()
    {
        var board = new char[9][];
        for (int i = 0; i < 9; i++)
        {
            board[i] = ['.', '.', '.', '.', '.', '.', '.', '.', '.'];
        }
        return board;
    }
}
