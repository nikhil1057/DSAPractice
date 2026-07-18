from solutions.binary_search.medium.find_minimum_in_rotated_sorted_array import FindMinimumInRotatedSortedArray


class TestFindMinimumInRotatedSortedArray:
    def setup_method(self):
        self.sol = FindMinimumInRotatedSortedArray()

    def test_example1(self):
        # [3,4,5,1,2] → 1
        assert self.sol.find_min([3, 4, 5, 1, 2]) == 1

    def test_example2(self):
        # [4,5,6,7,0,1,2] → 0
        assert self.sol.find_min([4, 5, 6, 7, 0, 1, 2]) == 0

    def test_example3(self):
        # [11,13,15,17] → 11 (not rotated)
        assert self.sol.find_min([11, 13, 15, 17]) == 11

    def test_single_element(self):
        assert self.sol.find_min([1]) == 1

    def test_two_elements(self):
        assert self.sol.find_min([2, 1]) == 1

    def test_rotated_at_end(self):
        # [2,3,4,5,1] → 1
        assert self.sol.find_min([2, 3, 4, 5, 1]) == 1

    def test_rotated_at_start(self):
        # [1,2,3,4,5] → 1 (full rotation = no rotation)
        assert self.sol.find_min([1, 2, 3, 4, 5]) == 1

    def test_two_elements_not_rotated(self):
        assert self.sol.find_min([1, 2]) == 1
