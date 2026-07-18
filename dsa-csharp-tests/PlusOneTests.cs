public class PlusOneTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal([1, 2, 4], new PlusOne().PlusOneMethod([1, 2, 3]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal([4, 3, 2, 2], new PlusOne().PlusOneMethod([4, 3, 2, 1]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal([1, 0], new PlusOne().PlusOneMethod([9]));
    }

    [Fact]
    public void AllNines()
    {
        Assert.Equal([1, 0, 0, 0], new PlusOne().PlusOneMethod([9, 9, 9]));
    }

    [Fact]
    public void SingleDigit()
    {
        Assert.Equal([1], new PlusOne().PlusOneMethod([0]));
    }

    [Fact]
    public void TrailingNine()
    {
        Assert.Equal([2, 0], new PlusOne().PlusOneMethod([1, 9]));
    }

    [Fact]
    public void NoCarry()
    {
        Assert.Equal([5, 5, 6], new PlusOne().PlusOneMethod([5, 5, 5]));
    }
}
