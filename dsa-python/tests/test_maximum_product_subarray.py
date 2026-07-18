from solutions.dp_1d.medium.maximum_product_subarray import MaximumProductSubarray


class TestMaximumProductSubarray:
    def setup_method(self):
        self.sol = MaximumProductSubarray()

    def test_example1(self):
        assert self.sol.max_product([2, 3, -2, 4]) == 6

    def test_example2(self):
        assert self.sol.max_product([-2, 0, -1]) == 0

    def test_single_element(self):
        assert self.sol.max_product([3]) == 3

    def test_single_negative(self):
        assert self.sol.max_product([-2]) == -2

    def test_two_negatives(self):
        assert self.sol.max_product([-2, -3]) == 6

    def test_all_positive(self):
        assert self.sol.max_product([1, 2, 3, 4]) == 24

    def test_zeros_in_between(self):
        assert self.sol.max_product([2, 3, 0, 4, 5]) == 20

    def test_negative_sandwich(self):
        assert self.sol.max_product([-2, 3, -4]) == 24
