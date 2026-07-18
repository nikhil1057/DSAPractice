public class TaskSchedulerTests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(8, new TaskScheduler().LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 2));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(6, new TaskScheduler().LeastInterval(['A', 'C', 'A', 'B', 'D', 'B'], 1));
    }

    [Fact]
    public void Example3()
    {
        Assert.Equal(10, new TaskScheduler().LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 3));
    }

    [Fact]
    public void NoCooldown()
    {
        Assert.Equal(6, new TaskScheduler().LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 0));
    }

    [Fact]
    public void SingleTask()
    {
        Assert.Equal(1, new TaskScheduler().LeastInterval(['A'], 2));
    }

    [Fact]
    public void AllSame()
    {
        Assert.Equal(10, new TaskScheduler().LeastInterval(['A', 'A', 'A', 'A'], 2));
    }

    [Fact]
    public void ManyDifferent()
    {
        Assert.Equal(5, new TaskScheduler().LeastInterval(['A', 'B', 'C', 'D', 'E'], 2));
    }
}
