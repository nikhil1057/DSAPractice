public class MinCostToConnectAllPointsTests
{
    [Fact]
    public void Example1()
    {
        int[][] points = [[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]];
        Assert.Equal(20, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void Example2()
    {
        int[][] points = [[3, 12], [-2, 5], [-4, 1]];
        Assert.Equal(18, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void TwoPoints()
    {
        int[][] points = [[0, 0], [1, 1]];
        Assert.Equal(2, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void SinglePoint()
    {
        int[][] points = [[0, 0]];
        Assert.Equal(0, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void CollinearPoints()
    {
        int[][] points = [[0, 0], [1, 0], [2, 0], [3, 0]];
        Assert.Equal(3, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void SamePoint()
    {
        int[][] points = [[0, 0], [0, 0]];
        Assert.Equal(0, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }

    [Fact]
    public void NegativeCoordinates()
    {
        int[][] points = [[-1, -1], [1, 1], [-1, 1], [1, -1]];
        Assert.Equal(8, new MinCostToConnectAllPoints().MinCostConnectPoints(points));
    }
}
