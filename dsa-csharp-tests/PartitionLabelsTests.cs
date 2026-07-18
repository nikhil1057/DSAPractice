public class PartitionLabelsTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(new List<int> { 9, 7, 8 }, new PartitionLabels().PartitionLabel("ababcbacadefegdehijhklij"));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(new List<int> { 10 }, new PartitionLabels().PartitionLabel("eccbbbbdec"));
    }

    [Fact]
    public void SingleChar()
    {
        Assert.Equal(new List<int> { 1 }, new PartitionLabels().PartitionLabel("a"));
    }

    [Fact]
    public void AllUnique()
    {
        Assert.Equal(new List<int> { 1, 1, 1, 1, 1, 1 }, new PartitionLabels().PartitionLabel("abcdef"));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(new List<int> { 4 }, new PartitionLabels().PartitionLabel("aaaa"));
    }

    [Fact]
    public void TwoPartitions()
    {
        Assert.Equal(new List<int> { 2, 2 }, new PartitionLabels().PartitionLabel("aabb"));
    }

    [Fact]
    public void Overlapping()
    {
        Assert.Equal(new List<int> { 4 }, new PartitionLabels().PartitionLabel("abab"));
    }
}
