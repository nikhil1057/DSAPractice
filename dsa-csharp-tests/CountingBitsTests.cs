public class CountingBitsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal([0, 1, 1], new CountingBits().CountBits(2));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal([0, 1, 1, 2, 1, 2], new CountingBits().CountBits(5));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal([0], new CountingBits().CountBits(0));
    }

    [Fact]
    public void One()
    {
        Assert.Equal([0, 1], new CountingBits().CountBits(1));
    }

    [Fact]
    public void Eight()
    {
        Assert.Equal([0, 1, 1, 2, 1, 2, 2, 3, 1], new CountingBits().CountBits(8));
    }

    [Fact]
    public void Three()
    {
        Assert.Equal([0, 1, 1, 2], new CountingBits().CountBits(3));
    }
}
