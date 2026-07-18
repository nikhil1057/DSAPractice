from solutions.two_pointers.hard.trapping_rain_water import TrappingRainWater


class TestTrappingRainWater:
    def setup_method(self):
        self.sol = TrappingRainWater()

    def test_example1(self):
        # [0,1,0,2,1,0,1,3,2,1,2,1] => 6
        assert self.sol.trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]) == 6

    def test_example2(self):
        # [4,2,0,3,2,5] => 9
        assert self.sol.trap([4, 2, 0, 3, 2, 5]) == 9

    def test_no_water(self):
        # [1,2,3,4,5] => 0 (ascending)
        assert self.sol.trap([1, 2, 3, 4, 5]) == 0

    def test_descending(self):
        # [5,4,3,2,1] => 0
        assert self.sol.trap([5, 4, 3, 2, 1]) == 0

    def test_empty(self):
        assert self.sol.trap([]) == 0

    def test_single_element(self):
        assert self.sol.trap([5]) == 0

    def test_two_elements(self):
        assert self.sol.trap([3, 1]) == 0

    def test_flat(self):
        # [3,3,3,3] => 0
        assert self.sol.trap([3, 3, 3, 3]) == 0
