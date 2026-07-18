from solutions.backtracking.hard.n_queens import NQueens


class TestNQueens:
    def setup_method(self):
        self.sol = NQueens()

    def test_example1(self):
        result = self.sol.solve_n_queens(4)
        expected = [[".Q..", "...Q", "Q...", "..Q."], ["..Q.", "Q...", "...Q", ".Q.."]]
        assert sorted([tuple(r) for r in result]) == sorted([tuple(e) for e in expected])

    def test_example2(self):
        result = self.sol.solve_n_queens(1)
        assert result == [["Q"]]

    def test_n_equals_2(self):
        result = self.sol.solve_n_queens(2)
        assert result == []

    def test_n_equals_3(self):
        result = self.sol.solve_n_queens(3)
        assert result == []

    def test_n_equals_5(self):
        result = self.sol.solve_n_queens(5)
        assert len(result) == 10  # 5-queens has 10 solutions

    def test_board_size_correct(self):
        result = self.sol.solve_n_queens(4)
        for board in result:
            assert len(board) == 4
            for row in board:
                assert len(row) == 4

    def test_one_queen_per_row(self):
        result = self.sol.solve_n_queens(4)
        for board in result:
            for row in board:
                assert row.count('Q') == 1
