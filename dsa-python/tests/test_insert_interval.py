from solutions.intervals.medium.insert_interval import InsertInterval


class TestInsertInterval:
    def setup_method(self):
        self.sol = InsertInterval()

    def test_example1(self):
        assert self.sol.insert([[1, 3], [6, 9]], [2, 5]) == [[1, 5], [6, 9]]

    def test_example2(self):
        assert self.sol.insert([[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]], [4, 8]) == [[1, 2], [3, 10], [12, 16]]

    def test_empty_intervals(self):
        assert self.sol.insert([], [5, 7]) == [[5, 7]]

    def test_no_overlap_before(self):
        assert self.sol.insert([[3, 5], [6, 9]], [1, 2]) == [[1, 2], [3, 5], [6, 9]]

    def test_no_overlap_after(self):
        assert self.sol.insert([[1, 2], [3, 5]], [6, 8]) == [[1, 2], [3, 5], [6, 8]]

    def test_merge_all(self):
        assert self.sol.insert([[1, 3], [4, 6], [7, 9]], [2, 8]) == [[1, 9]]

    def test_exact_overlap(self):
        assert self.sol.insert([[1, 5]], [1, 5]) == [[1, 5]]
