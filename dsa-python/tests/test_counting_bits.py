from solutions.bit_manipulation.easy.counting_bits import CountingBits


class TestCountingBits:
    def setup_method(self):
        self.sol = CountingBits()

    def test_example1(self):
        assert self.sol.count_bits(2) == [0, 1, 1]

    def test_example2(self):
        assert self.sol.count_bits(5) == [0, 1, 1, 2, 1, 2]

    def test_zero(self):
        assert self.sol.count_bits(0) == [0]

    def test_one(self):
        assert self.sol.count_bits(1) == [0, 1]

    def test_eight(self):
        assert self.sol.count_bits(8) == [0, 1, 1, 2, 1, 2, 2, 3, 1]

    def test_three(self):
        assert self.sol.count_bits(3) == [0, 1, 1, 2]
