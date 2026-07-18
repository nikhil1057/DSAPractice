from solutions.binary_search.medium.search_a_2d_matrix import SearchA2DMatrix


class TestSearchA2DMatrix:
    def setup_method(self):
        self.sol = SearchA2DMatrix()

    def test_example1(self):
        matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]]
        assert self.sol.search_matrix(matrix, 3) is True

    def test_example2(self):
        matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]]
        assert self.sol.search_matrix(matrix, 13) is False

    def test_single_element_found(self):
        assert self.sol.search_matrix([[1]], 1) is True

    def test_single_element_not_found(self):
        assert self.sol.search_matrix([[1]], 2) is False

    def test_first_element(self):
        matrix = [[1, 3, 5], [7, 9, 11]]
        assert self.sol.search_matrix(matrix, 1) is True

    def test_last_element(self):
        matrix = [[1, 3, 5], [7, 9, 11]]
        assert self.sol.search_matrix(matrix, 11) is True

    def test_target_between_rows(self):
        matrix = [[1, 3, 5, 7], [10, 11, 16, 20]]
        assert self.sol.search_matrix(matrix, 8) is False

    def test_single_row(self):
        matrix = [[1, 3, 5, 7, 9]]
        assert self.sol.search_matrix(matrix, 5) is True
