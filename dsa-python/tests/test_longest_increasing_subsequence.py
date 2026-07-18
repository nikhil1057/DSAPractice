from solutions.dp_1d.medium.longest_increasing_subsequence import LongestIncreasingSubsequence


class TestLongestIncreasingSubsequence:
    def setup_method(self):
        self.sol = LongestIncreasingSubsequence()

    def test_example1(self):
        assert self.sol.length_of_lis([10, 9, 2, 5, 3, 7, 101, 18]) == 4

    def test_example2(self):
        assert self.sol.length_of_lis([0, 1, 0, 3, 2, 3]) == 4

    def test_example3(self):
        assert self.sol.length_of_lis([7, 7, 7, 7, 7, 7, 7]) == 1

    def test_single_element(self):
        assert self.sol.length_of_lis([10]) == 1

    def test_sorted_ascending(self):
        assert self.sol.length_of_lis([1, 2, 3, 4, 5]) == 5

    def test_sorted_descending(self):
        assert self.sol.length_of_lis([5, 4, 3, 2, 1]) == 1

    def test_two_elements_increasing(self):
        assert self.sol.length_of_lis([1, 2]) == 2

    def test_alternating(self):
        assert self.sol.length_of_lis([1, 3, 2, 4, 3, 5]) == 4
