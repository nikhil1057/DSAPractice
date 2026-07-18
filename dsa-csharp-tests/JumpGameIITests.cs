public class JumpGameIITests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new JumpGameII().Jump([2, 3, 1, 1, 4]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(2, new JumpGameII().Jump([2, 3, 0, 1, 4]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(0, new JumpGameII().Jump([0]));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(1, new JumpGameII().Jump([1, 0]));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(3, new JumpGameII().Jump([1, 1, 1, 1]));
    }

    [Fact]
    public void LargeFirstJump()
    {
        Assert.Equal(1, new JumpGameII().Jump([5, 0, 0, 0, 0, 0]));
    }

    [Fact]
    public void OptimalGreedy()
    {
        Assert.Equal(3, new JumpGameII().Jump([1, 2, 3, 4, 5]));
    }
}
