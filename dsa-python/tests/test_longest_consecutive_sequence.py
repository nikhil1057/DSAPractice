from solutions.array_and_hashing.medium.longest_consecutive_sequence import LongestConsecutiveSequence


class TestLongestConsecutiveSequence:
    def setup_method(self):
        self.sol = LongestConsecutiveSequence()

    def test_example1(self):
        # [100,4,200,1,3,2] => 4 (sequence: 1,2,3,4)
        assert self.sol.longest_consecutive([100, 4, 200, 1, 3, 2]) == 4

    def test_example2(self):
        # [0,3,7,2,5,8,4,6,0,1] => 9
        assert self.sol.longest_consecutive([0, 3, 7, 2, 5, 8, 4, 6, 0, 1]) == 9

    def test_empty_array(self):
        assert self.sol.longest_consecutive([]) == 0

    def test_single_element(self):
        assert self.sol.longest_consecutive([1]) == 1

    def test_no_consecutive(self):
        # [10, 20, 30] => 1
        assert self.sol.longest_consecutive([10, 20, 30]) == 1

    def test_duplicates(self):
        # [1,2,0,1] => 3 (0,1,2)
        assert self.sol.longest_consecutive([1, 2, 0, 1]) == 3

    def test_negative_numbers(self):
        # [-3,-2,-1,0,1] => 5
        assert self.sol.longest_consecutive([-3, -2, -1, 0, 1]) == 5

    def test_all_same(self):
        # [5,5,5,5] => 1
        assert self.sol.longest_consecutive([5, 5, 5, 5]) == 1
