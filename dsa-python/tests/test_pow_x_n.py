from solutions.math_and_geometry.medium.pow_x_n import PowXN
import math


class TestPowXN:
    def setup_method(self):
        self.sol = PowXN()

    def test_example1(self):
        assert math.isclose(self.sol.my_pow(2.0, 10), 1024.0)

    def test_example2(self):
        assert math.isclose(self.sol.my_pow(2.1, 3), 9.261, rel_tol=1e-5)

    def test_example3(self):
        assert math.isclose(self.sol.my_pow(2.0, -2), 0.25)

    def test_zero_exponent(self):
        assert math.isclose(self.sol.my_pow(5.0, 0), 1.0)

    def test_one_exponent(self):
        assert math.isclose(self.sol.my_pow(3.0, 1), 3.0)

    def test_negative_base(self):
        assert math.isclose(self.sol.my_pow(-2.0, 3), -8.0)

    def test_zero_base(self):
        assert math.isclose(self.sol.my_pow(0.0, 5), 0.0)

    def test_large_negative_exponent(self):
        assert math.isclose(self.sol.my_pow(2.0, -3), 0.125)
