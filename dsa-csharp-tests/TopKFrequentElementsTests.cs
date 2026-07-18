public class TopKFrequentElementsTests
{
    [Fact]
    public void Example1()
    {
        // [1,1,1,2,2,3], k=2 => [1,2]
        var result = new TopKFrequentElements().TopKFrequent([1, 1, 1, 2, 2, 3], 2);
        Array.Sort(result);
        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void Example2()
    {
        // [1], k=1 => [1]
        var result = new TopKFrequentElements().TopKFrequent([1], 1);
        Assert.Equal([1], result);
    }

    [Fact]
    public void AllSameFrequency()
    {
        // [1,2,3], k=3 => [1,2,3]
        var result = new TopKFrequentElements().TopKFrequent([1, 2, 3], 3);
        Array.Sort(result);
        Assert.Equal([1, 2, 3], result);
    }

    [Fact]
    public void NegativeNumbers()
    {
        var result = new TopKFrequentElements().TopKFrequent([-1, -1, 2, 2, 3], 2);
        Array.Sort(result);
        Assert.Equal([-1, 2], result);
    }

    [Fact]
    public void SingleElementRepeated()
    {
        var result = new TopKFrequentElements().TopKFrequent([5, 5, 5, 5], 1);
        Assert.Equal([5], result);
    }

    [Fact]
    public void KEqualsArrayLength()
    {
        var result = new TopKFrequentElements().TopKFrequent([1, 2, 3, 4], 4);
        Array.Sort(result);
        Assert.Equal([1, 2, 3, 4], result);
    }
}
