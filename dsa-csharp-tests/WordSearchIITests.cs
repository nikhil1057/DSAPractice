public class WordSearchIITests
{
    [Fact]
    public void Example1()
    {
        char[][] board = [['o', 'a', 'a', 'n'], ['e', 't', 'a', 'e'], ['i', 'h', 'k', 'r'], ['i', 'f', 'l', 'v']];
        string[] words = ["oath", "pea", "eat", "rain"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Equal(new List<string> { "eat", "oath" }.OrderBy(x => x), result.OrderBy(x => x));
    }

    [Fact]
    public void Example2()
    {
        char[][] board = [['a', 'b'], ['c', 'd']];
        string[] words = ["abcb"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Empty(result);
    }

    [Fact]
    public void SingleCell()
    {
        char[][] board = [['a']];
        string[] words = ["a"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Equal(new List<string> { "a" }, result.ToList());
    }

    [Fact]
    public void SingleCellNotFound()
    {
        char[][] board = [['a']];
        string[] words = ["b"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Empty(result);
    }

    [Fact]
    public void AllWordsFound()
    {
        char[][] board = [['a', 'b'], ['c', 'd']];
        string[] words = ["ab", "cd", "ac"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void NoDuplicatesInResult()
    {
        char[][] board = [['a', 'a']];
        string[] words = ["a"];
        var result = new WordSearchII().FindWords(board, words);
        Assert.Single(result);
    }
}
