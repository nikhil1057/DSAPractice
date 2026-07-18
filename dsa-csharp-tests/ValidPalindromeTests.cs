public class ValidPalindromeTests
{
    [Fact]
    public void Example1()
    {
        // "A man, a plan, a canal: Panama" => true
        Assert.True(new ValidPalindrome().IsPalindrome("A man, a plan, a canal: Panama"));
    }

    [Fact]
    public void Example2_NotPalindrome()
    {
        // "race a car" => false
        Assert.False(new ValidPalindrome().IsPalindrome("race a car"));
    }

    [Fact]
    public void Example3_SpaceOnly()
    {
        // " " => true
        Assert.True(new ValidPalindrome().IsPalindrome(" "));
    }

    [Fact]
    public void EmptyString()
    {
        Assert.True(new ValidPalindrome().IsPalindrome(""));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.True(new ValidPalindrome().IsPalindrome("a"));
    }

    [Fact]
    public void NumbersOnly()
    {
        Assert.True(new ValidPalindrome().IsPalindrome("12321"));
    }

    [Fact]
    public void MixedCase()
    {
        Assert.True(new ValidPalindrome().IsPalindrome("Aa"));
    }

    [Fact]
    public void SpecialCharsOnly()
    {
        Assert.True(new ValidPalindrome().IsPalindrome(".,!?"));
    }
}
