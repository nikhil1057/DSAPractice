from solutions.array_and_hashing.easy.two_sum import TwoSum


class TestTwoSum:
    def setup_method(self):
        self.sol = TwoSum()

    def test_example1(self):
        # [2,7,11,15], target=9 => [0,1]
        result = self.sol.two_sum([2, 7, 11, 15], 9)
        assert sorted(result) == [0, 1]

    def test_example2(self):
        # [3,2,4], target=6 => [1,2]
        result = self.sol.two_sum([3, 2, 4], 6)
        assert sorted(result) == [1, 2]

    def test_example3(self):
        # [3,3], target=6 => [0,1]
        result = self.sol.two_sum([3, 3], 6)
        assert sorted(result) == [0, 1]

    def test_negative_numbers(self):
        # [-1,-2,-3,-4,-5], target=-8 => [2,4]
        result = self.sol.two_sum([-1, -2, -3, -4, -5], -8)
        assert sorted(result) == [2, 4]

    def test_zero_target(self):
        # [-1,0,1,2], target=0 => [0,2]
        result = self.sol.two_sum([-1, 0, 1, 2], 0)
        assert sorted(result) == [0, 2]

    def test_large_numbers(self):
        # [1000000, 500000, 500000], target=1000000 => [1,2]
        result = self.sol.two_sum([1000000, 500000, 500000], 1000000)
        assert sorted(result) == [1, 2]
