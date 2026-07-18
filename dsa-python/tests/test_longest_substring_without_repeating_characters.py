from solutions.sliding_window.medium.longest_substring_without_repeating_characters import LongestSubstringWithoutRepeatingCharacters


class TestLongestSubstringWithoutRepeatingCharacters:
    def setup_method(self):
        self.sol = LongestSubstringWithoutRepeatingCharacters()

    def test_example1(self):
        # "abcabcbb" => 3
        assert self.sol.length_of_longest_substring("abcabcbb") == 3

    def test_example2(self):
        # "bbbbb" => 1
        assert self.sol.length_of_longest_substring("bbbbb") == 1

    def test_example3(self):
        # "pwwkew" => 3
        assert self.sol.length_of_longest_substring("pwwkew") == 3

    def test_empty_string(self):
        assert self.sol.length_of_longest_substring("") == 0

    def test_single_char(self):
        assert self.sol.length_of_longest_substring("a") == 1

    def test_all_unique(self):
        assert self.sol.length_of_longest_substring("abcdef") == 6

    def test_spaces_and_special(self):
        assert self.sol.length_of_longest_substring("a b c") == 3

    def test_two_chars(self):
        assert self.sol.length_of_longest_substring("au") == 2
