public class HappyNumberTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new HappyNumber().IsHappy(19));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new HappyNumber().IsHappy(2));
    }

    [Fact]
    public void One()
    {
        Assert.True(new HappyNumber().IsHappy(1));
    }

    [Fact]
    public void Seven()
    {
        Assert.True(new HappyNumber().IsHappy(7));
    }

    [Fact]
    public void Four()
    {
        Assert.False(new HappyNumber().IsHappy(4));
    }

    [Fact]
    public void LargeHappy()
    {
        Assert.True(new HappyNumber().IsHappy(100));
    }

    [Fact]
    public void NotHappy()
    {
        Assert.False(new HappyNumber().IsHappy(20));
    }
}
