public class KthLargestElementInAStreamTests
{
    [Fact]
    public void Example1()
    {
        var kth = new KthLargestElementInAStream(3, [4, 5, 8, 2]);
        Assert.Equal(4, kth.Add(3));
        Assert.Equal(5, kth.Add(5));
        Assert.Equal(5, kth.Add(10));
        Assert.Equal(8, kth.Add(9));
        Assert.Equal(8, kth.Add(4));
    }

    [Fact]
    public void KEquals1()
    {
        var kth = new KthLargestElementInAStream(1, []);
        Assert.Equal(-3, kth.Add(-3));
        Assert.Equal(-2, kth.Add(-2));
        Assert.Equal(-2, kth.Add(-4));
        Assert.Equal(0, kth.Add(0));
        Assert.Equal(4, kth.Add(4));
    }

    [Fact]
    public void AllSame()
    {
        var kth = new KthLargestElementInAStream(2, [5, 5, 5]);
        Assert.Equal(5, kth.Add(5));
        Assert.Equal(5, kth.Add(5));
    }

    [Fact]
    public void NegativeNumbers()
    {
        var kth = new KthLargestElementInAStream(2, [-1, -2, -3]);
        Assert.Equal(-2, kth.Add(-4));
        Assert.Equal(-1, kth.Add(0));
        Assert.Equal(0, kth.Add(1));
    }

    [Fact]
    public void LargeK()
    {
        var kth = new KthLargestElementInAStream(4, [7, 7, 7, 7, 8, 3]);
        Assert.Equal(7, kth.Add(2));
        Assert.Equal(7, kth.Add(10));
        Assert.Equal(7, kth.Add(9));
    }
}
