public class UniquePathsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(28, new UniquePaths().UniquePath(3, 7));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3, new UniquePaths().UniquePath(3, 2));
    }

    [Fact]
    public void Grid1x1()
    {
        Assert.Equal(1, new UniquePaths().UniquePath(1, 1));
    }

    [Fact]
    public void Grid1xN()
    {
        Assert.Equal(1, new UniquePaths().UniquePath(1, 5));
    }

    [Fact]
    public void GridNx1()
    {
        Assert.Equal(1, new UniquePaths().UniquePath(5, 1));
    }

    [Fact]
    public void Grid2x2()
    {
        Assert.Equal(2, new UniquePaths().UniquePath(2, 2));
    }

    [Fact]
    public void Grid3x3()
    {
        Assert.Equal(6, new UniquePaths().UniquePath(3, 3));
    }

    [Fact]
    public void Grid7x3()
    {
        Assert.Equal(28, new UniquePaths().UniquePath(7, 3));
    }
}
