from solutions.array_and_hashing.easy.best_time_to_buy_and_sell_stock import BestTimeToBuyAndSellStock


class TestBestTimeToBuyAndSellStock:
    def setup_method(self):
        self.sol = BestTimeToBuyAndSellStock()

    def test_example1(self):
        # Buy on day 2 (price=1), sell on day 5 (price=6), profit = 5
        assert self.sol.max_profit([7, 1, 5, 3, 6, 4]) == 5

    def test_example2(self):
        # Prices only decrease, no profit possible
        assert self.sol.max_profit([7, 6, 4, 3, 1]) == 0

    def test_single_element(self):
        assert self.sol.max_profit([5]) == 0

    def test_two_elements_profit(self):
        assert self.sol.max_profit([1, 5]) == 4

    def test_two_elements_no_profit(self):
        assert self.sol.max_profit([5, 1]) == 0

    def test_all_same(self):
        assert self.sol.max_profit([3, 3, 3, 3]) == 0

    def test_profit_at_end(self):
        assert self.sol.max_profit([2, 4, 1, 7]) == 6

    def test_large_dip_then_rise(self):
        assert self.sol.max_profit([10, 1, 2, 3, 4, 5]) == 4
