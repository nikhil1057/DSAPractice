public class CoinChangeIITests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new CoinChangeII().Change(5, [1, 2, 5]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(0, new CoinChangeII().Change(3, [2]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(1, new CoinChangeII().Change(10, [10]));
    }

    [Fact]
    public void AmountZero()
    {
        Assert.Equal(1, new CoinChangeII().Change(0, [1, 2, 5]));
    }

    [Fact]
    public void SingleCoin()
    {
        Assert.Equal(1, new CoinChangeII().Change(4, [1]));
    }

    [Fact]
    public void NoCoins()
    {
        Assert.Equal(0, new CoinChangeII().Change(5, []));
    }

    [Fact]
    public void Impossible()
    {
        Assert.Equal(0, new CoinChangeII().Change(3, [5, 7]));
    }
}
