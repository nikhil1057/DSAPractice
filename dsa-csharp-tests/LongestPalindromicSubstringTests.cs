public class LongestPalindromicSubstringTests
{
    [Fact]
    public void Example1()
    {
        string result = new LongestPalindromicSubstring().LongestPalindrome("babad");
        Assert.True(result == "bab" || result == "aba");
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal("bb", new LongestPalindromicSubstring().LongestPalindrome("cbbd"));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal("a", new LongestPalindromicSubstring().LongestPalindrome("a"));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal("aaaa", new LongestPalindromicSubstring().LongestPalindrome("aaaa"));
    }

    [Fact]
    public void NoPalindromeLongerThan1()
    {
        string result = new LongestPalindromicSubstring().LongestPalindrome("abcd");
        Assert.Equal(1, result.Length);
    }

    [Fact]
    public void EntireString()
    {
        Assert.Equal("racecar", new LongestPalindromicSubstring().LongestPalindrome("racecar"));
    }

    [Fact]
    public void EvenLengthPalindrome()
    {
        Assert.Equal("aabbaa", new LongestPalindromicSubstring().LongestPalindrome("aabbaa"));
    }
}
