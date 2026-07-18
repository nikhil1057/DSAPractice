from solutions.array_and_hashing.easy.contains_duplicate import ContainsDuplicate


class TestContainsDuplicate:
    def setup_method(self):
        self.sol = ContainsDuplicate()

    def test_example1(self):
        # [1,2,3,1] => true
        assert self.sol.contains_duplicate([1, 2, 3, 1]) is True

    def test_example2(self):
        # [1,2,3,4] => false
        assert self.sol.contains_duplicate([1, 2, 3, 4]) is False

    def test_example3(self):
        # [1,1,1,3,3,4,3,2,4,2] => true
        assert self.sol.contains_duplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]) is True

    def test_single_element(self):
        assert self.sol.contains_duplicate([1]) is False

    def test_two_same_elements(self):
        assert self.sol.contains_duplicate([5, 5]) is True

    def test_empty_array(self):
        assert self.sol.contains_duplicate([]) is False

    def test_negative_numbers(self):
        assert self.sol.contains_duplicate([-1, -2, -3, -1]) is True

    def test_large_range_no_duplicates(self):
        assert self.sol.contains_duplicate(list(range(1000))) is False
