public class ContainerWithMostWaterTests
{
    [Fact]
    public void Example1()
    {
        // [1,8,6,2,5,4,8,3,7] => 49
        Assert.Equal(49, new ContainerWithMostWater().MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
    }

    [Fact]
    public void Example2()
    {
        // [1,1] => 1
        Assert.Equal(1, new ContainerWithMostWater().MaxArea([1, 1]));
    }

    [Fact]
    public void DecreasingHeights()
    {
        Assert.Equal(6, new ContainerWithMostWater().MaxArea([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void IncreasingHeights()
    {
        Assert.Equal(6, new ContainerWithMostWater().MaxArea([1, 2, 3, 4, 5]));
    }

    [Fact]
    public void SameHeights()
    {
        Assert.Equal(9, new ContainerWithMostWater().MaxArea([3, 3, 3, 3]));
    }

    [Fact]
    public void TwoTallEnds()
    {
        Assert.Equal(40, new ContainerWithMostWater().MaxArea([10, 1, 1, 1, 10]));
    }

    [Fact]
    public void SinglePeak()
    {
        Assert.Equal(2, new ContainerWithMostWater().MaxArea([1, 100, 1]));
    }
}
