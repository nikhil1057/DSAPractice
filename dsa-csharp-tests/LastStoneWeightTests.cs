public class LastStoneWeightTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(1, new LastStoneWeight().LastStoneWeightMethod([2, 7, 4, 1, 8, 1]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new LastStoneWeight().LastStoneWeightMethod([1]));
    }

    [Fact]
    public void TwoEqualStones()
    {
        Assert.Equal(0, new LastStoneWeight().LastStoneWeightMethod([2, 2]));
    }

    [Fact]
    public void TwoDifferentStones()
    {
        Assert.Equal(4, new LastStoneWeight().LastStoneWeightMethod([3, 7]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(0, new LastStoneWeight().LastStoneWeightMethod([5, 5, 5, 5]));
    }

    [Fact]
    public void Decreasing()
    {
        Assert.Equal(1, new LastStoneWeight().LastStoneWeightMethod([10, 5, 3, 1]));
    }

    [Fact]
    public void LargeValues()
    {
        Assert.Equal(1, new LastStoneWeight().LastStoneWeightMethod([1000, 999]));
    }
}
