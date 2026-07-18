from solutions.bit_manipulation.easy.number_of_1_bits import NumberOf1Bits


class TestNumberOf1Bits:
    def setup_method(self):
        self.sol = NumberOf1Bits()

    def test_example1(self):
        assert self.sol.hamming_weight(11) == 3  # 1011

    def test_example2(self):
        assert self.sol.hamming_weight(128) == 1  # 10000000

    def test_example3(self):
        assert self.sol.hamming_weight(2147483645) == 30

    def test_zero(self):
        assert self.sol.hamming_weight(0) == 0

    def test_one(self):
        assert self.sol.hamming_weight(1) == 1

    def test_all_ones_byte(self):
        assert self.sol.hamming_weight(255) == 8

    def test_power_of_two(self):
        assert self.sol.hamming_weight(16) == 1
