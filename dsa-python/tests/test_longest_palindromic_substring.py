from solutions.dp_1d.medium.longest_palindromic_substring import LongestPalindromicSubstring


class TestLongestPalindromicSubstring:
    def setup_method(self):
        self.sol = LongestPalindromicSubstring()

    def test_example1(self):
        result = self.sol.longest_palindrome("babad")
        assert result in ["bab", "aba"]

    def test_example2(self):
        assert self.sol.longest_palindrome("cbbd") == "bb"

    def test_single_char(self):
        assert self.sol.longest_palindrome("a") == "a"

    def test_all_same(self):
        assert self.sol.longest_palindrome("aaaa") == "aaaa"

    def test_no_palindrome_longer_than_1(self):
        result = self.sol.longest_palindrome("abcd")
        assert len(result) == 1

    def test_entire_string(self):
        assert self.sol.longest_palindrome("racecar") == "racecar"

    def test_even_length_palindrome(self):
        assert self.sol.longest_palindrome("aabbaa") == "aabbaa"
