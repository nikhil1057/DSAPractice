public class ValidAnagramTests
{
    [Fact]
    public void Example1_IsAnagram()
    {
        // "anagram", "nagaram" => true
        Assert.True(new ValidAnagram().IsAnagram("anagram", "nagaram"));
    }

    [Fact]
    public void Example2_NotAnagram()
    {
        // "rat", "car" => false
        Assert.False(new ValidAnagram().IsAnagram("rat", "car"));
    }

    [Fact]
    public void EmptyStrings()
    {
        Assert.True(new ValidAnagram().IsAnagram("", ""));
    }

    [Fact]
    public void SingleCharSame()
    {
        Assert.True(new ValidAnagram().IsAnagram("a", "a"));
    }

    [Fact]
    public void SingleCharDifferent()
    {
        Assert.False(new ValidAnagram().IsAnagram("a", "b"));
    }

    [Fact]
    public void DifferentLengths()
    {
        Assert.False(new ValidAnagram().IsAnagram("ab", "abc"));
    }

    [Fact]
    public void SameCharsDifferentCounts()
    {
        Assert.False(new ValidAnagram().IsAnagram("aab", "abb"));
    }

    [Fact]
    public void LongerAnagram()
    {
        Assert.True(new ValidAnagram().IsAnagram("listen", "silent"));
    }
}
