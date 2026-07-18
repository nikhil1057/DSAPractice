from solutions.dp_2d.medium.best_time_to_buy_and_sell_stock_with_cooldown import BestTimeToBuyAndSellStockWithCooldown


class TestBestTimeToBuyAndSellStockWithCooldown:
    def setup_method(self):
        self.sol = BestTimeToBuyAndSellStockWithCooldown()

    def test_example1(self):
        assert self.sol.max_profit([1, 2, 3, 0, 2]) == 3

    def test_example2(self):
        assert self.sol.max_profit([1]) == 0

    def test_decreasing_prices(self):
        assert self.sol.max_profit([5, 4, 3, 2, 1]) == 0

    def test_two_elements_profit(self):
        assert self.sol.max_profit([1, 4]) == 3

    def test_two_elements_no_profit(self):
        assert self.sol.max_profit([4, 1]) == 0

    def test_cooldown_matters(self):
        # Without cooldown: buy@1, sell@5, buy@2, sell@6 = 8
        # With cooldown: different strategy needed
        assert self.sol.max_profit([1, 5, 2, 6]) == 5

    def test_all_same(self):
        assert self.sol.max_profit([3, 3, 3, 3]) == 0

    def test_longer_sequence(self):
        assert self.sol.max_profit([1, 2, 3, 0, 2, 4]) == 5
