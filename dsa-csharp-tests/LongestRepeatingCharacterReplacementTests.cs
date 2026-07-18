public class LongestRepeatingCharacterReplacementTests
{
    [Fact]
    public void Example1()
    {
        // "ABAB", k=2 => 4
        Assert.Equal(4, new LongestRepeatingCharacterReplacement().CharacterReplacement("ABAB", 2));
    }

    [Fact]
    public void Example2()
    {
        // "AABABBA", k=1 => 4
        Assert.Equal(4, new LongestRepeatingCharacterReplacement().CharacterReplacement("AABABBA", 1));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(4, new LongestRepeatingCharacterReplacement().CharacterReplacement("AAAA", 0));
    }

    [Fact]
    public void KZero_Alternating()
    {
        Assert.Equal(1, new LongestRepeatingCharacterReplacement().CharacterReplacement("ABAB", 0));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal(1, new LongestRepeatingCharacterReplacement().CharacterReplacement("A", 0));
    }

    [Fact]
    public void KLargerThanNeeded()
    {
        Assert.Equal(4, new LongestRepeatingCharacterReplacement().CharacterReplacement("ABCD", 10));
    }

    [Fact]
    public void EmptyString()
    {
        Assert.Equal(0, new LongestRepeatingCharacterReplacement().CharacterReplacement("", 2));
    }
}
