public class MaximumSubarrayTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(6, new MaximumSubarray().MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new MaximumSubarray().MaxSubArray([1]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(23, new MaximumSubarray().MaxSubArray([5, 4, -1, 7, 8]));
    }

    [Fact]
    public void AllNegative()
    {
        Assert.Equal(-1, new MaximumSubarray().MaxSubArray([-3, -2, -1, -4]));
    }

    [Fact]
    public void SingleNegative()
    {
        Assert.Equal(-1, new MaximumSubarray().MaxSubArray([-1]));
    }

    [Fact]
    public void AllPositive()
    {
        Assert.Equal(10, new MaximumSubarray().MaxSubArray([1, 2, 3, 4]));
    }

    [Fact]
    public void Alternating()
    {
        Assert.Equal(3, new MaximumSubarray().MaxSubArray([-1, 2, -1, 2, -1]));
    }
}
