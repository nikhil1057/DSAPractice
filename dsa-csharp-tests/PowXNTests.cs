public class PowXNTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(1024.0, new PowXN().MyPow(2.0, 10), 5);
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(9.261, new PowXN().MyPow(2.1, 3), 3);
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(0.25, new PowXN().MyPow(2.0, -2), 5);
    }

    [Fact]
    public void ZeroExponent()
    {
        Assert.Equal(1.0, new PowXN().MyPow(5.0, 0), 5);
    }

    [Fact]
    public void OneExponent()
    {
        Assert.Equal(3.0, new PowXN().MyPow(3.0, 1), 5);
    }

    [Fact]
    public void NegativeBase()
    {
        Assert.Equal(-8.0, new PowXN().MyPow(-2.0, 3), 5);
    }

    [Fact]
    public void ZeroBase()
    {
        Assert.Equal(0.0, new PowXN().MyPow(0.0, 5), 5);
    }

    [Fact]
    public void LargeNegativeExponent()
    {
        Assert.Equal(0.125, new PowXN().MyPow(2.0, -3), 5);
    }
}
