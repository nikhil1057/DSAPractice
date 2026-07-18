from solutions.dp_2d.medium.longest_common_subsequence import LongestCommonSubsequence


class TestLongestCommonSubsequence:
    def setup_method(self):
        self.sol = LongestCommonSubsequence()

    def test_example1(self):
        assert self.sol.longest_common_subsequence("abcde", "ace") == 3

    def test_example2(self):
        assert self.sol.longest_common_subsequence("abc", "abc") == 3

    def test_example3(self):
        assert self.sol.longest_common_subsequence("abc", "def") == 0

    def test_empty_string(self):
        assert self.sol.longest_common_subsequence("", "abc") == 0

    def test_single_char_match(self):
        assert self.sol.longest_common_subsequence("a", "a") == 1

    def test_single_char_no_match(self):
        assert self.sol.longest_common_subsequence("a", "b") == 0

    def test_subsequence_not_substring(self):
        assert self.sol.longest_common_subsequence("abcba", "abcbcba") == 5

    def test_longer_strings(self):
        assert self.sol.longest_common_subsequence("oxcpqrsvwf", "shmtulqrypy") == 2
