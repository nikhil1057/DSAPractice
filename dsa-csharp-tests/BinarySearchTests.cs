public class BinarySearchTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new BinarySearch().Search(new[] { -1, 0, 3, 5, 9, 12 }, 9));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(-1, new BinarySearch().Search(new[] { -1, 0, 3, 5, 9, 12 }, 2));
    }

    [Fact]
    public void SingleElementFound()
    {
        Assert.Equal(0, new BinarySearch().Search(new[] { 5 }, 5));
    }

    [Fact]
    public void SingleElementNotFound()
    {
        Assert.Equal(-1, new BinarySearch().Search(new[] { 5 }, 3));
    }

    [Fact]
    public void FirstElement()
    {
        Assert.Equal(0, new BinarySearch().Search(new[] { 1, 2, 3, 4, 5 }, 1));
    }

    [Fact]
    public void LastElement()
    {
        Assert.Equal(4, new BinarySearch().Search(new[] { 1, 2, 3, 4, 5 }, 5));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(1, new BinarySearch().Search(new[] { 1, 3 }, 3));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal(1, new BinarySearch().Search(new[] { -10, -5, -2, 0, 3 }, -5));
    }
}
