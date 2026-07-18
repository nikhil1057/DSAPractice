public class KClosestPointsToOriginTests
{
    [Fact]
    public void Example1()
    {
        var result = new KClosestPointsToOrigin().KClosest([[1, 3], [-2, 2]], 1);
        Assert.Single(result);
        Assert.Equal([-2, 2], result[0]);
    }

    [Fact]
    public void Example2()
    {
        var result = new KClosestPointsToOrigin().KClosest([[3, 3], [5, -1], [-2, 4]], 2);
        Assert.Equal(2, result.Length);
        // Sort for comparison
        var sorted = result.OrderBy(p => p[0]).ThenBy(p => p[1]).ToArray();
        Assert.Equal([-2, 4], sorted[0]);
        Assert.Equal([3, 3], sorted[1]);
    }

    [Fact]
    public void SinglePoint()
    {
        var result = new KClosestPointsToOrigin().KClosest([[1, 1]], 1);
        Assert.Equal([[1, 1]], result);
    }

    [Fact]
    public void KEqualsN()
    {
        int[][] points = [[1, 2], [3, 4], [0, 1]];
        var result = new KClosestPointsToOrigin().KClosest(points, 3);
        Assert.Equal(3, result.Length);
    }

    [Fact]
    public void OriginPoint()
    {
        var result = new KClosestPointsToOrigin().KClosest([[0, 0], [1, 1], [2, 2]], 1);
        Assert.Equal([0, 0], result[0]);
    }

    [Fact]
    public void NegativeCoords()
    {
        var result = new KClosestPointsToOrigin().KClosest([[-1, -1], [-2, -2], [1, 1]], 2);
        Assert.Equal(2, result.Length);
    }
}
