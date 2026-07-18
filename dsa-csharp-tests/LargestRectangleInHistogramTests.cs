public class LargestRectangleInHistogramTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(10, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 2, 1, 5, 6, 2, 3 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 2, 4 }));
    }

    [Fact]
    public void SingleBar()
    {
        Assert.Equal(5, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 5 }));
    }

    [Fact]
    public void AllSameHeight()
    {
        Assert.Equal(12, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 3, 3, 3, 3 }));
    }

    [Fact]
    public void Increasing()
    {
        Assert.Equal(6, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 1, 2, 3, 4 }));
    }

    [Fact]
    public void Decreasing()
    {
        Assert.Equal(6, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 4, 3, 2, 1 }));
    }

    [Fact]
    public void Valley()
    {
        Assert.Equal(5, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 5, 1, 5 }));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(5, new LargestRectangleInHistogram().LargestRectangleArea(new[] { 1, 1, 1, 1, 1 }));
    }
}
