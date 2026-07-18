public class MedianOfTwoSortedArraysTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2.0, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(2.5, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }));
    }

    [Fact]
    public void OneEmpty()
    {
        Assert.Equal(1.0, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new int[] { }, new[] { 1 }));
    }

    [Fact]
    public void OtherEmpty()
    {
        Assert.Equal(2.0, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 2 }, new int[] { }));
    }

    [Fact]
    public void SameElements()
    {
        Assert.Equal(1.0, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1, 1 }, new[] { 1, 1 }));
    }

    [Fact]
    public void NonOverlapping()
    {
        Assert.Equal(3.0, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4, 5 }));
    }

    [Fact]
    public void SingleElements()
    {
        Assert.Equal(1.5, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1 }, new[] { 2 }));
    }

    [Fact]
    public void DifferentSizes()
    {
        Assert.Equal(4.5, new MedianOfTwoSortedArrays().FindMedianSortedArrays(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8 }));
    }
}
