public class MultiplyStringsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal("6", new MultiplyStrings().Multiply("2", "3"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal("56088", new MultiplyStrings().Multiply("123", "456"));
    }

    [Fact]
    public void MultiplyByZero()
    {
        Assert.Equal("0", new MultiplyStrings().Multiply("0", "12345"));
    }

    [Fact]
    public void BothZeros()
    {
        Assert.Equal("0", new MultiplyStrings().Multiply("0", "0"));
    }

    [Fact]
    public void SingleDigits()
    {
        Assert.Equal("81", new MultiplyStrings().Multiply("9", "9"));
    }

    [Fact]
    public void LargeNumbers()
    {
        Assert.Equal("998001", new MultiplyStrings().Multiply("999", "999"));
    }

    [Fact]
    public void OneByNumber()
    {
        Assert.Equal("456", new MultiplyStrings().Multiply("1", "456"));
    }
}
