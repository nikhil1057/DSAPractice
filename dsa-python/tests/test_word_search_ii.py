from solutions.tries.hard.word_search_ii import WordSearchII


class TestWordSearchII:
    def setup_method(self):
        self.sol = WordSearchII()

    def test_example1(self):
        board = [["o", "a", "a", "n"], ["e", "t", "a", "e"], ["i", "h", "k", "r"], ["i", "f", "l", "v"]]
        words = ["oath", "pea", "eat", "rain"]
        result = self.sol.find_words(board, words)
        assert sorted(result) == sorted(["eat", "oath"])

    def test_example2(self):
        board = [["a", "b"], ["c", "d"]]
        words = ["abcb"]
        result = self.sol.find_words(board, words)
        assert result == []

    def test_single_cell(self):
        board = [["a"]]
        words = ["a"]
        result = self.sol.find_words(board, words)
        assert result == ["a"]

    def test_single_cell_not_found(self):
        board = [["a"]]
        words = ["b"]
        result = self.sol.find_words(board, words)
        assert result == []

    def test_all_words_found(self):
        board = [["a", "b"], ["c", "d"]]
        words = ["ab", "cd", "ac"]
        result = self.sol.find_words(board, words)
        assert sorted(result) == sorted(["ab", "cd", "ac"])

    def test_no_duplicates_in_result(self):
        board = [["a", "a"]]
        words = ["a"]
        result = self.sol.find_words(board, words)
        assert result == ["a"]

    def test_longer_word(self):
        board = [["a", "b", "c"], ["d", "e", "f"], ["g", "h", "i"]]
        words = ["abcfed", "xyz"]
        result = self.sol.find_words(board, words)
        assert result == ["abcfed"]
