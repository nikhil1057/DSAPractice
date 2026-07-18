public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Fact]
    public void Example1()
    {
        // "abcabcbb" => 3
        Assert.Equal(3, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("abcabcbb"));
    }

    [Fact]
    public void Example2()
    {
        // "bbbbb" => 1
        Assert.Equal(1, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("bbbbb"));
    }

    [Fact]
    public void Example3()
    {
        // "pwwkew" => 3
        Assert.Equal(3, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("pwwkew"));
    }

    [Fact]
    public void EmptyString()
    {
        Assert.Equal(0, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring(""));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal(1, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("a"));
    }

    [Fact]
    public void AllUnique()
    {
        Assert.Equal(6, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("abcdef"));
    }

    [Fact]
    public void SpacesAndSpecial()
    {
        Assert.Equal(3, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("a b c"));
    }

    [Fact]
    public void TwoChars()
    {
        Assert.Equal(2, new LongestSubstringWithoutRepeatingCharacters().LengthOfLongestSubstring("au"));
    }
}
