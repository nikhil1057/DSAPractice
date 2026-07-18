public class SearchInRotatedSortedArrayTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new SearchInRotatedSortedArray().Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(-1, new SearchInRotatedSortedArray().Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(-1, new SearchInRotatedSortedArray().Search(new[] { 1 }, 0));
    }

    [Fact]
    public void SingleElementFound()
    {
        Assert.Equal(0, new SearchInRotatedSortedArray().Search(new[] { 1 }, 1));
    }

    [Fact]
    public void NotRotated()
    {
        Assert.Equal(2, new SearchInRotatedSortedArray().Search(new[] { 1, 2, 3, 4, 5 }, 3));
    }

    [Fact]
    public void TargetAtPivot()
    {
        Assert.Equal(2, new SearchInRotatedSortedArray().Search(new[] { 6, 7, 1, 2, 3, 4, 5 }, 1));
    }

    [Fact]
    public void TargetInLeftHalf()
    {
        Assert.Equal(1, new SearchInRotatedSortedArray().Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 5));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(1, new SearchInRotatedSortedArray().Search(new[] { 3, 1 }, 1));
    }
}
