public class CombinationSumIITests
{
    [Fact]
    public void Example1()
    {
        var result = new CombinationSumII().CombinationSum2([10, 1, 2, 7, 6, 1, 5], 8);
        Assert.Equal(4, result.Count);
    }

    [Fact]
    public void Example2()
    {
        var result = new CombinationSumII().CombinationSum2([2, 5, 2, 1, 2], 5);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void NoCombination()
    {
        var result = new CombinationSumII().CombinationSum2([3, 5, 7], 2);
        Assert.Empty(result);
    }

    [Fact]
    public void SingleElementMatch()
    {
        var result = new CombinationSumII().CombinationSum2([1], 1);
        Assert.Single(result);
    }

    [Fact]
    public void SingleElementNoMatch()
    {
        var result = new CombinationSumII().CombinationSum2([2], 1);
        Assert.Empty(result);
    }

    [Fact]
    public void AllSameElements()
    {
        var result = new CombinationSumII().CombinationSum2([2, 2, 2, 2], 4);
        Assert.Single(result);
    }

    [Fact]
    public void DuplicatesHandled()
    {
        var result = new CombinationSumII().CombinationSum2([1, 1, 1, 1, 1], 3);
        Assert.Single(result);
    }
}
