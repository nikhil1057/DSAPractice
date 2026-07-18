from solutions.math_and_geometry.medium.multiply_strings import MultiplyStrings


class TestMultiplyStrings:
    def setup_method(self):
        self.sol = MultiplyStrings()

    def test_example1(self):
        assert self.sol.multiply("2", "3") == "6"

    def test_example2(self):
        assert self.sol.multiply("123", "456") == "56088"

    def test_multiply_by_zero(self):
        assert self.sol.multiply("0", "12345") == "0"

    def test_both_zeros(self):
        assert self.sol.multiply("0", "0") == "0"

    def test_single_digits(self):
        assert self.sol.multiply("9", "9") == "81"

    def test_large_numbers(self):
        assert self.sol.multiply("999", "999") == "998001"

    def test_one_by_number(self):
        assert self.sol.multiply("1", "456") == "456"
