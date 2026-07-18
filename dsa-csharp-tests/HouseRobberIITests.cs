public class HouseRobberIITests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new HouseRobberII().Rob([2, 3, 2]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, new HouseRobberII().Rob([1, 2, 3, 1]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(3, new HouseRobberII().Rob([1, 2, 3]));
    }

    [Fact]
    public void SingleHouse()
    {
        Assert.Equal(5, new HouseRobberII().Rob([5]));
    }

    [Fact]
    public void TwoHouses()
    {
        Assert.Equal(2, new HouseRobberII().Rob([1, 2]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(6, new HouseRobberII().Rob([3, 3, 3, 3]));
    }

    [Fact]
    public void LargeValues()
    {
        Assert.Equal(340, new HouseRobberII().Rob([200, 3, 140, 20, 10]));
    }
}
