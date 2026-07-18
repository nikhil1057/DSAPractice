from solutions.backtracking.medium.palindrome_partitioning import PalindromePartitioning


class TestPalindromePartitioning:
    def setup_method(self):
        self.sol = PalindromePartitioning()

    def test_example1(self):
        result = self.sol.partition("aab")
        expected = [["a", "a", "b"], ["aa", "b"]]
        assert sorted(result) == sorted(expected)

    def test_example2(self):
        result = self.sol.partition("a")
        assert result == [["a"]]

    def test_all_same(self):
        result = self.sol.partition("aaa")
        expected = [["a", "a", "a"], ["a", "aa"], ["aa", "a"], ["aaa"]]
        assert sorted(result) == sorted(expected)

    def test_no_palindrome_partition(self):
        result = self.sol.partition("abc")
        expected = [["a", "b", "c"]]
        assert result == expected

    def test_two_chars_palindrome(self):
        result = self.sol.partition("bb")
        expected = [["b", "b"], ["bb"]]
        assert sorted(result) == sorted(expected)

    def test_longer_string(self):
        result = self.sol.partition("aba")
        expected = [["a", "b", "a"], ["aba"]]
        assert sorted(result) == sorted(expected)

    def test_single_char(self):
        result = self.sol.partition("x")
        assert result == [["x"]]
