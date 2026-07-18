from solutions.advanced_graphs.medium.network_delay_time import NetworkDelayTime


class TestNetworkDelayTime:
    def setup_method(self):
        self.sol = NetworkDelayTime()

    def test_example1(self):
        # times = [[2,1,1],[2,3,1],[3,4,1]], n=4, k=2 => 2
        assert self.sol.network_delay_time([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2) == 2

    def test_example2(self):
        # times = [[1,2,1]], n=2, k=1 => 1
        assert self.sol.network_delay_time([[1, 2, 1]], 2, 1) == 1

    def test_example3(self):
        # times = [[1,2,1]], n=2, k=2 => -1 (unreachable)
        assert self.sol.network_delay_time([[1, 2, 1]], 2, 2) == -1

    def test_single_node(self):
        # n=1, k=1, no edges => 0
        assert self.sol.network_delay_time([], 1, 1) == 0

    def test_multiple_paths(self):
        # Pick shortest path
        times = [[1, 2, 1], [1, 3, 4], [2, 3, 2]]
        assert self.sol.network_delay_time(times, 3, 1) == 3

    def test_disconnected_graph(self):
        # Node 3 unreachable from node 1
        times = [[1, 2, 1]]
        assert self.sol.network_delay_time(times, 3, 1) == -1

    def test_large_weights(self):
        times = [[1, 2, 100], [2, 3, 100]]
        assert self.sol.network_delay_time(times, 3, 1) == 200
