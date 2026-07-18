from solutions.graphs.medium.pacific_atlantic_water_flow import PacificAtlanticWaterFlow


class TestPacificAtlanticWaterFlow:
    def setup_method(self):
        self.sol = PacificAtlanticWaterFlow()

    def test_example1(self):
        heights = [[1, 2, 2, 3, 5], [3, 2, 3, 4, 4], [2, 4, 5, 3, 1], [6, 7, 1, 4, 5], [5, 1, 1, 2, 4]]
        result = self.sol.pacific_atlantic(heights)
        expected = [[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]]
        assert sorted(result) == sorted(expected)

    def test_example2(self):
        heights = [[1]]
        result = self.sol.pacific_atlantic(heights)
        assert result == [[0, 0]]

    def test_flat_grid(self):
        heights = [[1, 1], [1, 1]]
        result = self.sol.pacific_atlantic(heights)
        expected = [[0, 0], [0, 1], [1, 0], [1, 1]]
        assert sorted(result) == sorted(expected)

    def test_increasing_grid(self):
        heights = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
        result = self.sol.pacific_atlantic(heights)
        # Bottom-right corner can reach both
        assert [2, 2] in result

    def test_single_row(self):
        heights = [[1, 2, 3]]
        result = self.sol.pacific_atlantic(heights)
        expected = [[0, 0], [0, 1], [0, 2]]
        assert sorted(result) == sorted(expected)

    def test_single_column(self):
        heights = [[1], [2], [3]]
        result = self.sol.pacific_atlantic(heights)
        expected = [[0, 0], [1, 0], [2, 0]]
        assert sorted(result) == sorted(expected)
