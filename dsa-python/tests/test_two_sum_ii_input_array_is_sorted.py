from solutions.two_pointers.medium.two_sum_ii_input_array_is_sorted import TwoSumIIInputArrayIsSorted


class TestTwoSumIIInputArrayIsSorted:
    def setup_method(self):
        self.sol = TwoSumIIInputArrayIsSorted()

    def test_example1(self):
        # [2,7,11,15], target=9 => [1,2]
        assert self.sol.two_sum([2, 7, 11, 15], 9) == [1, 2]

    def test_example2(self):
        # [2,3,4], target=6 => [1,3]
        assert self.sol.two_sum([2, 3, 4], 6) == [1, 3]

    def test_example3(self):
        # [-1,0], target=-1 => [1,2]
        assert self.sol.two_sum([-1, 0], -1) == [1, 2]

    def test_first_and_last(self):
        # [1,2,3,4,5], target=6 => [1,5]
        assert self.sol.two_sum([1, 2, 3, 4, 5], 6) == [1, 5]

    def test_adjacent_elements(self):
        # [1,2,3,4], target=3 => [1,2]
        assert self.sol.two_sum([1, 2, 3, 4], 3) == [1, 2]

    def test_negative_numbers(self):
        # [-5,-3,-1,0,2,4], target=-4 => [2,3] (-3 + -1 = -4)
        assert self.sol.two_sum([-5, -3, -1, 0, 2, 4], -4) == [2, 3]

    def test_large_target(self):
        # [1,5,10,20,50], target=70 => [4,5]
        assert self.sol.two_sum([1, 5, 10, 20, 50], 70) == [4, 5]
