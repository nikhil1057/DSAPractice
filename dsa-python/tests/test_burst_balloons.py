from solutions.dp_2d.hard.burst_balloons import BurstBalloons


class TestBurstBalloons:
    def setup_method(self):
        self.sol = BurstBalloons()

    def test_example1(self):
        assert self.sol.max_coins([3, 1, 5, 8]) == 167

    def test_example2(self):
        assert self.sol.max_coins([1, 5]) == 10

    def test_single_balloon(self):
        assert self.sol.max_coins([5]) == 5

    def test_two_same_balloons(self):
        assert self.sol.max_coins([3, 3]) == 12

    def test_increasing(self):
        assert self.sol.max_coins([1, 2, 3]) == 12

    def test_all_ones(self):
        assert self.sol.max_coins([1, 1, 1]) == 3

    def test_single_large(self):
        assert self.sol.max_coins([10]) == 10
