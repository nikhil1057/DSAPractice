public class InsertIntervalTests
{
    [Fact]
    public void Example1()
    {
        int[][] result = new InsertInterval().Insert([[1, 3], [6, 9]], [2, 5]);
        Assert.Equal([[1, 5], [6, 9]], result);
    }

    [Fact]
    public void Example2()
    {
        int[][] result = new InsertInterval().Insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]);
        Assert.Equal([[1, 2], [3, 10], [12, 16]], result);
    }

    [Fact]
    public void EmptyIntervals()
    {
        int[][] result = new InsertInterval().Insert([], [5, 7]);
        Assert.Equal([[5, 7]], result);
    }

    [Fact]
    public void NoOverlapBefore()
    {
        int[][] result = new InsertInterval().Insert([[3, 5], [6, 9]], [1, 2]);
        Assert.Equal([[1, 2], [3, 5], [6, 9]], result);
    }

    [Fact]
    public void NoOverlapAfter()
    {
        int[][] result = new InsertInterval().Insert([[1, 2], [3, 5]], [6, 8]);
        Assert.Equal([[1, 2], [3, 5], [6, 8]], result);
    }

    [Fact]
    public void MergeAll()
    {
        int[][] result = new InsertInterval().Insert([[1, 3], [4, 6], [7, 9]], [2, 8]);
        Assert.Equal([[1, 9]], result);
    }
}
