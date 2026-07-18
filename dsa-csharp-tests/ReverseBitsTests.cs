public class ReverseBitsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(964176192u, new ReverseBits().ReverseBitsMethod(43261596u));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(3221225471u, new ReverseBits().ReverseBitsMethod(4294967293u));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal(0u, new ReverseBits().ReverseBitsMethod(0u));
    }

    [Fact]
    public void One()
    {
        Assert.Equal(2147483648u, new ReverseBits().ReverseBitsMethod(1u));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal(4294967295u, new ReverseBits().ReverseBitsMethod(4294967295u));
    }

    [Fact]
    public void PowerOfTwo()
    {
        Assert.Equal(536870912u, new ReverseBits().ReverseBitsMethod(4u));
    }
}
