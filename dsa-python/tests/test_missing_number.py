from solutions.bit_manipulation.easy.missing_number import MissingNumber


class TestMissingNumber:
    def setup_method(self):
        self.sol = MissingNumber()

    def test_example1(self):
        assert self.sol.missing_number([3, 0, 1]) == 2

    def test_example2(self):
        assert self.sol.missing_number([0, 1]) == 2

    def test_example3(self):
        assert self.sol.missing_number([9, 6, 4, 2, 3, 5, 7, 0, 1]) == 8

    def test_missing_zero(self):
        assert self.sol.missing_number([1]) == 0

    def test_missing_n(self):
        assert self.sol.missing_number([0]) == 1

    def test_single_zero(self):
        assert self.sol.missing_number([0, 1, 2, 3, 5]) == 4

    def test_larger_array(self):
        assert self.sol.missing_number([0, 2, 3, 4, 5]) == 1
