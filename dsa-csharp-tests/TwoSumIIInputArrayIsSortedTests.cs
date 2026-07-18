public class TwoSumIIInputArrayIsSortedTests
{
    [Fact]
    public void Example1()
    {
        // [2,7,11,15], target=9 => [1,2]
        Assert.Equal([1, 2], new TwoSumIIInputArrayIsSorted().TwoSum([2, 7, 11, 15], 9));
    }

    [Fact]
    public void Example2()
    {
        // [2,3,4], target=6 => [1,3]
        Assert.Equal([1, 3], new TwoSumIIInputArrayIsSorted().TwoSum([2, 3, 4], 6));
    }

    [Fact]
    public void Example3()
    {
        // [-1,0], target=-1 => [1,2]
        Assert.Equal([1, 2], new TwoSumIIInputArrayIsSorted().TwoSum([-1, 0], -1));
    }

    [Fact]
    public void FirstAndLast()
    {
        Assert.Equal([1, 5], new TwoSumIIInputArrayIsSorted().TwoSum([1, 2, 3, 4, 5], 6));
    }

    [Fact]
    public void AdjacentElements()
    {
        Assert.Equal([1, 2], new TwoSumIIInputArrayIsSorted().TwoSum([1, 2, 3, 4], 3));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal([2, 3], new TwoSumIIInputArrayIsSorted().TwoSum([-5, -3, -1, 0, 2, 4], -4));
    }

    [Fact]
    public void LargeTarget()
    {
        Assert.Equal([4, 5], new TwoSumIIInputArrayIsSorted().TwoSum([1, 5, 10, 20, 50], 70));
    }
}
