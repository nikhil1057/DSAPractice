public class GroupAnagramsTests
{
    private List<List<string>> SortResult(IList<IList<string>> result)
    {
        return result
            .Select(g => g.OrderBy(s => s).ToList())
            .OrderBy(g => string.Join(",", g))
            .ToList();
    }

    [Fact]
    public void Example1()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution(["eat", "tea", "tan", "ate", "nat", "bat"]);
        var sorted = SortResult(result);
        var expected = new List<List<string>>
        {
            new() { "ate", "eat", "tea" },
            new() { "bat" },
            new() { "nat", "tan" }
        };
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Example2_EmptyString()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution([""]);
        Assert.Single(result);
        Assert.Equal([""], result[0]);
    }

    [Fact]
    public void Example3_SingleString()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution(["a"]);
        Assert.Single(result);
        Assert.Equal(["a"], result[0]);
    }

    [Fact]
    public void NoAnagrams()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution(["abc", "def", "ghi"]);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void AllAnagrams()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution(["abc", "bca", "cab"]);
        Assert.Single(result);
        Assert.Equal(3, result[0].Count);
    }

    [Fact]
    public void EmptyArray()
    {
        var result = new GroupAnagrams().GroupAnagramsSolution([]);
        Assert.Empty(result);
    }
}
