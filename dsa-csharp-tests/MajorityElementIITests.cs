public class MajorityElementIITests
{
    [Fact]
    public void Example1()
    {
        // [3,2,3] => [3]
        var result = new MajorityElementII().MajorityElement([3, 2, 3]);
        Assert.Equal([3], result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void Example2()
    {
        // [1] => [1]
        var result = new MajorityElementII().MajorityElement([1]);
        Assert.Equal([1], result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void Example3()
    {
        // [1,2] => [1,2]
        var result = new MajorityElementII().MajorityElement([1, 2]);
        Assert.Equal([1, 2], result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void TwoMajorityElements()
    {
        // [1,1,1,2,2,2,3] => [1,2]
        var result = new MajorityElementII().MajorityElement([1, 1, 1, 2, 2, 2, 3]);
        Assert.Equal([1, 2], result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void NoMajority()
    {
        // [1,2,3,4] => []
        var result = new MajorityElementII().MajorityElement([1, 2, 3, 4]);
        Assert.Empty(result);
    }

    [Fact]
    public void AllSame()
    {
        var result = new MajorityElementII().MajorityElement([5, 5, 5, 5]);
        Assert.Equal([5], result.OrderBy(x => x).ToList());
    }

    [Fact]
    public void ExactlyOneThird()
    {
        // [1,1,2,2,3,3] — each appears 2 times, n/3=2, need >2, so none qualify
        var result = new MajorityElementII().MajorityElement([1, 1, 2, 2, 3, 3]);
        Assert.Empty(result);
    }

    [Fact]
    public void SingleElementRepeated()
    {
        var result = new MajorityElementII().MajorityElement([0, 0, 0]);
        Assert.Equal([0], result.OrderBy(x => x).ToList());
    }
}
