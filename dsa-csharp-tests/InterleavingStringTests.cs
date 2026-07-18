public class InterleavingStringTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new InterleavingString().IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new InterleavingString().IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
    }

    [Fact]
    public void Example3()
    {
        Assert.True(new InterleavingString().IsInterleave("", "", ""));
    }

    [Fact]
    public void OneEmpty()
    {
        Assert.True(new InterleavingString().IsInterleave("", "abc", "abc"));
    }

    [Fact]
    public void LengthMismatch()
    {
        Assert.False(new InterleavingString().IsInterleave("a", "b", "abc"));
    }

    [Fact]
    public void SingleChars()
    {
        Assert.True(new InterleavingString().IsInterleave("a", "b", "ab"));
    }

    [Fact]
    public void RepeatedChars()
    {
        Assert.True(new InterleavingString().IsInterleave("aaa", "aaa", "aaaaaa"));
    }
}
