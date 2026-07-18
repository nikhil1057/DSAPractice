from solutions.sliding_window.hard.sliding_window_maximum import SlidingWindowMaximum


class TestSlidingWindowMaximum:
    def setup_method(self):
        self.sol = SlidingWindowMaximum()

    def test_example1(self):
        # [1,3,-1,-3,5,3,6,7], k=3 => [3,3,5,5,6,7]
        assert self.sol.max_sliding_window([1, 3, -1, -3, 5, 3, 6, 7], 3) == [3, 3, 5, 5, 6, 7]

    def test_example2(self):
        # [1], k=1 => [1]
        assert self.sol.max_sliding_window([1], 1) == [1]

    def test_k_equals_length(self):
        # [1,2,3,4], k=4 => [4]
        assert self.sol.max_sliding_window([1, 2, 3, 4], 4) == [4]

    def test_descending(self):
        # [5,4,3,2,1], k=2 => [5,4,3,2]
        assert self.sol.max_sliding_window([5, 4, 3, 2, 1], 2) == [5, 4, 3, 2]

    def test_ascending(self):
        # [1,2,3,4,5], k=2 => [2,3,4,5]
        assert self.sol.max_sliding_window([1, 2, 3, 4, 5], 2) == [2, 3, 4, 5]

    def test_all_same(self):
        # [3,3,3,3], k=2 => [3,3,3]
        assert self.sol.max_sliding_window([3, 3, 3, 3], 2) == [3, 3, 3]

    def test_negative_numbers(self):
        # [-1,-3,-5,-2], k=2 => [-1,-3,-2]
        assert self.sol.max_sliding_window([-1, -3, -5, -2], 2) == [-1, -3, -2]
