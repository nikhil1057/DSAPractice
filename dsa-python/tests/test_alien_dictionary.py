from solutions.advanced_graphs.hard.alien_dictionary import AlienDictionary


class TestAlienDictionary:
    def setup_method(self):
        self.sol = AlienDictionary()

    def test_example1(self):
        words = ["wrt", "wrf", "er", "ett", "rftt"]
        result = self.sol.alien_order(words)
        # Valid order: "wertf"
        assert result == "wertf"

    def test_example2(self):
        words = ["z", "x"]
        result = self.sol.alien_order(words)
        assert result == "zx"

    def test_example3_invalid(self):
        # "abc" before "ab" is invalid (prefix rule)
        words = ["abc", "ab"]
        result = self.sol.alien_order(words)
        assert result == ""

    def test_single_word(self):
        words = ["abc"]
        result = self.sol.alien_order(words)
        # All characters should appear, order among them is flexible
        assert set(result) == {"a", "b", "c"}

    def test_single_character_words(self):
        words = ["z", "x", "z"]
        result = self.sol.alien_order(words)
        # z < x and x < z is a cycle => invalid
        assert result == ""

    def test_two_words_same(self):
        words = ["a", "a"]
        result = self.sol.alien_order(words)
        assert result == "a"

    def test_all_same_letter(self):
        words = ["a", "aa", "aaa"]
        result = self.sol.alien_order(words)
        assert result == "a"
