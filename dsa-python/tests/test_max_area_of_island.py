from solutions.graphs.medium.max_area_of_island import MaxAreaOfIsland


class TestMaxAreaOfIsland:
    def setup_method(self):
        self.sol = MaxAreaOfIsland()

    def test_example1(self):
        grid = [[0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
                [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0],
                [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0],
                [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]]
        assert self.sol.max_area_of_island(grid) == 6

    def test_example2(self):
        grid = [[0, 0, 0, 0, 0, 0, 0, 0]]
        assert self.sol.max_area_of_island(grid) == 0

    def test_single_cell_island(self):
        grid = [[0, 1, 0], [0, 0, 0]]
        assert self.sol.max_area_of_island(grid) == 1

    def test_entire_grid_island(self):
        grid = [[1, 1], [1, 1]]
        assert self.sol.max_area_of_island(grid) == 4

    def test_no_islands(self):
        grid = [[0, 0], [0, 0]]
        assert self.sol.max_area_of_island(grid) == 0

    def test_l_shaped_island(self):
        grid = [[1, 0], [1, 0], [1, 1]]
        assert self.sol.max_area_of_island(grid) == 4

    def test_multiple_islands(self):
        grid = [[1, 1, 0, 0], [1, 1, 0, 0], [0, 0, 1, 1], [0, 0, 1, 1]]
        assert self.sol.max_area_of_island(grid) == 4
