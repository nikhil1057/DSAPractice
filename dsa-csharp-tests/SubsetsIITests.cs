public class SubsetsIITests
{
    [Fact]
    public void Example1()
    {
        var result = new SubsetsII().SubsetsWithDup([1, 2, 2]);
        Assert.Equal(6, result.Count);
    }

    [Fact]
    public void Example2()
    {
        var result = new SubsetsII().SubsetsWithDup([0]);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void AllDuplicates()
    {
        var result = new SubsetsII().SubsetsWithDup([1, 1, 1]);
        Assert.Equal(4, result.Count); // [], [1], [1,1], [1,1,1]
    }

    [Fact]
    public void NoDuplicates()
    {
        var result = new SubsetsII().SubsetsWithDup([1, 2, 3]);
        Assert.Equal(8, result.Count); // Same as regular subsets
    }

    [Fact]
    public void TwoPairs()
    {
        var result = new SubsetsII().SubsetsWithDup([1, 1, 2, 2]);
        Assert.Equal(9, result.Count);
    }

    [Fact]
    public void SingleElement()
    {
        var result = new SubsetsII().SubsetsWithDup([5]);
        Assert.Equal(2, result.Count);
    }
}
