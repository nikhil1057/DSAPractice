from solutions.dp_2d.hard.regular_expression_matching import RegularExpressionMatching


class TestRegularExpressionMatching:
    def setup_method(self):
        self.sol = RegularExpressionMatching()

    def test_example1(self):
        assert self.sol.is_match("aa", "a") is False

    def test_example2(self):
        assert self.sol.is_match("aa", "a*") is True

    def test_example3(self):
        assert self.sol.is_match("ab", ".*") is True

    def test_dot_match(self):
        assert self.sol.is_match("ab", "..") is True

    def test_star_zero_matches(self):
        assert self.sol.is_match("aab", "c*a*b") is True

    def test_complex_pattern(self):
        assert self.sol.is_match("mississippi", "mis*is*p*.") is False

    def test_empty_both(self):
        assert self.sol.is_match("", "") is True

    def test_empty_string_star_pattern(self):
        assert self.sol.is_match("", "a*") is True

    def test_full_dot_star(self):
        assert self.sol.is_match("anything", ".*") is True
