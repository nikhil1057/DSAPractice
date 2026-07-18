from solutions.intervals.medium.merge_intervals import MergeIntervals


class TestMergeIntervals:
    def setup_method(self):
        self.sol = MergeIntervals()

    def test_example1(self):
        assert self.sol.merge([[1, 3], [2, 6], [8, 10], [15, 18]]) == [[1, 6], [8, 10], [15, 18]]

    def test_example2(self):
        assert self.sol.merge([[1, 4], [4, 5]]) == [[1, 5]]

    def test_no_overlap(self):
        assert self.sol.merge([[1, 2], [4, 5], [7, 8]]) == [[1, 2], [4, 5], [7, 8]]

    def test_all_overlap(self):
        assert self.sol.merge([[1, 4], [2, 5], [3, 6]]) == [[1, 6]]

    def test_single_interval(self):
        assert self.sol.merge([[1, 5]]) == [[1, 5]]

    def test_nested_intervals(self):
        assert self.sol.merge([[1, 10], [2, 3], [4, 5]]) == [[1, 10]]

    def test_unsorted_input(self):
        assert self.sol.merge([[3, 4], [1, 2], [5, 6]]) == [[1, 2], [3, 4], [5, 6]]
