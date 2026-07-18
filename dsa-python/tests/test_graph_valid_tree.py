from solutions.graphs.medium.graph_valid_tree import GraphValidTree


class TestGraphValidTree:
    def setup_method(self):
        self.sol = GraphValidTree()

    def test_example1(self):
        assert self.sol.valid_tree(5, [[0, 1], [0, 2], [0, 3], [1, 4]]) is True

    def test_example2(self):
        assert self.sol.valid_tree(5, [[0, 1], [1, 2], [2, 3], [1, 3], [1, 4]]) is False

    def test_single_node(self):
        assert self.sol.valid_tree(1, []) is True

    def test_two_nodes_connected(self):
        assert self.sol.valid_tree(2, [[0, 1]]) is True

    def test_two_nodes_disconnected(self):
        assert self.sol.valid_tree(2, []) is False

    def test_disconnected_graph(self):
        assert self.sol.valid_tree(4, [[0, 1], [2, 3]]) is False

    def test_linear_tree(self):
        assert self.sol.valid_tree(4, [[0, 1], [1, 2], [2, 3]]) is True

    def test_cycle_three_nodes(self):
        assert self.sol.valid_tree(3, [[0, 1], [1, 2], [2, 0]]) is False
