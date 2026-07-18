from solutions.binary_search.easy.binary_search import BinarySearch


class TestBinarySearch:
    def setup_method(self):
        self.sol = BinarySearch()

    def test_example1(self):
        # nums=[-1,0,3,5,9,12], target=9 → 4
        assert self.sol.search([-1, 0, 3, 5, 9, 12], 9) == 4

    def test_example2(self):
        # nums=[-1,0,3,5,9,12], target=2 → -1
        assert self.sol.search([-1, 0, 3, 5, 9, 12], 2) == -1

    def test_single_element_found(self):
        assert self.sol.search([5], 5) == 0

    def test_single_element_not_found(self):
        assert self.sol.search([5], 3) == -1

    def test_first_element(self):
        assert self.sol.search([1, 2, 3, 4, 5], 1) == 0

    def test_last_element(self):
        assert self.sol.search([1, 2, 3, 4, 5], 5) == 4

    def test_two_elements(self):
        assert self.sol.search([1, 3], 3) == 1

    def test_negative_numbers(self):
        assert self.sol.search([-10, -5, -2, 0, 3], -5) == 1
