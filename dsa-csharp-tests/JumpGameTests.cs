public class JumpGameTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new JumpGame().CanJump([2, 3, 1, 1, 4]));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new JumpGame().CanJump([3, 2, 1, 0, 4]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.True(new JumpGame().CanJump([0]));
    }

    [Fact]
    public void TwoElementsCan()
    {
        Assert.True(new JumpGame().CanJump([1, 0]));
    }

    [Fact]
    public void TwoElementsCannot()
    {
        Assert.False(new JumpGame().CanJump([0, 1]));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.True(new JumpGame().CanJump([1, 1, 1, 1]));
    }

    [Fact]
    public void LargeFirstJump()
    {
        Assert.True(new JumpGame().CanJump([5, 0, 0, 0, 0, 0]));
    }
}
