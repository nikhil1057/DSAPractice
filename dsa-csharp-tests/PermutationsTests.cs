public class PermutationsTests
{
    [Fact]
    public void Example1()
    {
        var result = new Permutations().Permute([1, 2, 3]);
        Assert.Equal(6, result.Count); // 3! = 6
    }

    [Fact]
    public void Example2()
    {
        var result = new Permutations().Permute([0, 1]);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void Example3_SingleElement()
    {
        var result = new Permutations().Permute([1]);
        Assert.Single(result);
        Assert.Equal(new List<int> { 1 }, result[0]);
    }

    [Fact]
    public void FourElements()
    {
        var result = new Permutations().Permute([1, 2, 3, 4]);
        Assert.Equal(24, result.Count); // 4! = 24
    }

    [Fact]
    public void NegativeNumbers()
    {
        var result = new Permutations().Permute([-1, 0, 1]);
        Assert.Equal(6, result.Count);
    }

    [Fact]
    public void NoDuplicatePermutations()
    {
        var result = new Permutations().Permute([1, 2, 3]);
        var asStrings = result.Select(p => string.Join(",", p)).ToHashSet();
        Assert.Equal(6, asStrings.Count);
    }
}
