public class MeetingRoomsIITests
{
    [Fact]
    public void Example1()
    {
        Assert.Equal(2, new MeetingRoomsII().MinMeetingRooms([[0, 30], [5, 10], [15, 20]]));
    }

    [Fact]
    public void Example2()
    {
        Assert.Equal(1, new MeetingRoomsII().MinMeetingRooms([[7, 10], [2, 4]]));
    }

    [Fact]
    public void SingleMeeting()
    {
        Assert.Equal(1, new MeetingRoomsII().MinMeetingRooms([[1, 5]]));
    }

    [Fact]
    public void NoOverlap()
    {
        Assert.Equal(1, new MeetingRoomsII().MinMeetingRooms([[1, 2], [3, 4], [5, 6]]));
    }

    [Fact]
    public void AllOverlap()
    {
        Assert.Equal(3, new MeetingRoomsII().MinMeetingRooms([[1, 5], [2, 6], [3, 7]]));
    }

    [Fact]
    public void Adjacent()
    {
        Assert.Equal(1, new MeetingRoomsII().MinMeetingRooms([[1, 5], [5, 10]]));
    }

    [Fact]
    public void Nested()
    {
        Assert.Equal(3, new MeetingRoomsII().MinMeetingRooms([[1, 10], [2, 5], [3, 4]]));
    }
}
