public class WordSearchTests
{
    [Fact]
    public void Example1()
    {
        char[][] board = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        Assert.True(new WordSearch().Exist(board, "ABCCED"));
    }

    [Fact]
    public void Example2()
    {
        char[][] board = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        Assert.True(new WordSearch().Exist(board, "SEE"));
    }

    [Fact]
    public void Example3()
    {
        char[][] board = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        Assert.False(new WordSearch().Exist(board, "ABCB"));
    }

    [Fact]
    public void SingleCellFound()
    {
        char[][] board = [['A']];
        Assert.True(new WordSearch().Exist(board, "A"));
    }

    [Fact]
    public void SingleCellNotFound()
    {
        char[][] board = [['A']];
        Assert.False(new WordSearch().Exist(board, "B"));
    }

    [Fact]
    public void WordLongerThanGrid()
    {
        char[][] board = [['A', 'B'], ['C', 'D']];
        Assert.False(new WordSearch().Exist(board, "ABCDA"));
    }

    [Fact]
    public void NoReuse()
    {
        char[][] board = [['A', 'A']];
        Assert.False(new WordSearch().Exist(board, "AAA"));
    }
}
