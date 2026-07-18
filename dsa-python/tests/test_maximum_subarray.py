from solutions.greedy.medium.maximum_subarray import MaximumSubarray


class TestMaximumSubarray:
    def setup_method(self):
        self.sol = MaximumSubarray()

    def test_example1(self):
        assert self.sol.max_sub_array([-2, 1, -3, 4, -1, 2, 1, -5, 4]) == 6

    def test_example2(self):
        assert self.sol.max_sub_array([1]) == 1

    def test_example3(self):
        assert self.sol.max_sub_array([5, 4, -1, 7, 8]) == 23

    def test_all_negative(self):
        assert self.sol.max_sub_array([-3, -2, -1, -4]) == -1

    def test_single_negative(self):
        assert self.sol.max_sub_array([-1]) == -1

    def test_all_positive(self):
        assert self.sol.max_sub_array([1, 2, 3, 4]) == 10

    def test_alternating(self):
        assert self.sol.max_sub_array([-1, 2, -1, 2, -1]) == 3
