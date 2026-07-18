public class RegularExpressionMatchingTests
{
    [Fact]
    public void Example1()
    {
        Assert.False(new RegularExpressionMatching().IsMatch("aa", "a"));
    }

    [Fact]
    public void Example2()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("aa", "a*"));
    }

    [Fact]
    public void Example3()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("ab", ".*"));
    }

    [Fact]
    public void DotMatch()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("ab", ".."));
    }

    [Fact]
    public void StarZeroMatches()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("aab", "c*a*b"));
    }

    [Fact]
    public void ComplexPattern()
    {
        Assert.False(new RegularExpressionMatching().IsMatch("mississippi", "mis*is*p*."));
    }

    [Fact]
    public void EmptyBoth()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("", ""));
    }

    [Fact]
    public void EmptyStringStarPattern()
    {
        Assert.True(new RegularExpressionMatching().IsMatch("", "a*"));
    }
}
