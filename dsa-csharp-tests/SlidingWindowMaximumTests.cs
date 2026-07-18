public class SlidingWindowMaximumTests
{
    [Fact]
    public void Example1()
    {
        // [1,3,-1,-3,5,3,6,7], k=3 => [3,3,5,5,6,7]
        Assert.Equal([3, 3, 5, 5, 6, 7], new SlidingWindowMaximum().MaxSlidingWindow([1, 3, -1, -3, 5, 3, 6, 7], 3));
    }

    [Fact]
    public void Example2()
    {
        // [1], k=1 => [1]
        Assert.Equal([1], new SlidingWindowMaximum().MaxSlidingWindow([1], 1));
    }

    [Fact]
    public void KEqualsLength()
    {
        Assert.Equal([4], new SlidingWindowMaximum().MaxSlidingWindow([1, 2, 3, 4], 4));
    }

    [Fact]
    public void Descending()
    {
        Assert.Equal([5, 4, 3, 2], new SlidingWindowMaximum().MaxSlidingWindow([5, 4, 3, 2, 1], 2));
    }

    [Fact]
    public void Ascending()
    {
        Assert.Equal([2, 3, 4, 5], new SlidingWindowMaximum().MaxSlidingWindow([1, 2, 3, 4, 5], 2));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal([3, 3, 3], new SlidingWindowMaximum().MaxSlidingWindow([3, 3, 3, 3], 2));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal([-1, -3, -2], new SlidingWindowMaximum().MaxSlidingWindow([-1, -3, -5, -2], 2));
    }
}
