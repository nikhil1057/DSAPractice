public class NetworkDelayTimeTests
{
    [Fact]
    public void Example1()
    {
        int[][] times = [[2, 1, 1], [2, 3, 1], [3, 4, 1]];
        Assert.Equal(2, new NetworkDelayTime().NetworkDelay(times, 4, 2));
    }

    [Fact]
    public void Example2()
    {
        int[][] times = [[1, 2, 1]];
        Assert.Equal(1, new NetworkDelayTime().NetworkDelay(times, 2, 1));
    }

    [Fact]
    public void Unreachable()
    {
        int[][] times = [[1, 2, 1]];
        Assert.Equal(-1, new NetworkDelayTime().NetworkDelay(times, 2, 2));
    }

    [Fact]
    public void SingleNode()
    {
        int[][] times = [];
        Assert.Equal(0, new NetworkDelayTime().NetworkDelay(times, 1, 1));
    }

    [Fact]
    public void MultiplePaths()
    {
        int[][] times = [[1, 2, 1], [1, 3, 4], [2, 3, 2]];
        Assert.Equal(3, new NetworkDelayTime().NetworkDelay(times, 3, 1));
    }

    [Fact]
    public void DisconnectedGraph()
    {
        int[][] times = [[1, 2, 1]];
        Assert.Equal(-1, new NetworkDelayTime().NetworkDelay(times, 3, 1));
    }

    [Fact]
    public void LargeWeights()
    {
        int[][] times = [[1, 2, 100], [2, 3, 100]];
        Assert.Equal(200, new NetworkDelayTime().NetworkDelay(times, 3, 1));
    }
}
