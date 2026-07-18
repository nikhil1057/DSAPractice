public class EditDistanceTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new EditDistance().MinDistance("horse", "ros"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(5, new EditDistance().MinDistance("intention", "execution"));
    }

    [Fact]
    public void EmptyWord1()
    {
        Assert.Equal(3, new EditDistance().MinDistance("", "abc"));
    }

    [Fact]
    public void EmptyWord2()
    {
        Assert.Equal(3, new EditDistance().MinDistance("abc", ""));
    }

    [Fact]
    public void BothEmpty()
    {
        Assert.Equal(0, new EditDistance().MinDistance("", ""));
    }

    [Fact]
    public void SameStrings()
    {
        Assert.Equal(0, new EditDistance().MinDistance("abc", "abc"));
    }

    [Fact]
    public void SingleCharDifferent()
    {
        Assert.Equal(1, new EditDistance().MinDistance("a", "b"));
    }

    [Fact]
    public void OneInsertion()
    {
        Assert.Equal(1, new EditDistance().MinDistance("ab", "abc"));
    }
}
