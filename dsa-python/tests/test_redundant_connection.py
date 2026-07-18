from solutions.graphs.medium.redundant_connection import RedundantConnection


class TestRedundantConnection:
    def setup_method(self):
        self.sol = RedundantConnection()

    def test_example1(self):
        assert self.sol.find_redundant_connection([[1, 2], [1, 3], [2, 3]]) == [2, 3]

    def test_example2(self):
        assert self.sol.find_redundant_connection([[1, 2], [2, 3], [3, 4], [1, 4], [1, 5]]) == [1, 4]

    def test_three_node_cycle(self):
        assert self.sol.find_redundant_connection([[1, 2], [2, 3], [1, 3]]) == [1, 3]

    def test_four_node_cycle(self):
        assert self.sol.find_redundant_connection([[1, 2], [2, 3], [3, 4], [4, 1]]) == [4, 1]

    def test_last_edge_redundant(self):
        assert self.sol.find_redundant_connection([[1, 2], [1, 3], [1, 4], [3, 4]]) == [3, 4]

    def test_five_nodes(self):
        edges = [[1, 2], [3, 4], [1, 3], [2, 4], [1, 5]]
        assert self.sol.find_redundant_connection(edges) == [2, 4]

    def test_linear_with_cycle_at_end(self):
        edges = [[1, 2], [2, 3], [3, 4], [4, 5], [3, 5]]
        assert self.sol.find_redundant_connection(edges) == [3, 5]
