public class MeetingRoomsTests
{
    [Fact]
    public void Example1()
    {
        Assert.False(new MeetingRooms().CanAttendMeetings([[0, 30], [5, 10], [15, 20]]));
    }

    [Fact]
    public void Example2()
    {
        Assert.True(new MeetingRooms().CanAttendMeetings([[7, 10], [2, 4]]));
    }

    [Fact]
    public void Empty()
    {
        Assert.True(new MeetingRooms().CanAttendMeetings([]));
    }

    [Fact]
    public void SingleMeeting()
    {
        Assert.True(new MeetingRooms().CanAttendMeetings([[1, 5]]));
    }

    [Fact]
    public void AdjacentMeetings()
    {
        Assert.True(new MeetingRooms().CanAttendMeetings([[1, 5], [5, 10]]));
    }

    [Fact]
    public void OverlappingAtBoundary()
    {
        Assert.False(new MeetingRooms().CanAttendMeetings([[1, 5], [4, 10]]));
    }

    [Fact]
    public void MultipleNonOverlapping()
    {
        Assert.True(new MeetingRooms().CanAttendMeetings([[1, 2], [3, 4], [5, 6], [7, 8]]));
    }
}
