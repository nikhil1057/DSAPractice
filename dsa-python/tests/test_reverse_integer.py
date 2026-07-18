from solutions.bit_manipulation.medium.reverse_integer import ReverseInteger


class TestReverseInteger:
    def setup_method(self):
        self.sol = ReverseInteger()

    def test_example1(self):
        assert self.sol.reverse(123) == 321

    def test_example2(self):
        assert self.sol.reverse(-123) == -321

    def test_example3(self):
        assert self.sol.reverse(120) == 21

    def test_zero(self):
        assert self.sol.reverse(0) == 0

    def test_single_digit(self):
        assert self.sol.reverse(5) == 5

    def test_overflow_positive(self):
        assert self.sol.reverse(1534236469) == 0

    def test_overflow_negative(self):
        assert self.sol.reverse(-2147483648) == 0

    def test_trailing_zeros(self):
        assert self.sol.reverse(1000) == 1
