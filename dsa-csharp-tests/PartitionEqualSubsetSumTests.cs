public class PartitionEqualSubsetSumTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new PartitionEqualSubsetSum().CanPartition([1, 5, 11, 5]));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new PartitionEqualSubsetSum().CanPartition([1, 2, 3, 5]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.False(new PartitionEqualSubsetSum().CanPartition([1]));
    }

    [Fact]
    public void TwoEqualElements()
    {
        Assert.True(new PartitionEqualSubsetSum().CanPartition([1, 1]));
    }

    [Fact]
    public void TwoUnequalElements()
    {
        Assert.False(new PartitionEqualSubsetSum().CanPartition([1, 2]));
    }

    [Fact]
    public void AllZeros()
    {
        Assert.True(new PartitionEqualSubsetSum().CanPartition([0, 0, 0, 0]));
    }

    [Fact]
    public void LargeEqualPartition()
    {
        Assert.True(new PartitionEqualSubsetSum().CanPartition([1, 2, 3, 4, 5, 5]));
    }

    [Fact]
    public void OddTotalSum()
    {
        Assert.False(new PartitionEqualSubsetSum().CanPartition([1, 2, 4]));
    }
}
