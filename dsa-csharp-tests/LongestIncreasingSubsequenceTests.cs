public class LongestIncreasingSubsequenceTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new LongestIncreasingSubsequence().LengthOfLIS([10, 9, 2, 5, 3, 7, 101, 18]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, new LongestIncreasingSubsequence().LengthOfLIS([0, 1, 0, 3, 2, 3]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(1, new LongestIncreasingSubsequence().LengthOfLIS([7, 7, 7, 7, 7, 7, 7]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(1, new LongestIncreasingSubsequence().LengthOfLIS([10]));
    }

    [Fact]
    public void SortedAscending()
    {
        Assert.Equal(5, new LongestIncreasingSubsequence().LengthOfLIS([1, 2, 3, 4, 5]));
    }

    [Fact]
    public void SortedDescending()
    {
        Assert.Equal(1, new LongestIncreasingSubsequence().LengthOfLIS([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void TwoElementsIncreasing()
    {
        Assert.Equal(2, new LongestIncreasingSubsequence().LengthOfLIS([1, 2]));
    }

    [Fact]
    public void Alternating()
    {
        Assert.Equal(4, new LongestIncreasingSubsequence().LengthOfLIS([1, 3, 2, 4, 3, 5]));
    }
}
