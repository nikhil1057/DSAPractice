public class KthLargestElementInAnArrayTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(5, new KthLargestElementInAnArray().FindKthLargest([3, 2, 1, 5, 6, 4], 2));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, new KthLargestElementInAnArray().FindKthLargest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(1, new KthLargestElementInAnArray().FindKthLargest([1], 1));
    }

    [Fact]
    public void KEqualsN()
    {
        Assert.Equal(1, new KthLargestElementInAnArray().FindKthLargest([3, 2, 1], 3));
    }

    [Fact]
    public void Duplicates()
    {
        Assert.Equal(2, new KthLargestElementInAnArray().FindKthLargest([2, 2, 2, 2], 2));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal(-2, new KthLargestElementInAnArray().FindKthLargest([-1, -2, -3, -4], 2));
    }

    [Fact]
    public void MixedNumbers()
    {
        Assert.Equal(3, new KthLargestElementInAnArray().FindKthLargest([-1, 0, 1, 2, 3], 1));
    }
}
