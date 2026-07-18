public class NonOverlappingIntervalsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(1, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 2], [2, 3], [3, 4], [1, 3]]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(2, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 2], [1, 2], [1, 2]]));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(0, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 2], [2, 3]]));
    }

    [Fact]
    public void NoIntervals()
    {
        Assert.Equal(0, new NonOverlappingIntervals().EraseOverlapIntervals([]));
    }

    [Fact]
    public void SingleInterval()
    {
        Assert.Equal(0, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 5]]));
    }

    [Fact]
    public void AllOverlap()
    {
        Assert.Equal(2, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 4], [2, 5], [3, 6]]));
    }

    [Fact]
    public void Nested()
    {
        Assert.Equal(1, new NonOverlappingIntervals().EraseOverlapIntervals([[1, 10], [2, 3], [4, 5]]));
    }
}
