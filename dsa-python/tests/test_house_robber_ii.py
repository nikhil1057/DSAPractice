from solutions.dp_1d.medium.house_robber_ii import HouseRobberII


class TestHouseRobberII:
    def setup_method(self):
        self.sol = HouseRobberII()

    def test_example1(self):
        assert self.sol.rob([2, 3, 2]) == 3

    def test_example2(self):
        assert self.sol.rob([1, 2, 3, 1]) == 4

    def test_example3(self):
        assert self.sol.rob([1, 2, 3]) == 3

    def test_single_house(self):
        assert self.sol.rob([5]) == 5

    def test_two_houses(self):
        assert self.sol.rob([1, 2]) == 2

    def test_all_same(self):
        assert self.sol.rob([3, 3, 3, 3]) == 6

    def test_large_values(self):
        assert self.sol.rob([200, 3, 140, 20, 10]) == 340
