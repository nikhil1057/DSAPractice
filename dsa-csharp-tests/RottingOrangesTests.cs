public class RottingOrangesTests
{
    [Fact]
    public void Example1()
    {
        int[][] grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]];
        Assert.Equal(4, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void Example2_Impossible()
    {
        int[][] grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]];
        Assert.Equal(-1, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void Example3_NoFresh()
    {
        int[][] grid = [[0, 2]];
        Assert.Equal(0, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void AllRotten()
    {
        int[][] grid = [[2, 2], [2, 2]];
        Assert.Equal(0, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void NoOranges()
    {
        int[][] grid = [[0, 0], [0, 0]];
        Assert.Equal(0, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void SingleFresh()
    {
        int[][] grid = [[1]];
        Assert.Equal(-1, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void AdjacentRotten()
    {
        int[][] grid = [[2, 1]];
        Assert.Equal(1, new RottingOranges().OrangesRotting(grid));
    }

    [Fact]
    public void MultipleRottenSources()
    {
        int[][] grid = [[2, 1, 1, 1, 2]];
        Assert.Equal(1, new RottingOranges().OrangesRotting(grid));
    }
}
