from solutions.math_and_geometry.easy.plus_one import PlusOne


class TestPlusOne:
    def setup_method(self):
        self.sol = PlusOne()

    def test_example1(self):
        assert self.sol.plus_one([1, 2, 3]) == [1, 2, 4]

    def test_example2(self):
        assert self.sol.plus_one([4, 3, 2, 1]) == [4, 3, 2, 2]

    def test_example3(self):
        assert self.sol.plus_one([9]) == [1, 0]

    def test_all_nines(self):
        assert self.sol.plus_one([9, 9, 9]) == [1, 0, 0, 0]

    def test_single_digit(self):
        assert self.sol.plus_one([0]) == [1]

    def test_trailing_nine(self):
        assert self.sol.plus_one([1, 9]) == [2, 0]

    def test_no_carry(self):
        assert self.sol.plus_one([5, 5, 5]) == [5, 5, 6]
