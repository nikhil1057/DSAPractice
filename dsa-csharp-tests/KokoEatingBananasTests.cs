public class KokoEatingBananasTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(4, new KokoEatingBananas().MinEatingSpeed(new[] { 3, 6, 7, 11 }, 8));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(30, new KokoEatingBananas().MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 5));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(23, new KokoEatingBananas().MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 6));
    }

    [Fact]
    public void SinglePile()
    {
        Assert.Equal(2, new KokoEatingBananas().MinEatingSpeed(new[] { 10 }, 5));
    }

    [Fact]
    public void HEqualsPiles()
    {
        Assert.Equal(11, new KokoEatingBananas().MinEatingSpeed(new[] { 3, 6, 7, 11 }, 4));
    }

    [Fact]
    public void LargeH()
    {
        Assert.Equal(1, new KokoEatingBananas().MinEatingSpeed(new[] { 1, 1, 1, 1 }, 100));
    }

    [Fact]
    public void AllSamePiles()
    {
        Assert.Equal(5, new KokoEatingBananas().MinEatingSpeed(new[] { 5, 5, 5 }, 3));
    }
}
