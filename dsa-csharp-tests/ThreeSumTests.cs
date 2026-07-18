public class ThreeSumTests
{
    private List<List<int>> SortResult(IList<IList<int>> result)
    {
        return result
            .Select(t => t.OrderBy(x => x).ToList())
            .OrderBy(t => t[0]).ThenBy(t => t[1]).ThenBy(t => t[2])
            .ToList();
    }

    [Fact]
    public void Example1()
    {
        var result = new ThreeSum().ThreeSumSolution([-1, 0, 1, 2, -1, -4]);
        var sorted = SortResult(result);
        var expected = new List<List<int>> { new() { -1, -1, 2 }, new() { -1, 0, 1 } };
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Example2_NoTriplets()
    {
        var result = new ThreeSum().ThreeSumSolution([0, 1, 1]);
        Assert.Empty(result);
    }

    [Fact]
    public void Example3_AllZeros()
    {
        var result = new ThreeSum().ThreeSumSolution([0, 0, 0]);
        Assert.Single(result);
        Assert.Equal([0, 0, 0], result[0]);
    }

    [Fact]
    public void NoTriplets()
    {
        var result = new ThreeSum().ThreeSumSolution([1, 2, 3]);
        Assert.Empty(result);
    }

    [Fact]
    public void MultipleTriplets()
    {
        var result = new ThreeSum().ThreeSumSolution([-2, -1, 0, 1, 2]);
        var sorted = SortResult(result);
        var expected = new List<List<int>> { new() { -2, 0, 2 }, new() { -1, 0, 1 } };
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void TwoElements()
    {
        var result = new ThreeSum().ThreeSumSolution([0, 0]);
        Assert.Empty(result);
    }

    [Fact]
    public void Empty()
    {
        var result = new ThreeSum().ThreeSumSolution([]);
        Assert.Empty(result);
    }
}
