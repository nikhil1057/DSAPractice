public class HandOfStraightsTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new HandOfStraights().IsNStraightHand([1, 2, 3, 6, 2, 3, 4, 7, 8], 3));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new HandOfStraights().IsNStraightHand([1, 2, 3, 4, 5], 4));
    }

    [Fact]
    public void GroupSizeOne()
    {
        Assert.True(new HandOfStraights().IsNStraightHand([5, 1, 2], 1));
    }

    [Fact]
    public void NotDivisible()
    {
        Assert.False(new HandOfStraights().IsNStraightHand([1, 2, 3, 4, 5], 3));
    }

    [Fact]
    public void SingleGroup()
    {
        Assert.True(new HandOfStraights().IsNStraightHand([1, 2, 3], 3));
    }

    [Fact]
    public void Duplicates()
    {
        Assert.True(new HandOfStraights().IsNStraightHand([1, 1, 2, 2, 3, 3], 3));
    }

    [Fact]
    public void GapInSequence()
    {
        Assert.False(new HandOfStraights().IsNStraightHand([1, 2, 4, 5, 6, 7], 3));
    }
}
