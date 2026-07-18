from solutions.graphs.medium.course_schedule_ii import CourseScheduleII


class TestCourseScheduleII:
    def setup_method(self):
        self.sol = CourseScheduleII()

    def test_example1(self):
        result = self.sol.find_order(2, [[1, 0]])
        assert result == [0, 1]

    def test_example2(self):
        result = self.sol.find_order(4, [[1, 0], [2, 0], [3, 1], [3, 2]])
        # Valid orderings: [0,1,2,3] or [0,2,1,3]
        assert result.index(0) < result.index(1)
        assert result.index(0) < result.index(2)
        assert result.index(1) < result.index(3)
        assert result.index(2) < result.index(3)

    def test_example3(self):
        result = self.sol.find_order(1, [])
        assert result == [0]

    def test_cycle(self):
        result = self.sol.find_order(2, [[1, 0], [0, 1]])
        assert result == []

    def test_no_prerequisites(self):
        result = self.sol.find_order(3, [])
        assert sorted(result) == [0, 1, 2]

    def test_linear_chain(self):
        result = self.sol.find_order(4, [[1, 0], [2, 1], [3, 2]])
        assert result == [0, 1, 2, 3]

    def test_complex_cycle(self):
        result = self.sol.find_order(3, [[0, 1], [1, 2], [2, 0]])
        assert result == []

    def test_multiple_valid_orders(self):
        result = self.sol.find_order(3, [[2, 0], [2, 1]])
        assert result.index(0) < result.index(2)
        assert result.index(1) < result.index(2)
