from solutions.graphs.medium.rotting_oranges import RottingOranges


class TestRottingOranges:
    def setup_method(self):
        self.sol = RottingOranges()

    def test_example1(self):
        grid = [[2, 1, 1], [1, 1, 0], [0, 1, 1]]
        assert self.sol.oranges_rotting(grid) == 4

    def test_example2(self):
        grid = [[2, 1, 1], [0, 1, 1], [1, 0, 1]]
        assert self.sol.oranges_rotting(grid) == -1

    def test_example3(self):
        grid = [[0, 2]]
        assert self.sol.oranges_rotting(grid) == 0

    def test_all_rotten(self):
        grid = [[2, 2], [2, 2]]
        assert self.sol.oranges_rotting(grid) == 0

    def test_no_oranges(self):
        grid = [[0, 0], [0, 0]]
        assert self.sol.oranges_rotting(grid) == 0

    def test_single_fresh(self):
        grid = [[1]]
        assert self.sol.oranges_rotting(grid) == -1

    def test_adjacent_rotten(self):
        grid = [[2, 1]]
        assert self.sol.oranges_rotting(grid) == 1

    def test_multiple_rotten_sources(self):
        grid = [[2, 1, 1, 1, 2]]
        assert self.sol.oranges_rotting(grid) == 1
