public class TrappingRainWaterTests
{
    [Fact]
    public void Example1()
    {
        // [0,1,0,2,1,0,1,3,2,1,2,1] => 6
        Assert.Equal(6, new TrappingRainWater().Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]));
    }

    [Fact]
    public void Example2()
    {
        // [4,2,0,3,2,5] => 9
        Assert.Equal(9, new TrappingRainWater().Trap([4, 2, 0, 3, 2, 5]));
    }

    [Fact]
    public void NoWater_Ascending()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([1, 2, 3, 4, 5]));
    }

    [Fact]
    public void NoWater_Descending()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void Empty()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([5]));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([3, 1]));
    }

    [Fact]
    public void Flat()
    {
        Assert.Equal(0, new TrappingRainWater().Trap([3, 3, 3, 3]));
    }
}
