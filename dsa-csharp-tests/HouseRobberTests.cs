public class HouseRobberTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new HouseRobber().Rob([1, 2, 3, 1]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(12, new HouseRobber().Rob([2, 7, 9, 3, 1]));
    }

    [Fact]
    public void SingleHouse()
    {
        Assert.Equal(5, new HouseRobber().Rob([5]));
    }

    [Fact]
    public void TwoHouses()
    {
        Assert.Equal(2, new HouseRobber().Rob([1, 2]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(6, new HouseRobber().Rob([3, 3, 3, 3]));
    }

    [Fact]
    public void LargeValues()
    {
        Assert.Equal(200, new HouseRobber().Rob([100, 1, 1, 100]));
    }

    [Fact]
    public void Alternating()
    {
        Assert.Equal(200, new HouseRobber().Rob([1, 100, 1, 100, 1]));
    }
}
