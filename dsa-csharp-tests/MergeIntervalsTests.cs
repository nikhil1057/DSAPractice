public class MergeIntervalsTests
{
    [Fact]
    public void Example1()
    {
        int[][] result = new MergeIntervals().Merge([[1, 3], [2, 6], [8, 10], [15, 18]]);
        Assert.Equal([[1, 6], [8, 10], [15, 18]], result);
    }

    [Fact]
    public void Example2()
    {
        int[][] result = new MergeIntervals().Merge([[1, 4], [4, 5]]);
        Assert.Equal([[1, 5]], result);
    }

    [Fact]
    public void NoOverlap()
    {
        int[][] result = new MergeIntervals().Merge([[1, 2], [4, 5], [7, 8]]);
        Assert.Equal([[1, 2], [4, 5], [7, 8]], result);
    }

    [Fact]
    public void AllOverlap()
    {
        int[][] result = new MergeIntervals().Merge([[1, 4], [2, 5], [3, 6]]);
        Assert.Equal([[1, 6]], result);
    }

    [Fact]
    public void SingleInterval()
    {
        int[][] result = new MergeIntervals().Merge([[1, 5]]);
        Assert.Equal([[1, 5]], result);
    }

    [Fact]
    public void NestedIntervals()
    {
        int[][] result = new MergeIntervals().Merge([[1, 10], [2, 3], [4, 5]]);
        Assert.Equal([[1, 10]], result);
    }
}
