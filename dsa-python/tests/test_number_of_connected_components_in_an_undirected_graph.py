from solutions.graphs.medium.number_of_connected_components_in_an_undirected_graph import NumberOfConnectedComponentsInAnUndirectedGraph


class TestNumberOfConnectedComponentsInAnUndirectedGraph:
    def setup_method(self):
        self.sol = NumberOfConnectedComponentsInAnUndirectedGraph()

    def test_example1(self):
        assert self.sol.count_components(5, [[0, 1], [1, 2], [3, 4]]) == 2

    def test_example2(self):
        assert self.sol.count_components(5, [[0, 1], [1, 2], [2, 3], [3, 4]]) == 1

    def test_all_isolated(self):
        assert self.sol.count_components(4, []) == 4

    def test_single_node(self):
        assert self.sol.count_components(1, []) == 1

    def test_fully_connected(self):
        assert self.sol.count_components(3, [[0, 1], [1, 2], [0, 2]]) == 1

    def test_two_components(self):
        assert self.sol.count_components(4, [[0, 1], [2, 3]]) == 2

    def test_three_components(self):
        assert self.sol.count_components(6, [[0, 1], [2, 3], [4, 5]]) == 3

    def test_star_graph(self):
        assert self.sol.count_components(5, [[0, 1], [0, 2], [0, 3], [0, 4]]) == 1
