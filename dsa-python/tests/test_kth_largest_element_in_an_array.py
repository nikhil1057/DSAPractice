from solutions.heap.medium.kth_largest_element_in_an_array import KthLargestElementInAnArray


class TestKthLargestElementInAnArray:
    def setup_method(self):
        self.sol = KthLargestElementInAnArray()

    def test_example1(self):
        assert self.sol.find_kth_largest([3, 2, 1, 5, 6, 4], 2) == 5

    def test_example2(self):
        assert self.sol.find_kth_largest([3, 2, 3, 1, 2, 4, 5, 5, 6], 4) == 4

    def test_single_element(self):
        assert self.sol.find_kth_largest([1], 1) == 1

    def test_k_equals_n(self):
        assert self.sol.find_kth_largest([3, 2, 1], 3) == 1

    def test_duplicates(self):
        assert self.sol.find_kth_largest([2, 2, 2, 2], 2) == 2

    def test_negative_numbers(self):
        assert self.sol.find_kth_largest([-1, -2, -3, -4], 2) == -2

    def test_mixed_numbers(self):
        assert self.sol.find_kth_largest([-1, 0, 1, 2, 3], 1) == 3
