public class LongestConsecutiveSequenceTests
{
    [Fact]
    public void Example1()
    {
        // [100,4,200,1,3,2] => 4
        Assert.Equal(4, new LongestConsecutiveSequence().LongestConsecutive([100, 4, 200, 1, 3, 2]));
    }

    [Fact]
    public void Example2()
    {
        // [0,3,7,2,5,8,4,6,0,1] => 9
        Assert.Equal(9, new LongestConsecutiveSequence().LongestConsecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]));
    }

    [Fact]
    public void EmptyArray()
    {
        Assert.Equal(0, new LongestConsecutiveSequence().LongestConsecutive([]));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(1, new LongestConsecutiveSequence().LongestConsecutive([1]));
    }

    [Fact]
    public void NoConsecutive()
    {
        Assert.Equal(1, new LongestConsecutiveSequence().LongestConsecutive([10, 20, 30]));
    }

    [Fact]
    public void Duplicates()
    {
        // [1,2,0,1] => 3
        Assert.Equal(3, new LongestConsecutiveSequence().LongestConsecutive([1, 2, 0, 1]));
    }

    [Fact]
    public void NegativeNumbers()
    {
        Assert.Equal(5, new LongestConsecutiveSequence().LongestConsecutive([-3, -2, -1, 0, 1]));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(1, new LongestConsecutiveSequence().LongestConsecutive([5, 5, 5, 5]));
    }
}
