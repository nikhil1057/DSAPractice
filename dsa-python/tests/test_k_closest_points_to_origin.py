from solutions.heap.medium.k_closest_points_to_origin import KClosestPointsToOrigin


class TestKClosestPointsToOrigin:
    def setup_method(self):
        self.sol = KClosestPointsToOrigin()

    def test_example1(self):
        result = self.sol.k_closest([[1, 3], [-2, 2]], 1)
        assert sorted(result) == [[-2, 2]]

    def test_example2(self):
        result = self.sol.k_closest([[3, 3], [5, -1], [-2, 4]], 2)
        assert sorted(result) == sorted([[3, 3], [-2, 4]])

    def test_single_point(self):
        result = self.sol.k_closest([[1, 1]], 1)
        assert result == [[1, 1]]

    def test_k_equals_n(self):
        points = [[1, 2], [3, 4], [0, 1]]
        result = self.sol.k_closest(points, 3)
        assert sorted(result) == sorted(points)

    def test_origin_point(self):
        result = self.sol.k_closest([[0, 0], [1, 1], [2, 2]], 1)
        assert result == [[0, 0]]

    def test_negative_coords(self):
        result = self.sol.k_closest([[-1, -1], [-2, -2], [1, 1]], 2)
        assert sorted(result) == sorted([[-1, -1], [1, 1]])

    def test_same_distance(self):
        result = self.sol.k_closest([[1, 0], [0, 1], [-1, 0], [0, -1]], 2)
        assert len(result) == 2
