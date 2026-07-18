from solutions.binary_search.medium.search_in_rotated_sorted_array import SearchInRotatedSortedArray


class TestSearchInRotatedSortedArray:
    def setup_method(self):
        self.sol = SearchInRotatedSortedArray()

    def test_example1(self):
        # nums=[4,5,6,7,0,1,2], target=0 → 4
        assert self.sol.search([4, 5, 6, 7, 0, 1, 2], 0) == 4

    def test_example2(self):
        # nums=[4,5,6,7,0,1,2], target=3 → -1
        assert self.sol.search([4, 5, 6, 7, 0, 1, 2], 3) == -1

    def test_example3(self):
        # nums=[1], target=0 → -1
        assert self.sol.search([1], 0) == -1

    def test_single_element_found(self):
        assert self.sol.search([1], 1) == 0

    def test_not_rotated(self):
        assert self.sol.search([1, 2, 3, 4, 5], 3) == 2

    def test_target_at_pivot(self):
        # [6,7,1,2,3,4,5], target=1 → 2
        assert self.sol.search([6, 7, 1, 2, 3, 4, 5], 1) == 2

    def test_target_in_left_half(self):
        # [4,5,6,7,0,1,2], target=5 → 1
        assert self.sol.search([4, 5, 6, 7, 0, 1, 2], 5) == 1

    def test_two_elements(self):
        assert self.sol.search([3, 1], 1) == 1
