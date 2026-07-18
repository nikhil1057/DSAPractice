public class CombinationSumTests
{
    [Fact]
    public void Example1()
    {
        var result = new CombinationSum().CombinationSumSolve([2, 3, 6, 7], 7);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Example2()
    {
        var result = new CombinationSum().CombinationSumSolve([2, 3, 5], 8);
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void Example3_NoResult()
    {
        var result = new CombinationSum().CombinationSumSolve([2], 1);
        Assert.Empty(result);
    }

    [Fact]
    public void SingleCandidateExact()
    {
        var result = new CombinationSum().CombinationSumSolve([3], 9);
        Assert.Single(result);
        Assert.Equal(new List<int> { 3, 3, 3 }, result[0]);
    }

    [Fact]
    public void SingleCandidateNotDivisible()
    {
        var result = new CombinationSum().CombinationSumSolve([5], 7);
        Assert.Empty(result);
    }

    [Fact]
    public void TargetEqualsSingleCandidate()
    {
        var result = new CombinationSum().CombinationSumSolve([7], 7);
        Assert.Single(result);
    }
}
