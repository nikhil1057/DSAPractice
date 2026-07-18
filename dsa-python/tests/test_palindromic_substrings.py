from solutions.dp_1d.medium.palindromic_substrings import PalindromicSubstrings


class TestPalindromicSubstrings:
    def setup_method(self):
        self.sol = PalindromicSubstrings()

    def test_example1(self):
        assert self.sol.count_substrings("abc") == 3

    def test_example2(self):
        assert self.sol.count_substrings("aaa") == 6

    def test_single_char(self):
        assert self.sol.count_substrings("a") == 1

    def test_two_same_chars(self):
        assert self.sol.count_substrings("aa") == 3

    def test_two_diff_chars(self):
        assert self.sol.count_substrings("ab") == 2

    def test_palindrome_string(self):
        assert self.sol.count_substrings("aba") == 4

    def test_longer_string(self):
        # "abcba": a,b,c,b,a,bcb,abcba => 7
        assert self.sol.count_substrings("abcba") == 7
