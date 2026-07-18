from solutions.intervals.easy.meeting_rooms import MeetingRooms


class TestMeetingRooms:
    def setup_method(self):
        self.sol = MeetingRooms()

    def test_example1(self):
        assert self.sol.can_attend_meetings([[0, 30], [5, 10], [15, 20]]) is False

    def test_example2(self):
        assert self.sol.can_attend_meetings([[7, 10], [2, 4]]) is True

    def test_empty(self):
        assert self.sol.can_attend_meetings([]) is True

    def test_single_meeting(self):
        assert self.sol.can_attend_meetings([[1, 5]]) is True

    def test_adjacent_meetings(self):
        assert self.sol.can_attend_meetings([[1, 5], [5, 10]]) is True

    def test_overlapping_at_boundary(self):
        assert self.sol.can_attend_meetings([[1, 5], [4, 10]]) is False

    def test_multiple_non_overlapping(self):
        assert self.sol.can_attend_meetings([[1, 2], [3, 4], [5, 6], [7, 8]]) is True
