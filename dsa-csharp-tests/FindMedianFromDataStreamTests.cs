public class FindMedianFromDataStreamTests
{
    [Fact]
    public void Example1()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(1);
        mf.AddNum(2);
        Assert.Equal(1.5, mf.FindMedian());
        mf.AddNum(3);
        Assert.Equal(2.0, mf.FindMedian());
    }

    [Fact]
    public void SingleElement()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(5);
        Assert.Equal(5.0, mf.FindMedian());
    }

    [Fact]
    public void TwoElements()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(1);
        mf.AddNum(2);
        Assert.Equal(1.5, mf.FindMedian());
    }

    [Fact]
    public void OddCount()
    {
        var mf = new FindMedianFromDataStream();
        foreach (var num in new[] { 1, 2, 3, 4, 5 })
            mf.AddNum(num);
        Assert.Equal(3.0, mf.FindMedian());
    }

    [Fact]
    public void EvenCount()
    {
        var mf = new FindMedianFromDataStream();
        foreach (var num in new[] { 1, 2, 3, 4 })
            mf.AddNum(num);
        Assert.Equal(2.5, mf.FindMedian());
    }

    [Fact]
    public void NegativeNumbers()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(-1);
        mf.AddNum(-2);
        mf.AddNum(-3);
        Assert.Equal(-2.0, mf.FindMedian());
    }

    [Fact]
    public void Duplicates()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(1);
        mf.AddNum(1);
        mf.AddNum(1);
        Assert.Equal(1.0, mf.FindMedian());
    }

    [Fact]
    public void UnsortedInput()
    {
        var mf = new FindMedianFromDataStream();
        mf.AddNum(6);
        Assert.Equal(6.0, mf.FindMedian());
        mf.AddNum(10);
        Assert.Equal(8.0, mf.FindMedian());
        mf.AddNum(2);
        Assert.Equal(6.0, mf.FindMedian());
    }
}
