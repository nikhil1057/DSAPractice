public class SpiralMatrixTests
{
    [Fact]
    public void Example1()
    {
        var result = new SpiralMatrix().SpiralOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
        Assert.Equal(new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result);
    }

    [Fact]
    public void Example2()
    {
        var result = new SpiralMatrix().SpiralOrder([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]);
        Assert.Equal(new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }, result);
    }

    [Fact]
    public void SingleElement()
    {
        var result = new SpiralMatrix().SpiralOrder([[1]]);
        Assert.Equal(new List<int> { 1 }, result);
    }

    [Fact]
    public void SingleRow()
    {
        var result = new SpiralMatrix().SpiralOrder([[1, 2, 3, 4]]);
        Assert.Equal(new List<int> { 1, 2, 3, 4 }, result);
    }

    [Fact]
    public void SingleColumn()
    {
        var result = new SpiralMatrix().SpiralOrder([[1], [2], [3]]);
        Assert.Equal(new List<int> { 1, 2, 3 }, result);
    }

    [Fact]
    public void Grid2x2()
    {
        var result = new SpiralMatrix().SpiralOrder([[1, 2], [3, 4]]);
        Assert.Equal(new List<int> { 1, 2, 4, 3 }, result);
    }
}
