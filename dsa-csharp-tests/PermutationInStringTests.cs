public class PermutationInStringTests
{
    [Fact]
    public void Example1()
    {
        // s1="ab", s2="eidbaooo" => true
        Assert.True(new PermutationInString().CheckInclusion("ab", "eidbaooo"));
    }

    [Fact]
    public void Example2()
    {
        // s1="ab", s2="eidboaoo" => false
        Assert.False(new PermutationInString().CheckInclusion("ab", "eidboaoo"));
    }

    [Fact]
    public void S1LongerThanS2()
    {
        Assert.False(new PermutationInString().CheckInclusion("abc", "ab"));
    }

    [Fact]
    public void ExactMatch()
    {
        Assert.True(new PermutationInString().CheckInclusion("abc", "abc"));
    }

    [Fact]
    public void SingleCharFound()
    {
        Assert.True(new PermutationInString().CheckInclusion("a", "ab"));
    }

    [Fact]
    public void SingleCharNotFound()
    {
        Assert.False(new PermutationInString().CheckInclusion("a", "bc"));
    }

    [Fact]
    public void PermutationAtEnd()
    {
        Assert.True(new PermutationInString().CheckInclusion("ab", "xxxba"));
    }

    [Fact]
    public void RepeatedChars()
    {
        Assert.True(new PermutationInString().CheckInclusion("aab", "ccccaab"));
    }
}
