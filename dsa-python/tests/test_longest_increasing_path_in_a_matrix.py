from solutions.dp_2d.hard.longest_increasing_path_in_a_matrix import LongestIncreasingPathInAMatrix


class TestLongestIncreasingPathInAMatrix:
    def setup_method(self):
        self.sol = LongestIncreasingPathInAMatrix()

    def test_example1(self):
        matrix = [[9, 9, 4], [6, 6, 8], [2, 1, 1]]
        assert self.sol.longest_increasing_path(matrix) == 4

    def test_example2(self):
        matrix = [[3, 4, 5], [3, 2, 6], [2, 2, 1]]
        assert self.sol.longest_increasing_path(matrix) == 4

    def test_example3(self):
        matrix = [[1]]
        assert self.sol.longest_increasing_path(matrix) == 1

    def test_single_row(self):
        matrix = [[1, 2, 3, 4]]
        assert self.sol.longest_increasing_path(matrix) == 4

    def test_single_column(self):
        matrix = [[1], [2], [3]]
        assert self.sol.longest_increasing_path(matrix) == 3

    def test_all_same(self):
        matrix = [[5, 5], [5, 5]]
        assert self.sol.longest_increasing_path(matrix) == 1

    def test_decreasing_diagonal(self):
        matrix = [[9, 8, 7], [6, 5, 4], [3, 2, 1]]
        assert self.sol.longest_increasing_path(matrix) == 5
