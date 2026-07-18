public class ImplementTriePrefixTreeTests
{
    [Fact]
    public void Example1()
    {
        var trie = new ImplementTriePrefixTree();
        trie.Insert("apple");
        Assert.True(trie.Search("apple"));
        Assert.False(trie.Search("app"));
        Assert.True(trie.StartsWith("app"));
        trie.Insert("app");
        Assert.True(trie.Search("app"));
    }

    [Fact]
    public void SearchNonexistent()
    {
        var trie = new ImplementTriePrefixTree();
        trie.Insert("hello");
        Assert.False(trie.Search("hell"));
        Assert.False(trie.Search("helloo"));
    }

    [Fact]
    public void StartsWith()
    {
        var trie = new ImplementTriePrefixTree();
        trie.Insert("prefix");
        Assert.True(trie.StartsWith("pre"));
        Assert.True(trie.StartsWith("prefix"));
        Assert.False(trie.StartsWith("prefixx"));
    }

    [Fact]
    public void EmptyTrie()
    {
        var trie = new ImplementTriePrefixTree();
        Assert.False(trie.Search("anything"));
        Assert.False(trie.StartsWith("a"));
    }

    [Fact]
    public void SingleCharacter()
    {
        var trie = new ImplementTriePrefixTree();
        trie.Insert("a");
        Assert.True(trie.Search("a"));
        Assert.True(trie.StartsWith("a"));
        Assert.False(trie.Search("b"));
    }

    [Fact]
    public void MultipleWordsSamePrefix()
    {
        var trie = new ImplementTriePrefixTree();
        trie.Insert("car");
        trie.Insert("card");
        trie.Insert("care");
        Assert.True(trie.Search("car"));
        Assert.True(trie.Search("card"));
        Assert.True(trie.Search("care"));
        Assert.False(trie.Search("cars"));
    }
}
