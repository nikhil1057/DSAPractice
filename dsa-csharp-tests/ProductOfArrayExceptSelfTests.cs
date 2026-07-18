public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void Example1()
    {
        // [1,2,3,4] => [24,12,8,6]
        Assert.Equal([24, 12, 8, 6], new ProductOfArrayExceptSelf().ProductExceptSelf([1, 2, 3, 4]));
    }

    [Fact]
    public void Example2()
    {
        // [-1,1,0,-3,3] => [0,0,9,0,0]
        Assert.Equal([0, 0, 9, 0, 0], new ProductOfArrayExceptSelf().ProductExceptSelf([-1, 1, 0, -3, 3]));
    }

    [Fact]
    public void TwoElements()
    {
        Assert.Equal([3, 2], new ProductOfArrayExceptSelf().ProductExceptSelf([2, 3]));
    }

    [Fact]
    public void ContainsZero()
    {
        Assert.Equal([6, 0, 0, 0], new ProductOfArrayExceptSelf().ProductExceptSelf([0, 1, 2, 3]));
    }

    [Fact]
    public void MultipleZeros()
    {
        Assert.Equal([0, 0, 0], new ProductOfArrayExceptSelf().ProductExceptSelf([0, 0, 1]));
    }

    [Fact]
    public void AllOnes()
    {
        Assert.Equal([1, 1, 1, 1], new ProductOfArrayExceptSelf().ProductExceptSelf([1, 1, 1, 1]));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal([6, 3, 2], new ProductOfArrayExceptSelf().ProductExceptSelf([-1, -2, -3]));
    }
}
