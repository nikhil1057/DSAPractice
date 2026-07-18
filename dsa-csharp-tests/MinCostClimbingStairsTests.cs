public class MinCostClimbingStairsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(15, new MinCostClimbingStairs().MinCostClimbingStairsSolution([10, 15, 20]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(6, new MinCostClimbingStairs().MinCostClimbingStairsSolution([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]));
    }

    [Fact]
    public void TwoSteps()
    {
        Assert.Equal(10, new MinCostClimbingStairs().MinCostClimbingStairsSolution([10, 15]));
    }

    [Fact]
    public void AllSameCost()
    {
        Assert.Equal(10, new MinCostClimbingStairs().MinCostClimbingStairsSolution([5, 5, 5, 5]));
    }

    [Fact]
    public void IncreasingCost()
    {
        Assert.Equal(6, new MinCostClimbingStairs().MinCostClimbingStairsSolution([1, 2, 3, 4, 5]));
    }

    [Fact]
    public void DecreasingCost()
    {
        Assert.Equal(6, new MinCostClimbingStairs().MinCostClimbingStairsSolution([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void ZeroCosts()
    {
        Assert.Equal(0, new MinCostClimbingStairs().MinCostClimbingStairsSolution([0, 0, 0]));
    }
}
