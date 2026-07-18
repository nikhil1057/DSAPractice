public class BestTimeToBuyAndSellStockTests
{
    [Fact]
    public void Example1()
    {
        // Buy on day 2 (price=1), sell on day 5 (price=6), profit = 5
        Assert.Equal(5, new BestTimeToBuyAndSellStock().MaxProfit([7, 1, 5, 3, 6, 4]));
    }

    [Fact]
    public void Example2()
    {
        // Prices only decrease, no profit possible
        Assert.Equal(0, new BestTimeToBuyAndSellStock().MaxProfit([7, 6, 4, 3, 1]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStock().MaxProfit([5]));
    }

    [Fact]
    public void TwoElements_Profit()
    {
        Assert.Equal(4, new BestTimeToBuyAndSellStock().MaxProfit([1, 5]));
    }

    [Fact]
    public void TwoElements_NoProfit()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStock().MaxProfit([5, 1]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStock().MaxProfit([3, 3, 3, 3]));
    }

    [Fact]
    public void ProfitAtEnd()
    {
        Assert.Equal(6, new BestTimeToBuyAndSellStock().MaxProfit([2, 4, 1, 7]));
    }

    [Fact]
    public void LargeDipThenRise()
    {
        Assert.Equal(4, new BestTimeToBuyAndSellStock().MaxProfit([10, 1, 2, 3, 4, 5]));
    }
}
