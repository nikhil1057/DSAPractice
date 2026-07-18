public class MinimumIntervalToIncludeEachQueryTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal([3, 3, 1, 4], new MinimumIntervalToIncludeEachQuery().MinInterval([[1, 4], [2, 4], [3, 6], [4, 4]], [2, 3, 4, 5]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal([2, -1, 4, 6], new MinimumIntervalToIncludeEachQuery().MinInterval([[2, 3], [2, 5], [1, 8], [20, 25]], [2, 19, 5, 22]));
    }

    [Fact]
    public void NoIntervals()
    {
        Assert.Equal([-1, -1, -1], new MinimumIntervalToIncludeEachQuery().MinInterval([], [1, 2, 3]));
    }

    [Fact]
    public void SingleInterval()
    {
        Assert.Equal([5, -1], new MinimumIntervalToIncludeEachQuery().MinInterval([[1, 5]], [3, 6]));
    }

    [Fact]
    public void QueryAtBoundary()
    {
        Assert.Equal([3, 3, -1, 3], new MinimumIntervalToIncludeEachQuery().MinInterval([[1, 3], [5, 7]], [1, 3, 4, 5]));
    }

    [Fact]
    public void OverlappingIntervals()
    {
        Assert.Equal([2], new MinimumIntervalToIncludeEachQuery().MinInterval([[1, 10], [2, 3]], [2]));
    }
}
