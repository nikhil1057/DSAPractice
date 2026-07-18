public class GasStationTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new GasStation().CanCompleteCircuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(-1, new GasStation().CanCompleteCircuit([2, 3, 4], [3, 4, 3]));
    }

    [Fact]
    public void SingleStation()
    {
        Assert.Equal(0, new GasStation().CanCompleteCircuit([5], [3]));
    }

    [Fact]
    public void SingleStationImpossible()
    {
        Assert.Equal(-1, new GasStation().CanCompleteCircuit([3], [5]));
    }

    [Fact]
    public void StartAtZero()
    {
        Assert.Equal(0, new GasStation().CanCompleteCircuit([3, 1, 1], [1, 1, 1]));
    }

    [Fact]
    public void AllEqual()
    {
        Assert.Equal(0, new GasStation().CanCompleteCircuit([1, 1, 1], [1, 1, 1]));
    }

    [Fact]
    public void LargerExample()
    {
        Assert.Equal(3, new GasStation().CanCompleteCircuit([5, 8, 2, 8], [6, 5, 6, 6]));
    }
}
