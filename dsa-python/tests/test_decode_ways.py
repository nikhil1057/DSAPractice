from solutions.dp_1d.medium.decode_ways import DecodeWays


class TestDecodeWays:
    def setup_method(self):
        self.sol = DecodeWays()

    def test_example1(self):
        assert self.sol.num_decodings("12") == 2

    def test_example2(self):
        assert self.sol.num_decodings("226") == 3

    def test_example3(self):
        assert self.sol.num_decodings("06") == 0

    def test_single_digit(self):
        assert self.sol.num_decodings("1") == 1

    def test_leading_zero(self):
        assert self.sol.num_decodings("0") == 0

    def test_double_zeros(self):
        assert self.sol.num_decodings("100") == 0

    def test_all_ones(self):
        assert self.sol.num_decodings("111") == 3

    def test_twenty_six(self):
        assert self.sol.num_decodings("26") == 2

    def test_twenty_seven(self):
        assert self.sol.num_decodings("27") == 1
