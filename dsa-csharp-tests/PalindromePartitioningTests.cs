public class PalindromePartitioningTests
{
    [Fact]
    public void Example1()
    {
        var result = new PalindromePartitioning().Partition("aab");
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Example2()
    {
        var result = new PalindromePartitioning().Partition("a");
        Assert.Single(result);
    }

    [Fact]
    public void AllSame()
    {
        var result = new PalindromePartitioning().Partition("aaa");
        Assert.Equal(4, result.Count); // ["a","a","a"], ["a","aa"], ["aa","a"], ["aaa"]
    }

    [Fact]
    public void NoPalindromeExceptSingleChars()
    {
        var result = new PalindromePartitioning().Partition("abc");
        Assert.Single(result);
    }

    [Fact]
    public void TwoCharsPalindrome()
    {
        var result = new PalindromePartitioning().Partition("bb");
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void ThreeCharPalindrome()
    {
        var result = new PalindromePartitioning().Partition("aba");
        Assert.Equal(2, result.Count); // ["a","b","a"], ["aba"]
    }
}
