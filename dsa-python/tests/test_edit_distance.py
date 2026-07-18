from solutions.dp_2d.hard.edit_distance import EditDistance


class TestEditDistance:
    def setup_method(self):
        self.sol = EditDistance()

    def test_example1(self):
        assert self.sol.min_distance("horse", "ros") == 3

    def test_example2(self):
        assert self.sol.min_distance("intention", "execution") == 5

    def test_empty_word1(self):
        assert self.sol.min_distance("", "abc") == 3

    def test_empty_word2(self):
        assert self.sol.min_distance("abc", "") == 3

    def test_both_empty(self):
        assert self.sol.min_distance("", "") == 0

    def test_same_strings(self):
        assert self.sol.min_distance("abc", "abc") == 0

    def test_single_char_different(self):
        assert self.sol.min_distance("a", "b") == 1

    def test_one_insertion(self):
        assert self.sol.min_distance("ab", "abc") == 1
