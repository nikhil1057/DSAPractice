from solutions.dp_2d.medium.interleaving_string import InterleavingString


class TestInterleavingString:
    def setup_method(self):
        self.sol = InterleavingString()

    def test_example1(self):
        assert self.sol.is_interleave("aabcc", "dbbca", "aadbbcbcac") is True

    def test_example2(self):
        assert self.sol.is_interleave("aabcc", "dbbca", "aadbbbaccc") is False

    def test_example3(self):
        assert self.sol.is_interleave("", "", "") is True

    def test_one_empty(self):
        assert self.sol.is_interleave("", "abc", "abc") is True

    def test_length_mismatch(self):
        assert self.sol.is_interleave("a", "b", "abc") is False

    def test_single_chars(self):
        assert self.sol.is_interleave("a", "b", "ab") is True

    def test_single_chars_reversed(self):
        assert self.sol.is_interleave("a", "b", "ba") is True

    def test_repeated_chars(self):
        assert self.sol.is_interleave("aaa", "aaa", "aaaaaa") is True
