public class SwimInRisingWaterTests
{
    [Fact]
    public void Example1()
    {
        int[][] grid = [[0, 2], [1, 3]];
        Assert.Equal(3, new SwimInRisingWater().SwimInWater(grid));
    }

    [Fact]
    public void Example2()
    {
        int[][] grid = [
            [0, 1, 2, 3, 4],
            [24, 23, 22, 21, 5],
            [12, 13, 14, 15, 16],
            [11, 17, 18, 19, 20],
            [10, 9, 8, 7, 6]
        ];
        Assert.Equal(16, new SwimInRisingWater().SwimInWater(grid));
    }

    [Fact]
    public void SingleCell()
    {
        int[][] grid = [[0]];
        Assert.Equal(0, new SwimInRisingWater().SwimInWater(grid));
    }

    [Fact]
    public void TwoByTwoSimple()
    {
        int[][] grid = [[0, 1], [2, 3]];
        Assert.Equal(3, new SwimInRisingWater().SwimInWater(grid));
    }

    [Fact]
    public void ThreeByThree()
    {
        int[][] grid = [[0, 1, 2], [5, 4, 3], [6, 7, 8]];
        Assert.Equal(8, new SwimInRisingWater().SwimInWater(grid));
    }

    [Fact]
    public void AlreadyConnected()
    {
        int[][] grid = [[0, 1], [1, 2]];
        Assert.Equal(2, new SwimInRisingWater().SwimInWater(grid));
    }
}
