public class AlienDictionaryTests
{
    [Fact]
    public void Example1()
    {
        string[] words = ["wrt", "wrf", "er", "ett", "rftt"];
        Assert.Equal("wertf", new AlienDictionary().AlienOrder(words));
    }

    [Fact]
    public void Example2()
    {
        string[] words = ["z", "x"];
        Assert.Equal("zx", new AlienDictionary().AlienOrder(words));
    }

    [Fact]
    public void InvalidPrefix()
    {
        // "abc" before "ab" is invalid
        string[] words = ["abc", "ab"];
        Assert.Equal("", new AlienDictionary().AlienOrder(words));
    }

    [Fact]
    public void SingleWord()
    {
        string[] words = ["abc"];
        string result = new AlienDictionary().AlienOrder(words);
        Assert.Equal(3, result.Length);
        Assert.Contains('a', result);
        Assert.Contains('b', result);
        Assert.Contains('c', result);
    }

    [Fact]
    public void CycleDetection()
    {
        // z < x and x < z is a cycle
        string[] words = ["z", "x", "z"];
        Assert.Equal("", new AlienDictionary().AlienOrder(words));
    }

    [Fact]
    public void TwoWordsSame()
    {
        string[] words = ["a", "a"];
        Assert.Equal("a", new AlienDictionary().AlienOrder(words));
    }

    [Fact]
    public void AllSameLetter()
    {
        string[] words = ["a", "aa", "aaa"];
        Assert.Equal("a", new AlienDictionary().AlienOrder(words));
    }
}
