from solutions.math_and_geometry.easy.happy_number import HappyNumber


class TestHappyNumber:
    def setup_method(self):
        self.sol = HappyNumber()

    def test_example1(self):
        assert self.sol.is_happy(19) is True

    def test_example2(self):
        assert self.sol.is_happy(2) is False

    def test_one(self):
        assert self.sol.is_happy(1) is True

    def test_seven(self):
        assert self.sol.is_happy(7) is True

    def test_four(self):
        assert self.sol.is_happy(4) is False

    def test_large_happy(self):
        assert self.sol.is_happy(100) is True

    def test_not_happy(self):
        assert self.sol.is_happy(20) is False
