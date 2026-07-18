from solutions.graphs.medium.clone_graph import CloneGraph, Node


class TestCloneGraph:
    def setup_method(self):
        self.sol = CloneGraph()

    def _build_graph(self, adj_list):
        if not adj_list:
            return None
        nodes = [Node(i + 1) for i in range(len(adj_list))]
        for i, neighbors in enumerate(adj_list):
            nodes[i].neighbors = [nodes[n - 1] for n in neighbors]
        return nodes[0]

    def test_example1(self):
        node = self._build_graph([[2, 4], [1, 3], [2, 4], [1, 3]])
        clone = self.sol.clone_graph(node)
        assert clone is not None
        assert clone is not node
        assert clone.val == 1

    def test_example2(self):
        node = self._build_graph([[]])
        clone = self.sol.clone_graph(node)
        assert clone is not None
        assert clone.val == 1
        assert clone.neighbors == []

    def test_none_input(self):
        assert self.sol.clone_graph(None) is None

    def test_deep_copy(self):
        node = self._build_graph([[2], [1]])
        clone = self.sol.clone_graph(node)
        assert clone is not node
        assert clone.neighbors[0] is not node.neighbors[0]

    def test_single_node_no_neighbors(self):
        node = Node(1)
        clone = self.sol.clone_graph(node)
        assert clone is not None
        assert clone is not node
        assert clone.val == 1

    def test_three_node_cycle(self):
        node = self._build_graph([[2, 3], [1, 3], [1, 2]])
        clone = self.sol.clone_graph(node)
        assert clone is not None
        assert len(clone.neighbors) == 2
