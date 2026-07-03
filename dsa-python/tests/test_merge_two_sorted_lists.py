from solutions import build_list, to_array
from solutions.merge_two_sorted_lists import MergeTwoSortedLists


class TestMergeTwoSortedLists:
    def setup_method(self):
        self.sol = MergeTwoSortedLists()

    def test_example1(self):
        # [1,2,4] + [1,3,4] => [1,1,2,3,4,4]
        result = self.sol.merge_two_lists(build_list([1, 2, 4]), build_list([1, 3, 4]))
        assert to_array(result) == [1, 1, 2, 3, 4, 4]

    def test_example2(self):
        # [] + [] => []
        assert self.sol.merge_two_lists(None, None) is None

    def test_example3(self):
        # [] + [0] => [0]
        result = self.sol.merge_two_lists(None, build_list([0]))
        assert to_array(result) == [0]

    def test_first_empty(self):
        result = self.sol.merge_two_lists(None, build_list([1, 2, 3]))
        assert to_array(result) == [1, 2, 3]

    def test_second_empty(self):
        result = self.sol.merge_two_lists(build_list([1, 2, 3]), None)
        assert to_array(result) == [1, 2, 3]

    def test_different_lengths(self):
        result = self.sol.merge_two_lists(build_list([1, 5]), build_list([2, 3, 4, 6]))
        assert to_array(result) == [1, 2, 3, 4, 5, 6]

    def test_single_elements(self):
        result = self.sol.merge_two_lists(build_list([2]), build_list([1]))
        assert to_array(result) == [1, 2]
