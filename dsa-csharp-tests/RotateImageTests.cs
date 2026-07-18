public class RotateImageTests
{
    [Fact]
    public void Example1()
    {
        int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        new RotateImage().Rotate(matrix);
        Assert.Equal([[7, 4, 1], [8, 5, 2], [9, 6, 3]], matrix);
    }

    [Fact]
    public void Example2()
    {
        int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
        new RotateImage().Rotate(matrix);
        Assert.Equal([[15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]], matrix);
    }

    [Fact]
    public void Grid1x1()
    {
        int[][] matrix = [[1]];
        new RotateImage().Rotate(matrix);
        Assert.Equal([[1]], matrix);
    }

    [Fact]
    public void Grid2x2()
    {
        int[][] matrix = [[1, 2], [3, 4]];
        new RotateImage().Rotate(matrix);
        Assert.Equal([[3, 1], [4, 2]], matrix);
    }

    [Fact]
    public void AllSame()
    {
        int[][] matrix = [[5, 5], [5, 5]];
        new RotateImage().Rotate(matrix);
        Assert.Equal([[5, 5], [5, 5]], matrix);
    }
}
