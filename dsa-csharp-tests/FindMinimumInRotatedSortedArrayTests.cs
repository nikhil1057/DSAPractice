public class FindMinimumInRotatedSortedArrayTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 3, 4, 5, 1, 2 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(0, new FindMinimumInRotatedSortedArray().FindMin(new[] { 4, 5, 6, 7, 0, 1, 2 }));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(11, new FindMinimumInRotatedSortedArray().FindMin(new[] { 11, 13, 15, 17 }));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 1 }));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 2, 1 }));
    }

    [Fact]
    public void RotatedAtEnd()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 2, 3, 4, 5, 1 }));
    }

    [Fact]
    public void NotRotated()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 1, 2, 3, 4, 5 }));
    }

    [Fact]
    public void TwoElementsNotRotated()
    {
        Assert.Equal(1, new FindMinimumInRotatedSortedArray().FindMin(new[] { 1, 2 }));
    }
}
