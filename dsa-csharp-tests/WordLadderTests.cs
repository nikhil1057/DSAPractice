public class WordLadderTests
{
    [Fact]
    public void Example1()
    {
        var wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
        Assert.Equal(5, new WordLadder().LadderLength("hit", "cog", wordList));
    }

    [Fact]
    public void Example2_NoPath()
    {
        var wordList = new List<string> { "hot", "dot", "dog", "lot", "log" };
        Assert.Equal(0, new WordLadder().LadderLength("hit", "cog", wordList));
    }

    [Fact]
    public void OneStep()
    {
        var wordList = new List<string> { "dot" };
        Assert.Equal(2, new WordLadder().LadderLength("hot", "dot", wordList));
    }

    [Fact]
    public void NoPath()
    {
        var wordList = new List<string> { "abd", "xyd" };
        Assert.Equal(0, new WordLadder().LadderLength("abc", "xyz", wordList));
    }

    [Fact]
    public void EndNotInList()
    {
        var wordList = new List<string> { "hot", "dot", "dog" };
        Assert.Equal(0, new WordLadder().LadderLength("hit", "cog", wordList));
    }

    [Fact]
    public void DirectNeighbor()
    {
        var wordList = new List<string> { "a", "b", "c" };
        Assert.Equal(2, new WordLadder().LadderLength("a", "c", wordList));
    }

    [Fact]
    public void ThreeSteps()
    {
        var wordList = new List<string> { "ab", "ad", "cd" };
        Assert.Equal(3, new WordLadder().LadderLength("ab", "cd", wordList));
    }
}
