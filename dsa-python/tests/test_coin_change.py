from solutions.dp_1d.medium.coin_change import CoinChange


class TestCoinChange:
    def setup_method(self):
        self.sol = CoinChange()

    def test_example1(self):
        assert self.sol.coin_change([1, 5, 10], 11) == 2

    def test_example2(self):
        assert self.sol.coin_change([2], 3) == -1

    def test_example3(self):
        assert self.sol.coin_change([1], 0) == 0

    def test_single_coin_exact(self):
        assert self.sol.coin_change([5], 5) == 1

    def test_multiple_same_coin(self):
        assert self.sol.coin_change([1], 5) == 5

    def test_impossible(self):
        assert self.sol.coin_change([3, 7], 5) == -1

    def test_large_amount(self):
        assert self.sol.coin_change([1, 5, 10, 25], 100) == 4

    def test_greedy_fails(self):
        # Greedy would pick 6+1+1+1 = 4 coins, but 5+5+5+5 = 4 or 5+4+... actually
        # [1,3,4] amount=6 => 4+1+1=3 coins greedy, but 3+3=2 coins optimal
        assert self.sol.coin_change([1, 3, 4], 6) == 2
