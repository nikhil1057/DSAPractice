public class MissingNumberTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new MissingNumber().MissingNum([3, 0, 1]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(2, new MissingNumber().MissingNum([0, 1]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(8, new MissingNumber().MissingNum([9, 6, 4, 2, 3, 5, 7, 0, 1]));
    }

    [Fact]
    public void MissingZero()
    {
        Assert.Equal(0, new MissingNumber().MissingNum([1]));
    }

    [Fact]
    public void MissingN()
    {
        Assert.Equal(1, new MissingNumber().MissingNum([0]));
    }

    [Fact]
    public void MissingMiddle()
    {
        Assert.Equal(4, new MissingNumber().MissingNum([0, 1, 2, 3, 5]));
    }

    [Fact]
    public void LargerArray()
    {
        Assert.Equal(1, new MissingNumber().MissingNum([0, 2, 3, 4, 5]));
    }
}
