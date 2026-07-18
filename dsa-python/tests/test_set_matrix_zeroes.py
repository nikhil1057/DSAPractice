from solutions.math_and_geometry.medium.set_matrix_zeroes import SetMatrixZeroes


class TestSetMatrixZeroes:
    def setup_method(self):
        self.sol = SetMatrixZeroes()

    def test_example1(self):
        matrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[1, 0, 1], [0, 0, 0], [1, 0, 1]]

    def test_example2(self):
        matrix = [[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[0, 0, 0, 0], [0, 4, 5, 0], [0, 3, 1, 0]]

    def test_no_zeros(self):
        matrix = [[1, 2], [3, 4]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[1, 2], [3, 4]]

    def test_all_zeros(self):
        matrix = [[0, 0], [0, 0]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[0, 0], [0, 0]]

    def test_single_element_zero(self):
        matrix = [[0]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[0]]

    def test_corner_zero(self):
        matrix = [[0, 1], [1, 1]]
        self.sol.set_zeroes(matrix)
        assert matrix == [[0, 0], [0, 1]]
