public class DetectSquaresTests
{
    [Fact]
    public void Example()
    {
        var ds = new DetectSquares();
        ds.Add([3, 10]);
        ds.Add([11, 1]);
        ds.Add([3, 1]);
        Assert.Equal(1, ds.Count([11, 10]));
        Assert.Equal(0, ds.Count([14, 8]));
        ds.Add([11, 10]);
        Assert.Equal(1, ds.Count([11, 10]));
    }

    [Fact]
    public void NoPoints()
    {
        var ds = new DetectSquares();
        Assert.Equal(0, ds.Count([0, 0]));
    }

    [Fact]
    public void DuplicatePoints()
    {
        var ds = new DetectSquares();
        ds.Add([0, 0]);
        ds.Add([0, 1]);
        ds.Add([1, 0]);
        ds.Add([1, 1]);
        ds.Add([1, 1]);
        Assert.Equal(2, ds.Count([0, 0]));
    }

    [Fact]
    public void MultipleSquares()
    {
        var ds = new DetectSquares();
        ds.Add([0, 0]);
        ds.Add([0, 2]);
        ds.Add([2, 0]);
        ds.Add([2, 2]);
        ds.Add([0, 1]);
        ds.Add([1, 0]);
        ds.Add([1, 1]);
        Assert.True(ds.Count([1, 1]) >= 1);
    }
}
