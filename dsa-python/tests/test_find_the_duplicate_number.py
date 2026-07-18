from solutions.linked_list.medium.find_the_duplicate_number import FindTheDuplicateNumber


class TestFindTheDuplicateNumber:
    def setup_method(self):
        self.sol = FindTheDuplicateNumber()

    def test_example1(self):
        # [1,3,4,2,2] → 2
        assert self.sol.find_duplicate([1, 3, 4, 2, 2]) == 2

    def test_example2(self):
        # [3,1,3,4,2] → 3
        assert self.sol.find_duplicate([3, 1, 3, 4, 2]) == 3

    def test_example3(self):
        # [3,3,3,3,3] → 3
        assert self.sol.find_duplicate([3, 3, 3, 3, 3]) == 3

    def test_two_elements(self):
        # [1,1] → 1
        assert self.sol.find_duplicate([1, 1]) == 1

    def test_duplicate_at_start(self):
        # [2,2,1,3,4] → 2
        assert self.sol.find_duplicate([2, 2, 1, 3, 4]) == 2

    def test_duplicate_at_end(self):
        # [1,2,3,4,4] → 4
        assert self.sol.find_duplicate([1, 2, 3, 4, 4]) == 4

    def test_larger_array(self):
        # [1,4,6,2,3,5,6] → 6
        assert self.sol.find_duplicate([1, 4, 6, 2, 3, 5, 6]) == 6
