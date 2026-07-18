from solutions.intervals.medium.non_overlapping_intervals import NonOverlappingIntervals


class TestNonOverlappingIntervals:
    def setup_method(self):
        self.sol = NonOverlappingIntervals()

    def test_example1(self):
        assert self.sol.erase_overlap_intervals([[1, 2], [2, 3], [3, 4], [1, 3]]) == 1

    def test_example2(self):
        assert self.sol.erase_overlap_intervals([[1, 2], [1, 2], [1, 2]]) == 2

    def test_example3(self):
        assert self.sol.erase_overlap_intervals([[1, 2], [2, 3]]) == 0

    def test_no_intervals(self):
        assert self.sol.erase_overlap_intervals([]) == 0

    def test_single_interval(self):
        assert self.sol.erase_overlap_intervals([[1, 5]]) == 0

    def test_all_overlap(self):
        assert self.sol.erase_overlap_intervals([[1, 4], [2, 5], [3, 6]]) == 2

    def test_nested(self):
        assert self.sol.erase_overlap_intervals([[1, 10], [2, 3], [4, 5]]) == 1
