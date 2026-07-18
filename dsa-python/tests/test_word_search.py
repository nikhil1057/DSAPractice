from solutions.backtracking.medium.word_search import WordSearch


class TestWordSearch:
    def setup_method(self):
        self.sol = WordSearch()

    def test_example1(self):
        board = [["A", "B", "C", "E"], ["S", "F", "C", "S"], ["A", "D", "E", "E"]]
        assert self.sol.exist(board, "ABCCED") is True

    def test_example2(self):
        board = [["A", "B", "C", "E"], ["S", "F", "C", "S"], ["A", "D", "E", "E"]]
        assert self.sol.exist(board, "SEE") is True

    def test_example3(self):
        board = [["A", "B", "C", "E"], ["S", "F", "C", "S"], ["A", "D", "E", "E"]]
        assert self.sol.exist(board, "ABCB") is False

    def test_single_cell_found(self):
        board = [["A"]]
        assert self.sol.exist(board, "A") is True

    def test_single_cell_not_found(self):
        board = [["A"]]
        assert self.sol.exist(board, "B") is False

    def test_word_longer_than_grid(self):
        board = [["A", "B"], ["C", "D"]]
        assert self.sol.exist(board, "ABCDA") is False

    def test_snake_path(self):
        board = [["A", "B", "C"], ["D", "E", "F"], ["G", "H", "I"]]
        assert self.sol.exist(board, "ABCFED") is True

    def test_no_reuse(self):
        board = [["A", "A"]]
        assert self.sol.exist(board, "AAA") is False
