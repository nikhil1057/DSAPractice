public class PalindromicSubstringsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new PalindromicSubstrings().CountSubstrings("abc"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(6, new PalindromicSubstrings().CountSubstrings("aaa"));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal(1, new PalindromicSubstrings().CountSubstrings("a"));
    }

    [Fact]
    public void TwoSameChars()
    {
        Assert.Equal(3, new PalindromicSubstrings().CountSubstrings("aa"));
    }

    [Fact]
    public void TwoDiffChars()
    {
        Assert.Equal(2, new PalindromicSubstrings().CountSubstrings("ab"));
    }

    [Fact]
    public void PalindromeString()
    {
        Assert.Equal(4, new PalindromicSubstrings().CountSubstrings("aba"));
    }

    [Fact]
    public void LongerString()
    {
        // "abcba": a,b,c,b,a,bcb,abcba => 7
        Assert.Equal(7, new PalindromicSubstrings().CountSubstrings("abcba"));
    }
}
