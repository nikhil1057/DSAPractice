public class LongestIncreasingPathInAMatrixTests
{
    [Fact]
    public void Example1()
    {
        int[][] matrix = [[9, 9, 4], [6, 6, 8], [2, 1, 1]];
        Assert.Equal(4, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }

    [Fact]
    public void Example2()
    {
        int[][] matrix = [[3, 4, 5], [3, 2, 6], [2, 2, 1]];
        Assert.Equal(4, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }

    [Fact]
    public void SingleCell()
    {
        int[][] matrix = [[1]];
        Assert.Equal(1, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }

    [Fact]
    public void SingleRow()
    {
        int[][] matrix = [[1, 2, 3, 4]];
        Assert.Equal(4, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }

    [Fact]
    public void AllSame()
    {
        int[][] matrix = [[5, 5], [5, 5]];
        Assert.Equal(1, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }

    [Fact]
    public void DecreasingDiagonal()
    {
        int[][] matrix = [[9, 8, 7], [6, 5, 4], [3, 2, 1]];
        Assert.Equal(5, new LongestIncreasingPathInAMatrix().LongestIncreasingPath(matrix));
    }
}
