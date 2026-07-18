from solutions.sliding_window.medium.permutation_in_string import PermutationInString


class TestPermutationInString:
    def setup_method(self):
        self.sol = PermutationInString()

    def test_example1(self):
        # s1="ab", s2="eidbaooo" => true
        assert self.sol.check_inclusion("ab", "eidbaooo") is True

    def test_example2(self):
        # s1="ab", s2="eidboaoo" => false
        assert self.sol.check_inclusion("ab", "eidboaoo") is False

    def test_s1_longer_than_s2(self):
        assert self.sol.check_inclusion("abc", "ab") is False

    def test_exact_match(self):
        assert self.sol.check_inclusion("abc", "abc") is True

    def test_single_char_found(self):
        assert self.sol.check_inclusion("a", "ab") is True

    def test_single_char_not_found(self):
        assert self.sol.check_inclusion("a", "bc") is False

    def test_permutation_at_end(self):
        assert self.sol.check_inclusion("ab", "xxxba") is True

    def test_repeated_chars(self):
        assert self.sol.check_inclusion("aab", "ccccaab") is True
