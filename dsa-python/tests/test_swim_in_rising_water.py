from solutions.advanced_graphs.hard.swim_in_rising_water import SwimInRisingWater


class TestSwimInRisingWater:
    def setup_method(self):
        self.sol = SwimInRisingWater()

    def test_example1(self):
        grid = [[0, 2], [1, 3]]
        assert self.sol.swim_in_water(grid) == 3

    def test_example2(self):
        grid = [
            [0, 1, 2, 3, 4],
            [24, 23, 22, 21, 5],
            [12, 13, 14, 15, 16],
            [11, 17, 18, 19, 20],
            [10, 9, 8, 7, 6],
        ]
        assert self.sol.swim_in_water(grid) == 16

    def test_single_cell(self):
        grid = [[0]]
        assert self.sol.swim_in_water(grid) == 0

    def test_2x2_simple(self):
        grid = [[0, 1], [2, 3]]
        assert self.sol.swim_in_water(grid) == 3

    def test_3x3(self):
        grid = [[0, 1, 2], [5, 4, 3], [6, 7, 8]]
        assert self.sol.swim_in_water(grid) == 8

    def test_already_connected(self):
        grid = [[0, 1], [1, 2]]
        assert self.sol.swim_in_water(grid) == 2
