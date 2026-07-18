public class CourseScheduleTests
{
    [Fact]
    public void Example1()
    {
        Assert.True(new CourseSchedule().CanFinish(2, [[1, 0]]));
    }

    [Fact]
    public void Example2_Cycle()
    {
        Assert.False(new CourseSchedule().CanFinish(2, [[1, 0], [0, 1]]));
    }

    [Fact]
    public void NoPrerequisites()
    {
        Assert.True(new CourseSchedule().CanFinish(3, []));
    }

    [Fact]
    public void SingleCourse()
    {
        Assert.True(new CourseSchedule().CanFinish(1, []));
    }

    [Fact]
    public void Chain()
    {
        Assert.True(new CourseSchedule().CanFinish(4, [[1, 0], [2, 1], [3, 2]]));
    }

    [Fact]
    public void ComplexCycle()
    {
        Assert.False(new CourseSchedule().CanFinish(3, [[0, 1], [1, 2], [2, 0]]));
    }

    [Fact]
    public void MultiplePrerequisites()
    {
        Assert.True(new CourseSchedule().CanFinish(4, [[1, 0], [2, 0], [3, 1], [3, 2]]));
    }
}
