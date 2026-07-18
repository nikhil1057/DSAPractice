public class MinimumWindowSubstringTests
{
    [Fact]
    public void Example1()
    {
        // s="ADOBECODEBANC", t="ABC" => "BANC"
        Assert.Equal("BANC", new MinimumWindowSubstring().MinWindow("ADOBECODEBANC", "ABC"));
    }

    [Fact]
    public void Example2()
    {
        // s="a", t="a" => "a"
        Assert.Equal("a", new MinimumWindowSubstring().MinWindow("a", "a"));
    }

    [Fact]
    public void Example3_NotEnoughChars()
    {
        // s="a", t="aa" => ""
        Assert.Equal("", new MinimumWindowSubstring().MinWindow("a", "aa"));
    }

    [Fact]
    public void NoValidWindow()
    {
        Assert.Equal("", new MinimumWindowSubstring().MinWindow("abc", "xyz"));
    }

    [Fact]
    public void TEqualsS()
    {
        Assert.Equal("abc", new MinimumWindowSubstring().MinWindow("abc", "abc"));
    }

    [Fact]
    public void DuplicateCharsInT()
    {
        Assert.Equal("aa", new MinimumWindowSubstring().MinWindow("aaab", "aa"));
    }

    [Fact]
    public void SingleCharRepeated()
    {
        Assert.Equal("b", new MinimumWindowSubstring().MinWindow("bbbb", "b"));
    }

    [Fact]
    public void EmptyT()
    {
        Assert.Equal("", new MinimumWindowSubstring().MinWindow("abc", ""));
    }
}
