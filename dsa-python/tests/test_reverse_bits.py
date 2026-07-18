from solutions.bit_manipulation.easy.reverse_bits import ReverseBits


class TestReverseBits:
    def setup_method(self):
        self.sol = ReverseBits()

    def test_example1(self):
        # 00000010100101000001111010011100 => 00111001011110000010100101000000
        assert self.sol.reverse_bits(43261596) == 964176192

    def test_example2(self):
        # 11111111111111111111111111111101 => 10111111111111111111111111111111
        assert self.sol.reverse_bits(4294967293) == 3221225471

    def test_zero(self):
        assert self.sol.reverse_bits(0) == 0

    def test_one(self):
        # 00000000000000000000000000000001 => 10000000000000000000000000000000
        assert self.sol.reverse_bits(1) == 2147483648

    def test_all_ones(self):
        assert self.sol.reverse_bits(4294967295) == 4294967295

    def test_power_of_two(self):
        # 00000000000000000000000000000100 => 00100000000000000000000000000000
        assert self.sol.reverse_bits(4) == 536870912
