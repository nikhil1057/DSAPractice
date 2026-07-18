from solutions.binary_search.hard.median_of_two_sorted_arrays import MedianOfTwoSortedArrays


class TestMedianOfTwoSortedArrays:
    def setup_method(self):
        self.sol = MedianOfTwoSortedArrays()

    def test_example1(self):
        # nums1=[1,3], nums2=[2] → 2.0
        assert self.sol.find_median_sorted_arrays([1, 3], [2]) == 2.0

    def test_example2(self):
        # nums1=[1,2], nums2=[3,4] → 2.5
        assert self.sol.find_median_sorted_arrays([1, 2], [3, 4]) == 2.5

    def test_one_empty(self):
        assert self.sol.find_median_sorted_arrays([], [1]) == 1.0

    def test_other_empty(self):
        assert self.sol.find_median_sorted_arrays([2], []) == 2.0

    def test_same_elements(self):
        assert self.sol.find_median_sorted_arrays([1, 1], [1, 1]) == 1.0

    def test_non_overlapping(self):
        # [1,2] and [3,4,5] → merged [1,2,3,4,5] → median = 3.0
        assert self.sol.find_median_sorted_arrays([1, 2], [3, 4, 5]) == 3.0

    def test_single_elements(self):
        assert self.sol.find_median_sorted_arrays([1], [2]) == 1.5

    def test_different_sizes(self):
        # [1,2,3,4,5] and [6,7,8] → merged has 8 elements → median = (4+5)/2 = 4.5
        assert self.sol.find_median_sorted_arrays([1, 2, 3, 4, 5], [6, 7, 8]) == 4.5
