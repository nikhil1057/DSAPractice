from solutions.math_and_geometry.medium.spiral_matrix import SpiralMatrix


class TestSpiralMatrix:
    def setup_method(self):
        self.sol = SpiralMatrix()

    def test_example1(self):
        assert self.sol.spiral_order([[1, 2, 3], [4, 5, 6], [7, 8, 9]]) == [1, 2, 3, 6, 9, 8, 7, 4, 5]

    def test_example2(self):
        assert self.sol.spiral_order([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]) == [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7]

    def test_single_element(self):
        assert self.sol.spiral_order([[1]]) == [1]

    def test_single_row(self):
        assert self.sol.spiral_order([[1, 2, 3, 4]]) == [1, 2, 3, 4]

    def test_single_column(self):
        assert self.sol.spiral_order([[1], [2], [3]]) == [1, 2, 3]

    def test_2x2(self):
        assert self.sol.spiral_order([[1, 2], [3, 4]]) == [1, 2, 4, 3]
