public class CarFleetTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(3, new CarFleet().CarFleetMethod(12, new[] { 10, 8, 0, 5, 3 }, new[] { 2, 4, 1, 1, 3 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new CarFleet().CarFleetMethod(10, new[] { 3 }, new[] { 3 }));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(1, new CarFleet().CarFleetMethod(100, new[] { 0, 2, 4 }, new[] { 4, 2, 1 }));
    }

    [Fact]
    public void NoCars()
    {
        Assert.Equal(0, new CarFleet().CarFleetMethod(10, new int[] { }, new int[] { }));
    }

    [Fact]
    public void TwoCarsSameSpeed()
    {
        Assert.Equal(2, new CarFleet().CarFleetMethod(10, new[] { 0, 5 }, new[] { 1, 1 }));
    }

    [Fact]
    public void AllArriveSameTime()
    {
        Assert.Equal(1, new CarFleet().CarFleetMethod(10, new[] { 0, 5 }, new[] { 2, 1 }));
    }

    [Fact]
    public void CarAtTarget()
    {
        Assert.Equal(1, new CarFleet().CarFleetMethod(10, new[] { 10 }, new[] { 1 }));
    }
}
