public class ContiguousArrayTests
{
    [Fact]
    public void Example1()
    {
        // [0,1] => 2
        Assert.Equal(2, new ContiguousArray().FindMaxLength([0, 1]));
    }

    [Fact]
    public void Example2()
    {
        // [0,1,0] => 2
        Assert.Equal(2, new ContiguousArray().FindMaxLength([0, 1, 0]));
    }

    [Fact]
    public void AllZeros()
    {
        Assert.Equal(0, new ContiguousArray().FindMaxLength([0, 0, 0]));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(0, new ContiguousArray().FindMaxLength([1, 1, 1]));
    }

    [Fact]
    public void EntireArray()
    {
        // [0,1,1,0] => 4
        Assert.Equal(4, new ContiguousArray().FindMaxLength([0, 1, 1, 0]));
    }

    [Fact]
    public void LongerArray()
    {
        // [0,0,1,0,0,0,1,1] => 6 (subarray [1,0,0,0,1,1] at index 2..7)
        Assert.Equal(6, new ContiguousArray().FindMaxLength([0, 0, 1, 0, 0, 0, 1, 1]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(0, new ContiguousArray().FindMaxLength([0]));
    }

    [Fact]
    public void AlternatingLong()
    {
        // [0,1,0,1,0,1] => 6
        Assert.Equal(6, new ContiguousArray().FindMaxLength([0, 1, 0, 1, 0, 1]));
    }
}
