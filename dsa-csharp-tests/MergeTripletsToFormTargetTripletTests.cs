public class MergeTripletsToFormTargetTripletTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new MergeTripletsToFormTargetTriplet().MergeTriplets([[2, 5, 3], [1, 8, 4], [1, 7, 5]], [2, 7, 5]));
    }

    [Fact]
    public void Example2()
    {
        Assert.False(new MergeTripletsToFormTargetTriplet().MergeTriplets([[3, 4, 5], [4, 5, 6]], [3, 2, 5]));
    }

    [Fact]
    public void Example3()
    {
        Assert.True(new MergeTripletsToFormTargetTriplet().MergeTriplets([[2, 5, 3], [2, 3, 4], [1, 2, 5], [5, 2, 3]], [5, 5, 5]));
    }

    [Fact]
    public void SingleTripletMatch()
    {
        Assert.True(new MergeTripletsToFormTargetTriplet().MergeTriplets([[1, 2, 3]], [1, 2, 3]));
    }

    [Fact]
    public void SingleTripletNoMatch()
    {
        Assert.False(new MergeTripletsToFormTargetTriplet().MergeTriplets([[1, 2, 3]], [1, 2, 4]));
    }

    [Fact]
    public void AllExceedOneValue()
    {
        Assert.False(new MergeTripletsToFormTargetTriplet().MergeTriplets([[4, 1, 1], [1, 4, 1], [1, 1, 4]], [3, 3, 3]));
    }
}
