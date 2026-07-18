from solutions.graphs.medium.number_of_islands import NumberOfIslands


class TestNumberOfIslands:
    def setup_method(self):
        self.sol = NumberOfIslands()

    def test_example1(self):
        grid = [["1", "1", "1", "1", "0"], ["1", "1", "0", "1", "0"],
                ["1", "1", "0", "0", "0"], ["0", "0", "0", "0", "0"]]
        assert self.sol.num_islands(grid) == 1

    def test_example2(self):
        grid = [["1", "1", "0", "0", "0"], ["1", "1", "0", "0", "0"],
                ["0", "0", "1", "0", "0"], ["0", "0", "0", "1", "1"]]
        assert self.sol.num_islands(grid) == 3

    def test_all_water(self):
        grid = [["0", "0", "0"], ["0", "0", "0"]]
        assert self.sol.num_islands(grid) == 0

    def test_all_land(self):
        grid = [["1", "1"], ["1", "1"]]
        assert self.sol.num_islands(grid) == 1

    def test_single_cell_land(self):
        grid = [["1"]]
        assert self.sol.num_islands(grid) == 1

    def test_single_cell_water(self):
        grid = [["0"]]
        assert self.sol.num_islands(grid) == 0

    def test_diagonal_not_connected(self):
        grid = [["1", "0"], ["0", "1"]]
        assert self.sol.num_islands(grid) == 2

    def test_many_islands(self):
        grid = [["1", "0", "1", "0", "1"], ["0", "0", "0", "0", "0"], ["1", "0", "1", "0", "1"]]
        assert self.sol.num_islands(grid) == 6
