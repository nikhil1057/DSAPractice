public class NQueensTests
{
    [Fact]
    public void Example1()
    {
        var result = new NQueens().SolveNQueens(4);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Example2()
    {
        var result = new NQueens().SolveNQueens(1);
        Assert.Single(result);
        Assert.Equal("Q", result[0][0]);
    }

    [Fact]
    public void NEquals2_NoSolution()
    {
        var result = new NQueens().SolveNQueens(2);
        Assert.Empty(result);
    }

    [Fact]
    public void NEquals3_NoSolution()
    {
        var result = new NQueens().SolveNQueens(3);
        Assert.Empty(result);
    }

    [Fact]
    public void NEquals5()
    {
        var result = new NQueens().SolveNQueens(5);
        Assert.Equal(10, result.Count);
    }

    [Fact]
    public void BoardSizeCorrect()
    {
        var result = new NQueens().SolveNQueens(4);
        foreach (var board in result)
        {
            Assert.Equal(4, board.Count);
            foreach (var row in board)
            {
                Assert.Equal(4, row.Length);
            }
        }
    }

    [Fact]
    public void OneQueenPerRow()
    {
        var result = new NQueens().SolveNQueens(4);
        foreach (var board in result)
        {
            foreach (var row in board)
            {
                Assert.Equal(1, row.Count(c => c == 'Q'));
            }
        }
    }
}
