public class ClimbingStairsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new ClimbingStairs().ClimbStairs(2));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3, new ClimbingStairs().ClimbStairs(3));
    }

    [Fact]
    public void OneStep()
    {
        Assert.Equal(1, new ClimbingStairs().ClimbStairs(1));
    }

    [Fact]
    public void FourSteps()
    {
        Assert.Equal(5, new ClimbingStairs().ClimbStairs(4));
    }

    [Fact]
    public void FiveSteps()
    {
        Assert.Equal(8, new ClimbingStairs().ClimbStairs(5));
    }

    [Fact]
    public void LargeN()
    {
        Assert.Equal(89, new ClimbingStairs().ClimbStairs(10));
    }

    [Fact]
    public void FibonacciProperty()
    {
        Assert.Equal(13, new ClimbingStairs().ClimbStairs(6));
    }
}
