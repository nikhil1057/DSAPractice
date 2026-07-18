public class MaxAreaOfIslandTests
{
    [Fact]
    public void Example1()
    {
        int[][] grid = [[0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
                        [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                        [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
                        [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0],
                        [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0],
                        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
                        [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                        [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]];
        Assert.Equal(6, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }

    [Fact]
    public void Example2_NoIsland()
    {
        int[][] grid = [[0, 0, 0, 0, 0, 0, 0, 0]];
        Assert.Equal(0, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }

    [Fact]
    public void SingleCellIsland()
    {
        int[][] grid = [[0, 1, 0], [0, 0, 0]];
        Assert.Equal(1, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }

    [Fact]
    public void EntireGridIsland()
    {
        int[][] grid = [[1, 1], [1, 1]];
        Assert.Equal(4, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }

    [Fact]
    public void NoIslands()
    {
        int[][] grid = [[0, 0], [0, 0]];
        Assert.Equal(0, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }

    [Fact]
    public void LShapedIsland()
    {
        int[][] grid = [[1, 0], [1, 0], [1, 1]];
        Assert.Equal(4, new MaxAreaOfIsland().MaxAreaOfIslandSolve(grid));
    }
}
