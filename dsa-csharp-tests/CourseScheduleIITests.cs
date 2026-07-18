public class CourseScheduleIITests
{
    [Fact]
    public void Example1()
    {
        var result = new CourseScheduleII().FindOrder(2, [[1, 0]]);
        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void Example2()
    {
        var result = new CourseScheduleII().FindOrder(4, [[1, 0], [2, 0], [3, 1], [3, 2]]);
        Assert.Equal(4, result.Length);
        // Verify ordering constraints
        Assert.True(Array.IndexOf(result, 0) < Array.IndexOf(result, 1));
        Assert.True(Array.IndexOf(result, 0) < Array.IndexOf(result, 2));
    }

    [Fact]
    public void Example3()
    {
        var result = new CourseScheduleII().FindOrder(1, []);
        Assert.Equal([0], result);
    }

    [Fact]
    public void Cycle()
    {
        var result = new CourseScheduleII().FindOrder(2, [[1, 0], [0, 1]]);
        Assert.Empty(result);
    }

    [Fact]
    public void NoPrerequisites()
    {
        var result = new CourseScheduleII().FindOrder(3, []);
        Assert.Equal(3, result.Length);
    }

    [Fact]
    public void LinearChain()
    {
        var result = new CourseScheduleII().FindOrder(4, [[1, 0], [2, 1], [3, 2]]);
        Assert.Equal([0, 1, 2, 3], result);
    }

    [Fact]
    public void ComplexCycle()
    {
        var result = new CourseScheduleII().FindOrder(3, [[0, 1], [1, 2], [2, 0]]);
        Assert.Empty(result);
    }
}
