public class TwoSumTests
{
    [Fact]
    public void Example1()
    {
        // [2,7,11,15], target=9 => [0,1]
        var result = new TwoSum().TwoSumSolution([2, 7, 11, 15], 9);
        Array.Sort(result);
        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void Example2()
    {
        // [3,2,4], target=6 => [1,2]
        var result = new TwoSum().TwoSumSolution([3, 2, 4], 6);
        Array.Sort(result);
        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void Example3()
    {
        // [3,3], target=6 => [0,1]
        var result = new TwoSum().TwoSumSolution([3, 3], 6);
        Array.Sort(result);
        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void NegativeNumbers()
    {
        var result = new TwoSum().TwoSumSolution([-1, -2, -3, -4, -5], -8);
        Array.Sort(result);
        Assert.Equal([2, 4], result);
    }

    [Fact]
    public void ZeroTarget()
    {
        var result = new TwoSum().TwoSumSolution([-1, 0, 1, 2], 0);
        Array.Sort(result);
        Assert.Equal([0, 2], result);
    }

    [Fact]
    public void LargeNumbers()
    {
        var result = new TwoSum().TwoSumSolution([1000000, 500000, 500000], 1000000);
        Array.Sort(result);
        Assert.Equal([1, 2], result);
    }
}
