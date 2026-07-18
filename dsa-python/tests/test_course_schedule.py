from solutions.graphs.medium.course_schedule import CourseSchedule


class TestCourseSchedule:
    def setup_method(self):
        self.sol = CourseSchedule()

    def test_example1(self):
        assert self.sol.can_finish(2, [[1, 0]]) is True

    def test_example2(self):
        assert self.sol.can_finish(2, [[1, 0], [0, 1]]) is False

    def test_no_prerequisites(self):
        assert self.sol.can_finish(3, []) is True

    def test_single_course(self):
        assert self.sol.can_finish(1, []) is True

    def test_chain(self):
        assert self.sol.can_finish(4, [[1, 0], [2, 1], [3, 2]]) is True

    def test_complex_cycle(self):
        assert self.sol.can_finish(3, [[0, 1], [1, 2], [2, 0]]) is False

    def test_multiple_prerequisites(self):
        assert self.sol.can_finish(4, [[1, 0], [2, 0], [3, 1], [3, 2]]) is True

    def test_disconnected_courses(self):
        assert self.sol.can_finish(5, [[1, 0], [3, 2]]) is True
