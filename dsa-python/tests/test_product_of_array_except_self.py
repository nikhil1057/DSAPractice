from solutions.array_and_hashing.medium.product_of_array_except_self import ProductOfArrayExceptSelf


class TestProductOfArrayExceptSelf:
    def setup_method(self):
        self.sol = ProductOfArrayExceptSelf()

    def test_example1(self):
        # [1,2,3,4] => [24,12,8,6]
        assert self.sol.product_except_self([1, 2, 3, 4]) == [24, 12, 8, 6]

    def test_example2(self):
        # [-1,1,0,-3,3] => [0,0,9,0,0]
        assert self.sol.product_except_self([-1, 1, 0, -3, 3]) == [0, 0, 9, 0, 0]

    def test_two_elements(self):
        # [2,3] => [3,2]
        assert self.sol.product_except_self([2, 3]) == [3, 2]

    def test_contains_zero(self):
        # [0,1,2,3] => [6,0,0,0]
        assert self.sol.product_except_self([0, 1, 2, 3]) == [6, 0, 0, 0]

    def test_multiple_zeros(self):
        # [0,0,1] => [0,0,0]
        assert self.sol.product_except_self([0, 0, 1]) == [0, 0, 0]

    def test_all_ones(self):
        # [1,1,1,1] => [1,1,1,1]
        assert self.sol.product_except_self([1, 1, 1, 1]) == [1, 1, 1, 1]

    def test_negative_numbers(self):
        # [-1,-2,-3] => [6,-3,-2] (product of other two)
        assert self.sol.product_except_self([-1, -2, -3]) == [6, 3, 2]
