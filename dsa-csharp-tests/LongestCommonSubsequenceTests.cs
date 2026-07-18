public class LongestCommonSubsequenceTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new LongestCommonSubsequence().LongestCommonSubseq("abcde", "ace"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3, new LongestCommonSubsequence().LongestCommonSubseq("abc", "abc"));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(0, new LongestCommonSubsequence().LongestCommonSubseq("abc", "def"));
    }

    [Fact]
    public void EmptyString()
    {
        Assert.Equal(0, new LongestCommonSubsequence().LongestCommonSubseq("", "abc"));
    }

    [Fact]
    public void SingleCharMatch()
    {
        Assert.Equal(1, new LongestCommonSubsequence().LongestCommonSubseq("a", "a"));
    }

    [Fact]
    public void SingleCharNoMatch()
    {
        Assert.Equal(0, new LongestCommonSubsequence().LongestCommonSubseq("a", "b"));
    }

    [Fact]
    public void SubsequenceNotSubstring()
    {
        Assert.Equal(5, new LongestCommonSubsequence().LongestCommonSubseq("abcba", "abcbcba"));
    }

    [Fact]
    public void LongerStrings()
    {
        Assert.Equal(2, new LongestCommonSubsequence().LongestCommonSubseq("oxcpqrsvwf", "shmtulqrypy"));
    }
}
