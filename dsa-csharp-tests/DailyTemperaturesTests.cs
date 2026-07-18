public class DailyTemperaturesTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(new[] { 1, 1, 4, 2, 1, 1, 0, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(new[] { 1, 1, 1, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 30, 40, 50, 60 }));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(new[] { 1, 1, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 30, 60, 90 }));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(new[] { 0, 0, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 50, 50, 50 }));
    }

    [Fact]
    public void Decreasing()
    {
        Assert.Equal(new[] { 0, 0, 0, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 90, 80, 70, 60 }));
    }

    [Fact]
    public void SingleElement()
    {
        Assert.Equal(new[] { 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 50 }));
    }

    [Fact]
    public void TwoElementsWarmer()
    {
        Assert.Equal(new[] { 1, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 30, 50 }));
    }

    [Fact]
    public void TwoElementsCooler()
    {
        Assert.Equal(new[] { 0, 0 },
            new DailyTemperatures().DailyTemperaturesMethod(new[] { 50, 30 }));
    }
}
