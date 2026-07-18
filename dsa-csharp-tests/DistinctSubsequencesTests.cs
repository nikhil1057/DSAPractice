public class DistinctSubsequencesTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new DistinctSubsequences().NumDistinct("rabbbit", "rabbit"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(5, new DistinctSubsequences().NumDistinct("babgbag", "bag"));
    }

    [Fact]
    public void NoMatch()
    {
        Assert.Equal(0, new DistinctSubsequences().NumDistinct("abc", "def"));
    }

    [Fact]
    public void EmptyT()
    {
        Assert.Equal(1, new DistinctSubsequences().NumDistinct("abc", ""));
    }

    [Fact]
    public void TLongerThanS()
    {
        Assert.Equal(0, new DistinctSubsequences().NumDistinct("ab", "abc"));
    }

    [Fact]
    public void SameStrings()
    {
        Assert.Equal(1, new DistinctSubsequences().NumDistinct("abc", "abc"));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal(3, new DistinctSubsequences().NumDistinct("aaa", "a"));
    }

    [Fact]
    public void RepeatedPattern()
    {
        Assert.Equal(4, new DistinctSubsequences().NumDistinct("aabb", "ab"));
    }
}
