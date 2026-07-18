public class ContainsDuplicateTests
{
    [Fact]
    public void Example1_HasDuplicate()
    {
        // [1,2,3,1] => true
        Assert.True(new ContainsDuplicate().ContainsDuplicateSolution([1, 2, 3, 1]));
    }

    [Fact]
    public void Example2_NoDuplicate()
    {
        // [1,2,3,4] => false
        Assert.False(new ContainsDuplicate().ContainsDuplicateSolution([1, 2, 3, 4]));
    }

    [Fact]
    public void Example3_MultipleDuplicates()
    {
        // [1,1,1,3,3,4,3,2,4,2] => true
        Assert.True(new ContainsDuplicate().ContainsDuplicateSolution([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.False(new ContainsDuplicate().ContainsDuplicateSolution([1]));
    }

    [Fact]
    public void TwoSameElements()
    {
        Assert.True(new ContainsDuplicate().ContainsDuplicateSolution([5, 5]));
    }

    [Fact]
    public void EmptyArray()
    {
        Assert.False(new ContainsDuplicate().ContainsDuplicateSolution([]));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.True(new ContainsDuplicate().ContainsDuplicateSolution([-1, -2, -3, -1]));
    }

    [Fact]
    public void LargeRangeNoDuplicates()
    {
        var nums = Enumerable.Range(0, 1000).ToArray();
        Assert.False(new ContainsDuplicate().ContainsDuplicateSolution(nums));
    }
}
