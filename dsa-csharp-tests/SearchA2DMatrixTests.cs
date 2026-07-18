public class SearchA2DMatrixTests
{
    [Fact]
    public void Example1()
    {
        var matrix = new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } };
        Assert.True(new SearchA2DMatrix().SearchMatrix(matrix, 3));
    }

    [Fact]
    public void Example2()
    {
        var matrix = new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } };
        Assert.False(new SearchA2DMatrix().SearchMatrix(matrix, 13));
    }

    [Fact]
    public void SingleElementFound()
    {
        Assert.True(new SearchA2DMatrix().SearchMatrix(new[] { new[] { 1 } }, 1));
    }

    [Fact]
    public void SingleElementNotFound()
    {
        Assert.False(new SearchA2DMatrix().SearchMatrix(new[] { new[] { 1 } }, 2));
    }

    [Fact]
    public void FirstElement()
    {
        var matrix = new[] { new[] { 1, 3, 5 }, new[] { 7, 9, 11 } };
        Assert.True(new SearchA2DMatrix().SearchMatrix(matrix, 1));
    }

    [Fact]
    public void LastElement()
    {
        var matrix = new[] { new[] { 1, 3, 5 }, new[] { 7, 9, 11 } };
        Assert.True(new SearchA2DMatrix().SearchMatrix(matrix, 11));
    }

    [Fact]
    public void TargetBetweenRows()
    {
        var matrix = new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 } };
        Assert.False(new SearchA2DMatrix().SearchMatrix(matrix, 8));
    }

    [Fact]
    public void SingleRow()
    {
        var matrix = new[] { new[] { 1, 3, 5, 7, 9 } };
        Assert.True(new SearchA2DMatrix().SearchMatrix(matrix, 5));
    }
}
