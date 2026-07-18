from solutions.advanced_graphs.medium.min_cost_to_connect_all_points import MinCostToConnectAllPoints


class TestMinCostToConnectAllPoints:
    def setup_method(self):
        self.sol = MinCostToConnectAllPoints()

    def test_example1(self):
        points = [[0, 0], [2, 2], [3, 10], [5, 2], [7, 0]]
        assert self.sol.min_cost_connect_points(points) == 20

    def test_example2(self):
        points = [[3, 12], [-2, 5], [-4, 1]]
        assert self.sol.min_cost_connect_points(points) == 18

    def test_two_points(self):
        points = [[0, 0], [1, 1]]
        assert self.sol.min_cost_connect_points(points) == 2

    def test_single_point(self):
        points = [[0, 0]]
        assert self.sol.min_cost_connect_points(points) == 0

    def test_collinear_points(self):
        points = [[0, 0], [1, 0], [2, 0], [3, 0]]
        assert self.sol.min_cost_connect_points(points) == 3

    def test_same_point(self):
        points = [[0, 0], [0, 0]]
        assert self.sol.min_cost_connect_points(points) == 0

    def test_negative_coordinates(self):
        points = [[-1, -1], [1, 1], [-1, 1], [1, -1]]
        assert self.sol.min_cost_connect_points(points) == 8
