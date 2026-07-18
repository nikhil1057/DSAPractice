public class SetMatrixZeroesTests
{
    [Fact]
    public void Example1()
    {
        int[][] matrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[1, 0, 1], [0, 0, 0], [1, 0, 1]], matrix);
    }

    [Fact]
    public void Example2()
    {
        int[][] matrix = [[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[0, 0, 0, 0], [0, 4, 5, 0], [0, 3, 1, 0]], matrix);
    }

    [Fact]
    public void NoZeros()
    {
        int[][] matrix = [[1, 2], [3, 4]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[1, 2], [3, 4]], matrix);
    }

    [Fact]
    public void AllZeros()
    {
        int[][] matrix = [[0, 0], [0, 0]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[0, 0], [0, 0]], matrix);
    }

    [Fact]
    public void SingleElementZero()
    {
        int[][] matrix = [[0]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[0]], matrix);
    }

    [Fact]
    public void CornerZero()
    {
        int[][] matrix = [[0, 1], [1, 1]];
        new SetMatrixZeroes().SetZeroes(matrix);
        Assert.Equal([[0, 0], [0, 1]], matrix);
    }
}
