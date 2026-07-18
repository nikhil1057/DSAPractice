public class SubsetsTests
{
    [Fact]
    public void Example1()
    {
        var result = new Subsets().FindSubsets([1, 2, 3]);
        Assert.Equal(8, result.Count); // 2^3 = 8 subsets
    }

    [Fact]
    public void Example2()
    {
        var result = new Subsets().FindSubsets([0]);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void TwoElements()
    {
        var result = new Subsets().FindSubsets([1, 2]);
        Assert.Equal(4, result.Count);
    }

    [Fact]
    public void ContainsEmptySet()
    {
        var result = new Subsets().FindSubsets([1, 2, 3]);
        Assert.Contains(result, s => s.Count == 0);
    }

    [Fact]
    public void ContainsFullSet()
    {
        var result = new Subsets().FindSubsets([1, 2, 3]);
        Assert.Contains(result, s => s.Count == 3);
    }

    [Fact]
    public void FourElements()
    {
        var result = new Subsets().FindSubsets([1, 2, 3, 4]);
        Assert.Equal(16, result.Count);
    }
}
