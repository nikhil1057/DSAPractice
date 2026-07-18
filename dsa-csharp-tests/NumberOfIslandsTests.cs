public class NumberOfIslandsTests
{
    [Fact]
    public void Example1()
    {
        char[][] grid = [['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'],
                         ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0']];
        Assert.Equal(1, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void Example2()
    {
        char[][] grid = [['1', '1', '0', '0', '0'], ['1', '1', '0', '0', '0'],
                         ['0', '0', '1', '0', '0'], ['0', '0', '0', '1', '1']];
        Assert.Equal(3, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void AllWater()
    {
        char[][] grid = [['0', '0', '0'], ['0', '0', '0']];
        Assert.Equal(0, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void AllLand()
    {
        char[][] grid = [['1', '1'], ['1', '1']];
        Assert.Equal(1, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void SingleCellLand()
    {
        char[][] grid = [['1']];
        Assert.Equal(1, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void DiagonalNotConnected()
    {
        char[][] grid = [['1', '0'], ['0', '1']];
        Assert.Equal(2, new NumberOfIslands().NumIslands(grid));
    }

    [Fact]
    public void ManyIslands()
    {
        char[][] grid = [['1', '0', '1', '0', '1'], ['0', '0', '0', '0', '0'], ['1', '0', '1', '0', '1']];
        Assert.Equal(6, new NumberOfIslands().NumIslands(grid));
    }
}
