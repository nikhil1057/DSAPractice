public class BestTimeToBuyAndSellStockWithCooldownTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([1, 2, 3, 0, 2]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([1]));
    }

    [Fact]
    public void DecreasingPrices()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void TwoElementsProfit()
    {
        Assert.Equal(3, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([1, 4]));
    }

    [Fact]
    public void TwoElementsNoProfit()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([4, 1]));
    }

    [Fact]
    public void CooldownMatters()
    {
        Assert.Equal(5, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([1, 5, 2, 6]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(0, new BestTimeToBuyAndSellStockWithCooldown().MaxProfit([3, 3, 3, 3]));
    }
}
