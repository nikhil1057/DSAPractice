public class SingleNumberTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(1, new SingleNumber().SingleNum([2, 2, 1]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(4, new SingleNumber().SingleNum([4, 1, 2, 1, 2]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(1, new SingleNumber().SingleNum([1]));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal(-2, new SingleNumber().SingleNum([-1, -1, -2]));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal(0, new SingleNumber().SingleNum([0, 1, 1]));
    }

    [Fact]
    public void LargeArray()
    {
        Assert.Equal(10, new SingleNumber().SingleNum([3, 3, 7, 7, 10]));
    }
}
