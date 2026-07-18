public class WallsAndGatesTests
{
    private const int INF = 2147483647;

    [Fact]
    public void Example1()
    {
        int[][] rooms = [[INF, -1, 0, INF], [INF, INF, INF, -1], [INF, -1, INF, -1], [0, -1, INF, INF]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        int[][] expected = [[3, -1, 0, 1], [2, 2, 1, -1], [1, -1, 2, -1], [0, -1, 3, 4]];
        Assert.Equal(expected, rooms);
    }

    [Fact]
    public void SingleWall()
    {
        int[][] rooms = [[-1]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        Assert.Equal([[-1]], rooms);
    }

    [Fact]
    public void SingleGate()
    {
        int[][] rooms = [[0]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        Assert.Equal([[0]], rooms);
    }

    [Fact]
    public void AllEmpty_NoGates()
    {
        int[][] rooms = [[INF, INF], [INF, INF]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        Assert.Equal([[INF, INF], [INF, INF]], rooms);
    }

    [Fact]
    public void GateSurroundedByRooms()
    {
        int[][] rooms = [[INF, INF, INF], [INF, 0, INF], [INF, INF, INF]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        int[][] expected = [[2, 1, 2], [1, 0, 1], [2, 1, 2]];
        Assert.Equal(expected, rooms);
    }

    [Fact]
    public void MultipleGates()
    {
        int[][] rooms = [[0, INF, INF], [INF, INF, INF], [INF, INF, 0]];
        new WallsAndGates().WallsAndGatesSolve(rooms);
        int[][] expected = [[0, 1, 2], [1, 2, 1], [2, 1, 0]];
        Assert.Equal(expected, rooms);
    }
}
