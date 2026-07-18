from solutions.dp_2d.medium.target_sum import TargetSum


class TestTargetSum:
    def setup_method(self):
        self.sol = TargetSum()

    def test_example1(self):
        assert self.sol.find_target_sum_ways([1, 1, 1, 1, 1], 3) == 5

    def test_example2(self):
        assert self.sol.find_target_sum_ways([1], 1) == 1

    def test_single_element_negative(self):
        assert self.sol.find_target_sum_ways([1], -1) == 1

    def test_impossible_target(self):
        assert self.sol.find_target_sum_ways([1, 2], 4) == 0

    def test_zeros(self):
        # Each 0 can be + or -, so 2^(number of zeros) ways
        assert self.sol.find_target_sum_ways([0, 0, 1], 1) == 4

    def test_all_same(self):
        assert self.sol.find_target_sum_ways([2, 2, 2], 2) == 3

    def test_target_zero(self):
        assert self.sol.find_target_sum_ways([1, 1, 1, 1], 0) == 6
