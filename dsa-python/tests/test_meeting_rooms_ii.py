from solutions.intervals.medium.meeting_rooms_ii import MeetingRoomsII


class TestMeetingRoomsII:
    def setup_method(self):
        self.sol = MeetingRoomsII()

    def test_example1(self):
        assert self.sol.min_meeting_rooms([[0, 30], [5, 10], [15, 20]]) == 2

    def test_example2(self):
        assert self.sol.min_meeting_rooms([[7, 10], [2, 4]]) == 1

    def test_single_meeting(self):
        assert self.sol.min_meeting_rooms([[1, 5]]) == 1

    def test_no_overlap(self):
        assert self.sol.min_meeting_rooms([[1, 2], [3, 4], [5, 6]]) == 1

    def test_all_overlap(self):
        assert self.sol.min_meeting_rooms([[1, 5], [2, 6], [3, 7]]) == 3

    def test_adjacent(self):
        assert self.sol.min_meeting_rooms([[1, 5], [5, 10]]) == 1

    def test_nested(self):
        assert self.sol.min_meeting_rooms([[1, 10], [2, 5], [3, 4]]) == 3
