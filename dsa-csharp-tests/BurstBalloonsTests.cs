public class BurstBalloonsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(167, new BurstBalloons().MaxCoins([3, 1, 5, 8]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(10, new BurstBalloons().MaxCoins([1, 5]));
    }

    [Fact]
    public void SingleBalloon()
    {
        Assert.Equal(5, new BurstBalloons().MaxCoins([5]));
    }

    [Fact]
    public void TwoSameBalloons()
    {
        Assert.Equal(12, new BurstBalloons().MaxCoins([3, 3]));
    }

    [Fact]
    public void Increasing()
    {
        Assert.Equal(12, new BurstBalloons().MaxCoins([1, 2, 3]));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(3, new BurstBalloons().MaxCoins([1, 1, 1]));
    }
}
