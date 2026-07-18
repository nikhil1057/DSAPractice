public class CheapestFlightsWithinKStopsTests
{
    [Fact]
    public void Example1()
    {
        int[][] flights = [[0, 1, 100], [1, 2, 100], [2, 0, 100], [1, 3, 600], [2, 3, 200]];
        Assert.Equal(700, new CheapestFlightsWithinKStops().FindCheapestPrice(4, flights, 0, 3, 1));
    }

    [Fact]
    public void Example2()
    {
        int[][] flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]];
        Assert.Equal(200, new CheapestFlightsWithinKStops().FindCheapestPrice(3, flights, 0, 2, 1));
    }

    [Fact]
    public void Example3_ZeroStops()
    {
        int[][] flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]];
        Assert.Equal(500, new CheapestFlightsWithinKStops().FindCheapestPrice(3, flights, 0, 2, 0));
    }

    [Fact]
    public void NoRoute()
    {
        int[][] flights = [[0, 1, 100]];
        Assert.Equal(-1, new CheapestFlightsWithinKStops().FindCheapestPrice(3, flights, 0, 2, 1));
    }

    [Fact]
    public void DirectFlight()
    {
        int[][] flights = [[0, 1, 50]];
        Assert.Equal(50, new CheapestFlightsWithinKStops().FindCheapestPrice(2, flights, 0, 1, 0));
    }

    [Fact]
    public void KTooSmall()
    {
        int[][] flights = [[0, 1, 1], [1, 2, 1], [2, 3, 1]];
        Assert.Equal(-1, new CheapestFlightsWithinKStops().FindCheapestPrice(4, flights, 0, 3, 1));
    }

    [Fact]
    public void SameSrcDst()
    {
        int[][] flights = [[0, 1, 100], [1, 2, 100]];
        Assert.Equal(0, new CheapestFlightsWithinKStops().FindCheapestPrice(3, flights, 0, 0, 0));
    }
}
