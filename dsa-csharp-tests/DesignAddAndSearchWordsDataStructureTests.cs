public class DesignAddAndSearchWordsDataStructureTests
{
    [Fact]
    public void Example1()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        wd.AddWord("bad");
        wd.AddWord("dad");
        wd.AddWord("mad");
        Assert.False(wd.Search("pad"));
        Assert.True(wd.Search("bad"));
        Assert.True(wd.Search(".ad"));
        Assert.True(wd.Search("b.."));
    }

    [Fact]
    public void DotAtBeginning()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        wd.AddWord("hello");
        Assert.True(wd.Search(".ello"));
        Assert.True(wd.Search("..llo"));
    }

    [Fact]
    public void AllDots()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        wd.AddWord("abc");
        Assert.True(wd.Search("..."));
        Assert.False(wd.Search("...."));
    }

    [Fact]
    public void NoMatch()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        wd.AddWord("cat");
        Assert.False(wd.Search("dog"));
        Assert.False(wd.Search("ca"));
    }

    [Fact]
    public void EmptyDictionary()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        Assert.False(wd.Search("a"));
        Assert.False(wd.Search("."));
    }

    [Fact]
    public void SingleCharWords()
    {
        var wd = new DesignAddAndSearchWordsDataStructure();
        wd.AddWord("a");
        wd.AddWord("b");
        Assert.True(wd.Search("."));
        Assert.True(wd.Search("a"));
        Assert.False(wd.Search("c"));
    }
}
