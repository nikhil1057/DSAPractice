public class CoinChangeTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new CoinChange().CoinChangeSolution([1, 5, 10], 11));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(-1, new CoinChange().CoinChangeSolution([2], 3));
    }

    [Fact]
    public void ZeroAmount()
    {
        Assert.Equal(0, new CoinChange().CoinChangeSolution([1], 0));
    }

    [Fact]
    public void SingleCoinExact()
    {
        Assert.Equal(1, new CoinChange().CoinChangeSolution([5], 5));
    }

    [Fact]
    public void MultipleSameCoin()
    {
        Assert.Equal(5, new CoinChange().CoinChangeSolution([1], 5));
    }

    [Fact]
    public void Impossible()
    {
        Assert.Equal(-1, new CoinChange().CoinChangeSolution([3, 7], 5));
    }

    [Fact]
    public void LargeAmount()
    {
        Assert.Equal(4, new CoinChange().CoinChangeSolution([1, 5, 10, 25], 100));
    }

    [Fact]
    public void GreedyFails()
    {
        // [1,3,4] amount=6 => 3+3=2 coins optimal
        Assert.Equal(2, new CoinChange().CoinChangeSolution([1, 3, 4], 6));
    }
}
