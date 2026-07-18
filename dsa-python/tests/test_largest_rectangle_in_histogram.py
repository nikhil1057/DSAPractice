from solutions.stack.hard.largest_rectangle_in_histogram import LargestRectangleInHistogram


class TestLargestRectangleInHistogram:
    def setup_method(self):
        self.sol = LargestRectangleInHistogram()

    def test_example1(self):
        # [2,1,5,6,2,3] → 10
        assert self.sol.largest_rectangle_area([2, 1, 5, 6, 2, 3]) == 10

    def test_example2(self):
        # [2,4] → 4
        assert self.sol.largest_rectangle_area([2, 4]) == 4

    def test_single_bar(self):
        assert self.sol.largest_rectangle_area([5]) == 5

    def test_all_same_height(self):
        # [3,3,3,3] → 12
        assert self.sol.largest_rectangle_area([3, 3, 3, 3]) == 12

    def test_increasing(self):
        # [1,2,3,4] → 6 (bars 2,3,4 with height 2, or bars 3,4 with height 3)
        assert self.sol.largest_rectangle_area([1, 2, 3, 4]) == 6

    def test_decreasing(self):
        # [4,3,2,1] → 6
        assert self.sol.largest_rectangle_area([4, 3, 2, 1]) == 6

    def test_valley(self):
        # [5,1,5] → 5
        assert self.sol.largest_rectangle_area([5, 1, 5]) == 5

    def test_all_ones(self):
        # [1,1,1,1,1] → 5
        assert self.sol.largest_rectangle_area([1, 1, 1, 1, 1]) == 5
