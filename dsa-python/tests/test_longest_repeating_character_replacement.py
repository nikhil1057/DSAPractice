from solutions.sliding_window.medium.longest_repeating_character_replacement import LongestRepeatingCharacterReplacement


class TestLongestRepeatingCharacterReplacement:
    def setup_method(self):
        self.sol = LongestRepeatingCharacterReplacement()

    def test_example1(self):
        # "ABAB", k=2 => 4
        assert self.sol.character_replacement("ABAB", 2) == 4

    def test_example2(self):
        # "AABABBA", k=1 => 4
        assert self.sol.character_replacement("AABABBA", 1) == 4

    def test_all_same(self):
        # "AAAA", k=0 => 4
        assert self.sol.character_replacement("AAAA", 0) == 4

    def test_k_zero_alternating(self):
        # "ABAB", k=0 => 1
        assert self.sol.character_replacement("ABAB", 0) == 1

    def test_single_char(self):
        # "A", k=0 => 1
        assert self.sol.character_replacement("A", 0) == 1

    def test_k_larger_than_needed(self):
        # "ABCD", k=10 => 4
        assert self.sol.character_replacement("ABCD", 10) == 4

    def test_empty_string(self):
        assert self.sol.character_replacement("", 2) == 0
