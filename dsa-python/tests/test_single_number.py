from solutions.bit_manipulation.easy.single_number import SingleNumber


class TestSingleNumber:
    def setup_method(self):
        self.sol = SingleNumber()

    def test_example1(self):
        assert self.sol.single_number([2, 2, 1]) == 1

    def test_example2(self):
        assert self.sol.single_number([4, 1, 2, 1, 2]) == 4

    def test_example3(self):
        assert self.sol.single_number([1]) == 1

    def test_negative_numbers(self):
        assert self.sol.single_number([-1, -1, -2]) == -2

    def test_zero(self):
        assert self.sol.single_number([0, 1, 1]) == 0

    def test_large_array(self):
        assert self.sol.single_number([3, 3, 7, 7, 10]) == 10
