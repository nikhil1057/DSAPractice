public class WordBreakTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new WordBreak().WordBreakSolution("leetcode", new List<string> { "leet", "code" }));
    }

    [Fact]
    public void Example2()
    {
        Assert.True(new WordBreak().WordBreakSolution("applepenapple", new List<string> { "apple", "pen" }));
    }

    [Fact]
    public void Example3()
    {
        Assert.False(new WordBreak().WordBreakSolution("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }));
    }

    [Fact]
    public void SingleWord()
    {
        Assert.True(new WordBreak().WordBreakSolution("a", new List<string> { "a" }));
    }

    [Fact]
    public void NotInDict()
    {
        Assert.False(new WordBreak().WordBreakSolution("abc", new List<string> { "a", "b" }));
    }

    [Fact]
    public void ReuseWords()
    {
        Assert.True(new WordBreak().WordBreakSolution("aaaa", new List<string> { "a", "aa" }));
    }

    [Fact]
    public void EmptyString()
    {
        Assert.True(new WordBreak().WordBreakSolution("", new List<string> { "a" }));
    }

    [Fact]
    public void OverlappingWords()
    {
        Assert.True(new WordBreak().WordBreakSolution("cars", new List<string> { "car", "ca", "rs" }));
    }
}
