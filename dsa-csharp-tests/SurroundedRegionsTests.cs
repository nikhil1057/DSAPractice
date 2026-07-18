public class SurroundedRegionsTests
{
    [Fact]
    public void Example1()
    {
        char[][] board = [['X', 'X', 'X', 'X'], ['X', 'O', 'O', 'X'], ['X', 'X', 'O', 'X'], ['X', 'O', 'X', 'X']];
        new SurroundedRegions().Solve(board);
        char[][] expected = [['X', 'X', 'X', 'X'], ['X', 'X', 'X', 'X'], ['X', 'X', 'X', 'X'], ['X', 'O', 'X', 'X']];
        Assert.Equal(expected, board);
    }

    [Fact]
    public void SingleCell()
    {
        char[][] board = [['X']];
        new SurroundedRegions().Solve(board);
        Assert.Equal([['X']], board);
    }

    [Fact]
    public void AllOOnBorder()
    {
        char[][] board = [['O', 'O'], ['O', 'O']];
        new SurroundedRegions().Solve(board);
        Assert.Equal([['O', 'O'], ['O', 'O']], board);
    }

    [Fact]
    public void NoO()
    {
        char[][] board = [['X', 'X'], ['X', 'X']];
        new SurroundedRegions().Solve(board);
        Assert.Equal([['X', 'X'], ['X', 'X']], board);
    }

    [Fact]
    public void SurroundedO()
    {
        char[][] board = [['X', 'X', 'X'], ['X', 'O', 'X'], ['X', 'X', 'X']];
        new SurroundedRegions().Solve(board);
        char[][] expected = [['X', 'X', 'X'], ['X', 'X', 'X'], ['X', 'X', 'X']];
        Assert.Equal(expected, board);
    }

    [Fact]
    public void OConnectedToBorder()
    {
        char[][] board = [['X', 'O', 'X'], ['O', 'O', 'X'], ['X', 'X', 'X']];
        new SurroundedRegions().Solve(board);
        char[][] expected = [['X', 'O', 'X'], ['O', 'O', 'X'], ['X', 'X', 'X']];
        Assert.Equal(expected, board);
    }
}
