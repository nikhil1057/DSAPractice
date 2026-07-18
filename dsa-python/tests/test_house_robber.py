from solutions.dp_1d.medium.house_robber import HouseRobber


class TestHouseRobber:
    def setup_method(self):
        self.sol = HouseRobber()

    def test_example1(self):
        assert self.sol.rob([1, 2, 3, 1]) == 4

    def test_example2(self):
        assert self.sol.rob([2, 7, 9, 3, 1]) == 12

    def test_single_house(self):
        assert self.sol.rob([5]) == 5

    def test_two_houses(self):
        assert self.sol.rob([1, 2]) == 2

    def test_all_same(self):
        assert self.sol.rob([3, 3, 3, 3]) == 6

    def test_large_values(self):
        assert self.sol.rob([100, 1, 1, 100]) == 200

    def test_alternating(self):
        assert self.sol.rob([1, 100, 1, 100, 1]) == 200
