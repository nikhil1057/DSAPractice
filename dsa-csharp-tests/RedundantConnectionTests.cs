public class RedundantConnectionTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal([2, 3], new RedundantConnection().FindRedundantConnection([[1, 2], [1, 3], [2, 3]]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal([1, 4], new RedundantConnection().FindRedundantConnection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]));
    }

    [Fact]
    public void ThreeNodeCycle()
    {
        Assert.Equal([1, 3], new RedundantConnection().FindRedundantConnection([[1, 2], [2, 3], [1, 3]]));
    }

    [Fact]
    public void FourNodeCycle()
    {
        Assert.Equal([4, 1], new RedundantConnection().FindRedundantConnection([[1, 2], [2, 3], [3, 4], [4, 1]]));
    }

    [Fact]
    public void LastEdgeRedundant()
    {
        Assert.Equal([3, 4], new RedundantConnection().FindRedundantConnection([[1, 2], [1, 3], [1, 4], [3, 4]]));
    }

    [Fact]
    public void LinearWithCycleAtEnd()
    {
        Assert.Equal([3, 5], new RedundantConnection().FindRedundantConnection([[1, 2], [2, 3], [3, 4], [4, 5], [3, 5]]));
    }
}
