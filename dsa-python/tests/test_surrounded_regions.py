from solutions.graphs.medium.surrounded_regions import SurroundedRegions


class TestSurroundedRegions:
    def setup_method(self):
        self.sol = SurroundedRegions()

    def test_example1(self):
        board = [["X", "X", "X", "X"], ["X", "O", "O", "X"], ["X", "X", "O", "X"], ["X", "O", "X", "X"]]
        self.sol.solve(board)
        expected = [["X", "X", "X", "X"], ["X", "X", "X", "X"], ["X", "X", "X", "X"], ["X", "O", "X", "X"]]
        assert board == expected

    def test_example2(self):
        board = [["X"]]
        self.sol.solve(board)
        assert board == [["X"]]

    def test_all_o_on_border(self):
        board = [["O", "O"], ["O", "O"]]
        self.sol.solve(board)
        assert board == [["O", "O"], ["O", "O"]]

    def test_no_o(self):
        board = [["X", "X"], ["X", "X"]]
        self.sol.solve(board)
        assert board == [["X", "X"], ["X", "X"]]

    def test_surrounded_o(self):
        board = [["X", "X", "X"], ["X", "O", "X"], ["X", "X", "X"]]
        self.sol.solve(board)
        expected = [["X", "X", "X"], ["X", "X", "X"], ["X", "X", "X"]]
        assert board == expected

    def test_o_connected_to_border(self):
        board = [["X", "O", "X"], ["O", "O", "X"], ["X", "X", "X"]]
        self.sol.solve(board)
        expected = [["X", "O", "X"], ["O", "O", "X"], ["X", "X", "X"]]
        assert board == expected

    def test_single_row(self):
        board = [["O", "X", "O"]]
        self.sol.solve(board)
        assert board == [["O", "X", "O"]]
