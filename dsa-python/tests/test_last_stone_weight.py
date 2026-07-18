from solutions.heap.easy.last_stone_weight import LastStoneWeight


class TestLastStoneWeight:
    def setup_method(self):
        self.sol = LastStoneWeight()

    def test_example1(self):
        assert self.sol.last_stone_weight([2, 7, 4, 1, 8, 1]) == 1

    def test_example2(self):
        assert self.sol.last_stone_weight([1]) == 1

    def test_two_equal_stones(self):
        assert self.sol.last_stone_weight([2, 2]) == 0

    def test_two_different_stones(self):
        assert self.sol.last_stone_weight([3, 7]) == 4

    def test_all_same(self):
        assert self.sol.last_stone_weight([5, 5, 5, 5]) == 0

    def test_decreasing(self):
        assert self.sol.last_stone_weight([10, 5, 3, 1]) == 1

    def test_large_values(self):
        assert self.sol.last_stone_weight([1000, 999]) == 1
