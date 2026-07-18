from solutions.bit_manipulation.medium.sum_of_two_integers import SumOfTwoIntegers


class TestSumOfTwoIntegers:
    def setup_method(self):
        self.sol = SumOfTwoIntegers()

    def test_example1(self):
        assert self.sol.get_sum(1, 2) == 3

    def test_example2(self):
        assert self.sol.get_sum(2, 3) == 5

    def test_negative_numbers(self):
        assert self.sol.get_sum(-1, -1) == -2

    def test_positive_and_negative(self):
        assert self.sol.get_sum(5, -3) == 2

    def test_zero(self):
        assert self.sol.get_sum(0, 0) == 0

    def test_negative_result(self):
        assert self.sol.get_sum(-5, 3) == -2

    def test_large_positive(self):
        assert self.sol.get_sum(100, 200) == 300
