public class RemoveAllAdjacentDuplicatesInStringTests
{
    [Fact]
    public void Example1()
    {
        // "abbaca" → "ca"
        Assert.Equal("ca", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("abbaca"));
    }

    [Fact]
    public void Example2()
    {
        // "azxxzy" → "ay"
        Assert.Equal("ay", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("azxxzy"));
    }

    [Fact]
    public void NoDuplicates()
    {
        // "abc" → "abc" (nothing to remove)
        Assert.Equal("abc", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("abc"));
    }

    [Fact]
    public void AllDuplicates()
    {
        // "aabbcc" → "" (all cancel out)
        Assert.Equal("", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("aabbcc"));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal("a", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("a"));
    }

    [Fact]
    public void CascadingRemoval()
    {
        // "abccba" → "abba" → "aa" → ""
        Assert.Equal("", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("abccba"));
    }

    [Fact]
    public void DuplicateAtStart()
    {
        // "aabc" → "bc"
        Assert.Equal("bc", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("aabc"));
    }

    [Fact]
    public void DuplicateAtEnd()
    {
        // "abcc" → "ab"
        Assert.Equal("ab", new RemoveAllAdjacentDuplicatesInString().RemoveDuplicates("abcc"));
    }
}
