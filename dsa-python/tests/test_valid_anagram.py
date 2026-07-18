from solutions.array_and_hashing.easy.valid_anagram import ValidAnagram


class TestValidAnagram:
    def setup_method(self):
        self.sol = ValidAnagram()

    def test_example1(self):
        # "anagram", "nagaram" => true
        assert self.sol.is_anagram("anagram", "nagaram") is True

    def test_example2(self):
        # "rat", "car" => false
        assert self.sol.is_anagram("rat", "car") is False

    def test_empty_strings(self):
        assert self.sol.is_anagram("", "") is True

    def test_single_char_same(self):
        assert self.sol.is_anagram("a", "a") is True

    def test_single_char_different(self):
        assert self.sol.is_anagram("a", "b") is False

    def test_different_lengths(self):
        assert self.sol.is_anagram("ab", "abc") is False

    def test_same_chars_different_counts(self):
        assert self.sol.is_anagram("aab", "abb") is False

    def test_longer_anagram(self):
        assert self.sol.is_anagram("listen", "silent") is True
