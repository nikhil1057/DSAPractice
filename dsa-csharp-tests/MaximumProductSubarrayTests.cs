public class MaximumProductSubarrayTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(6, new MaximumProductSubarray().MaxProduct([2, 3, -2, 4]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(0, new MaximumProductSubarray().MaxProduct([-2, 0, -1]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(3, new MaximumProductSubarray().MaxProduct([3]));
    }

    [Fact]
    public void SingleNegative()
    {
        Assert.Equal(-2, new MaximumProductSubarray().MaxProduct([-2]));
    }

    [Fact]
    public void TwoNegatives()
    {
        Assert.Equal(6, new MaximumProductSubarray().MaxProduct([-2, -3]));
    }

    [Fact]
    public void AllPositive()
    {
        Assert.Equal(24, new MaximumProductSubarray().MaxProduct([1, 2, 3, 4]));
    }

    [Fact]
    public void ZerosInBetween()
    {
        Assert.Equal(20, new MaximumProductSubarray().MaxProduct([2, 3, 0, 4, 5]));
    }

    [Fact]
    public void NegativeSandwich()
    {
        Assert.Equal(24, new MaximumProductSubarray().MaxProduct([-2, 3, -4]));
    }
}
