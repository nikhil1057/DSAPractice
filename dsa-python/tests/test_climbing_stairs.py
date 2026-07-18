from solutions.dp_1d.easy.climbing_stairs import ClimbingStairs


class TestClimbingStairs:
    def setup_method(self):
        self.sol = ClimbingStairs()

    def test_example1(self):
        assert self.sol.climb_stairs(2) == 2

    def test_example2(self):
        assert self.sol.climb_stairs(3) == 3

    def test_one_step(self):
        assert self.sol.climb_stairs(1) == 1

    def test_four_steps(self):
        assert self.sol.climb_stairs(4) == 5

    def test_five_steps(self):
        assert self.sol.climb_stairs(5) == 8

    def test_large_n(self):
        assert self.sol.climb_stairs(10) == 89

    def test_fibonacci_property(self):
        # f(n) = f(n-1) + f(n-2)
        assert self.sol.climb_stairs(6) == 13
