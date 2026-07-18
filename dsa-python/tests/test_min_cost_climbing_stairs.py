from solutions.dp_1d.easy.min_cost_climbing_stairs import MinCostClimbingStairs


class TestMinCostClimbingStairs:
    def setup_method(self):
        self.sol = MinCostClimbingStairs()

    def test_example1(self):
        assert self.sol.min_cost_climbing_stairs([10, 15, 20]) == 15

    def test_example2(self):
        assert self.sol.min_cost_climbing_stairs([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]) == 6

    def test_two_steps(self):
        assert self.sol.min_cost_climbing_stairs([10, 15]) == 10

    def test_all_same_cost(self):
        assert self.sol.min_cost_climbing_stairs([5, 5, 5, 5]) == 10

    def test_increasing_cost(self):
        assert self.sol.min_cost_climbing_stairs([1, 2, 3, 4, 5]) == 6

    def test_decreasing_cost(self):
        assert self.sol.min_cost_climbing_stairs([5, 4, 3, 2, 1]) == 6

    def test_zero_costs(self):
        assert self.sol.min_cost_climbing_stairs([0, 0, 0]) == 0
