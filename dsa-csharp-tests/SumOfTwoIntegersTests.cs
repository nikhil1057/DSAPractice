public class SumOfTwoIntegersTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new SumOfTwoIntegers().GetSum(1, 2));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(5, new SumOfTwoIntegers().GetSum(2, 3));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal(-2, new SumOfTwoIntegers().GetSum(-1, -1));
    }

    [Fact]
    public void PositiveAndNegative()
    {
        Assert.Equal(2, new SumOfTwoIntegers().GetSum(5, -3));
    }

    [Fact]
    public void Zero()
    {
        Assert.Equal(0, new SumOfTwoIntegers().GetSum(0, 0));
    }

    [Fact]
    public void NegativeResult()
    {
        Assert.Equal(-2, new SumOfTwoIntegers().GetSum(-5, 3));
    }

    [Fact]
    public void LargePositive()
    {
        Assert.Equal(300, new SumOfTwoIntegers().GetSum(100, 200));
    }
}
