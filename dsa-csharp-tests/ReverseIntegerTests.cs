public class ReverseIntegerTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(321, new ReverseInteger().Reverse(123));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(-321, new ReverseInteger().Reverse(-123));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(21, new ReverseInteger().Reverse(120));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal(0, new ReverseInteger().Reverse(0));
    }

    [Fact]
    public void SingleDigit()
    {
        Assert.Equal(5, new ReverseInteger().Reverse(5));
    }

    [Fact]
    public void OverflowPositive()
    {
        Assert.Equal(0, new ReverseInteger().Reverse(1534236469));
    }

    [Fact]
    public void OverflowNegative()
    {
        Assert.Equal(0, new ReverseInteger().Reverse(-2147483648));
    }

    [Fact]
    public void TrailingZeros()
    {
        Assert.Equal(1, new ReverseInteger().Reverse(1000));
    }
}
