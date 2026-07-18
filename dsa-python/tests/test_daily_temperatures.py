from solutions.stack.medium.daily_temperatures import DailyTemperatures


class TestDailyTemperatures:
    def setup_method(self):
        self.sol = DailyTemperatures()

    def test_example1(self):
        # [73,74,75,71,69,72,76,73] → [1,1,4,2,1,1,0,0]
        assert self.sol.daily_temperatures([73, 74, 75, 71, 69, 72, 76, 73]) == [1, 1, 4, 2, 1, 1, 0, 0]

    def test_example2(self):
        # [30,40,50,60] → [1,1,1,0]
        assert self.sol.daily_temperatures([30, 40, 50, 60]) == [1, 1, 1, 0]

    def test_example3(self):
        # [30,60,90] → [1,1,0]
        assert self.sol.daily_temperatures([30, 60, 90]) == [1, 1, 0]

    def test_all_same(self):
        # [50,50,50] → [0,0,0]
        assert self.sol.daily_temperatures([50, 50, 50]) == [0, 0, 0]

    def test_decreasing(self):
        # [90,80,70,60] → [0,0,0,0]
        assert self.sol.daily_temperatures([90, 80, 70, 60]) == [0, 0, 0, 0]

    def test_single_element(self):
        assert self.sol.daily_temperatures([50]) == [0]

    def test_two_elements_warmer(self):
        assert self.sol.daily_temperatures([30, 50]) == [1, 0]

    def test_two_elements_cooler(self):
        assert self.sol.daily_temperatures([50, 30]) == [0, 0]
