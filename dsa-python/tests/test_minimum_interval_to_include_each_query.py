from solutions.intervals.hard.minimum_interval_to_include_each_query import MinimumIntervalToIncludeEachQuery


class TestMinimumIntervalToIncludeEachQuery:
    def setup_method(self):
        self.sol = MinimumIntervalToIncludeEachQuery()

    def test_example1(self):
        assert self.sol.min_interval([[1, 4], [2, 4], [3, 6], [4, 4]], [2, 3, 4, 5]) == [3, 3, 1, 4]

    def test_example2(self):
        assert self.sol.min_interval([[2, 3], [2, 5], [1, 8], [20, 25]], [2, 19, 5, 22]) == [2, -1, 4, 6]

    def test_no_intervals(self):
        assert self.sol.min_interval([], [1, 2, 3]) == [-1, -1, -1]

    def test_single_interval(self):
        assert self.sol.min_interval([[1, 5]], [3, 6]) == [5, -1]

    def test_query_at_boundary(self):
        assert self.sol.min_interval([[1, 3], [5, 7]], [1, 3, 4, 5]) == [3, 3, -1, 3]

    def test_overlapping_intervals(self):
        assert self.sol.min_interval([[1, 10], [2, 3]], [2]) == [2]
