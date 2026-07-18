public class DecodeWaysTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new DecodeWays().NumDecodings("12"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3, new DecodeWays().NumDecodings("226"));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(0, new DecodeWays().NumDecodings("06"));
    }

    [Fact]
    public void SingleDigit()
    {
        Assert.Equal(1, new DecodeWays().NumDecodings("1"));
    }

    [Fact]
    public void LeadingZero()
    {
        Assert.Equal(0, new DecodeWays().NumDecodings("0"));
    }

    [Fact]
    public void DoubleZeros()
    {
        Assert.Equal(0, new DecodeWays().NumDecodings("100"));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(3, new DecodeWays().NumDecodings("111"));
    }

    [Fact]
    public void TwentySeven()
    {
        Assert.Equal(1, new DecodeWays().NumDecodings("27"));
    }
}
