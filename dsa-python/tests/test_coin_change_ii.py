from solutions.dp_2d.medium.coin_change_ii import CoinChangeII


class TestCoinChangeII:
    def setup_method(self):
        self.sol = CoinChangeII()

    def test_example1(self):
        assert self.sol.change(5, [1, 2, 5]) == 4

    def test_example2(self):
        assert self.sol.change(3, [2]) == 0

    def test_example3(self):
        assert self.sol.change(10, [10]) == 1

    def test_amount_zero(self):
        assert self.sol.change(0, [1, 2, 5]) == 1

    def test_single_coin(self):
        assert self.sol.change(4, [1]) == 1

    def test_no_coins(self):
        assert self.sol.change(5, []) == 0

    def test_large_amount(self):
        assert self.sol.change(5, [1, 2]) == 3

    def test_impossible(self):
        assert self.sol.change(3, [5, 7]) == 0
