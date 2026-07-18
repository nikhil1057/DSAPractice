public class NumberOf1BitsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new NumberOf1Bits().HammingWeight(11));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new NumberOf1Bits().HammingWeight(128));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(30, new NumberOf1Bits().HammingWeight(2147483645));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal(0, new NumberOf1Bits().HammingWeight(0));
    }

    [Fact]
    public void One()
    {
        Assert.Equal(1, new NumberOf1Bits().HammingWeight(1));
    }

    [Fact]
    public void AllOnesByte()
    {
        Assert.Equal(8, new NumberOf1Bits().HammingWeight(255));
    }

    [Fact]
    public void PowerOfTwo()
    {
        Assert.Equal(1, new NumberOf1Bits().HammingWeight(16));
    }
}
