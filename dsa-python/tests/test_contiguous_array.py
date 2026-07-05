from solutions.array_and_hashing.medium.contiguous_array import ContiguousArray


class TestContiguousArray:
    def setup_method(self):
        self.sol = ContiguousArray()

    def test_example1(self):
        # [0,1] => 2
        assert self.sol.find_max_length([0, 1]) == 2

    def test_example2(self):
        # [0,1,0] => 2
        assert self.sol.find_max_length([0, 1, 0]) == 2

    def test_all_zeros(self):
        assert self.sol.find_max_length([0, 0, 0]) == 0

    def test_all_ones(self):
        assert self.sol.find_max_length([1, 1, 1]) == 0

    def test_entire_array(self):
        # [0,1,1,0] => 4
        assert self.sol.find_max_length([0, 1, 1, 0]) == 4

    def test_longer_array(self):
        # [0,0,1,0,0,0,1,1] => 6
        assert self.sol.find_max_length([0, 0, 1, 0, 0, 0, 1, 1]) == 6

    def test_single_element(self):
        assert self.sol.find_max_length([0]) == 0

    def test_alternating_long(self):
        # [0,1,0,1,0,1] => 6
        assert self.sol.find_max_length([0, 1, 0, 1, 0, 1]) == 6
