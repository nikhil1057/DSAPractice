from solutions.sliding_window.hard.minimum_window_substring import MinimumWindowSubstring


class TestMinimumWindowSubstring:
    def setup_method(self):
        self.sol = MinimumWindowSubstring()

    def test_example1(self):
        # s="ADOBECODEBANC", t="ABC" => "BANC"
        assert self.sol.min_window("ADOBECODEBANC", "ABC") == "BANC"

    def test_example2(self):
        # s="a", t="a" => "a"
        assert self.sol.min_window("a", "a") == "a"

    def test_example3(self):
        # s="a", t="aa" => "" (not enough chars)
        assert self.sol.min_window("a", "aa") == ""

    def test_no_valid_window(self):
        assert self.sol.min_window("abc", "xyz") == ""

    def test_t_equals_s(self):
        assert self.sol.min_window("abc", "abc") == "abc"

    def test_duplicate_chars_in_t(self):
        # s="aaab", t="aa" => "aa"
        assert self.sol.min_window("aaab", "aa") == "aa"

    def test_single_char_repeated(self):
        # s="bbbb", t="b" => "b"
        assert self.sol.min_window("bbbb", "b") == "b"

    def test_empty_t(self):
        assert self.sol.min_window("abc", "") == ""
