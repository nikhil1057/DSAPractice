public class TargetSumTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(5, new TargetSum().FindTargetSumWays([1, 1, 1, 1, 1], 3));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new TargetSum().FindTargetSumWays([1], 1));
    }

    [Fact]
    public void SingleElementNegative()
    {
        Assert.Equal(1, new TargetSum().FindTargetSumWays([1], -1));
    }

    [Fact]
    public void ImpossibleTarget()
    {
        Assert.Equal(0, new TargetSum().FindTargetSumWays([1, 2], 4));
    }

    [Fact]
    public void WithZeros()
    {
        Assert.Equal(4, new TargetSum().FindTargetSumWays([0, 0, 1], 1));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(3, new TargetSum().FindTargetSumWays([2, 2, 2], 2));
    }

    [Fact]
    public void TargetZero()
    {
        Assert.Equal(6, new TargetSum().FindTargetSumWays([1, 1, 1, 1], 0));
    }
}
