from solutions.dp_1d.medium.word_break import WordBreak


class TestWordBreak:
    def setup_method(self):
        self.sol = WordBreak()

    def test_example1(self):
        assert self.sol.word_break("leetcode", ["leet", "code"]) is True

    def test_example2(self):
        assert self.sol.word_break("applepenapple", ["apple", "pen"]) is True

    def test_example3(self):
        assert self.sol.word_break("catsandog", ["cats", "dog", "sand", "and", "cat"]) is False

    def test_single_word(self):
        assert self.sol.word_break("a", ["a"]) is True

    def test_not_in_dict(self):
        assert self.sol.word_break("abc", ["a", "b"]) is False

    def test_reuse_words(self):
        assert self.sol.word_break("aaaa", ["a", "aa"]) is True

    def test_empty_string(self):
        assert self.sol.word_break("", ["a"]) is True

    def test_overlapping_words(self):
        assert self.sol.word_break("cars", ["car", "ca", "rs"]) is True
