public class PacificAtlanticWaterFlowTests
{
    [Fact]
    public void Example1()
    {
        int[][] heights = [[1, 2, 2, 3, 5], [3, 2, 3, 4, 4], [2, 4, 5, 3, 1], [6, 7, 1, 4, 5], [5, 1, 1, 2, 4]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        Assert.Equal(7, result.Count);
    }

    [Fact]
    public void Example2_SingleCell()
    {
        int[][] heights = [[1]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        Assert.Single(result);
    }

    [Fact]
    public void FlatGrid()
    {
        int[][] heights = [[1, 1], [1, 1]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        Assert.Equal(4, result.Count); // All cells can reach both
    }

    [Fact]
    public void SingleRow()
    {
        int[][] heights = [[1, 2, 3]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        Assert.Equal(3, result.Count); // All cells on border reach both
    }

    [Fact]
    public void SingleColumn()
    {
        int[][] heights = [[1], [2], [3]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void IncreasingGrid()
    {
        int[][] heights = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        var result = new PacificAtlanticWaterFlow().PacificAtlantic(heights);
        // Bottom-right should be in result
        Assert.Contains(result, r => r[0] == 2 && r[1] == 2);
    }
}
