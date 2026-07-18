from solutions.greedy.medium.gas_station import GasStation


class TestGasStation:
    def setup_method(self):
        self.sol = GasStation()

    def test_example1(self):
        assert self.sol.can_complete_circuit([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]) == 3

    def test_example2(self):
        assert self.sol.can_complete_circuit([2, 3, 4], [3, 4, 3]) == -1

    def test_single_station(self):
        assert self.sol.can_complete_circuit([5], [3]) == 0

    def test_single_station_impossible(self):
        assert self.sol.can_complete_circuit([3], [5]) == -1

    def test_start_at_zero(self):
        assert self.sol.can_complete_circuit([3, 1, 1], [1, 1, 1]) == 0

    def test_all_equal(self):
        assert self.sol.can_complete_circuit([1, 1, 1], [1, 1, 1]) == 0

    def test_larger_example(self):
        assert self.sol.can_complete_circuit([5, 8, 2, 8], [6, 5, 6, 6]) == 3
