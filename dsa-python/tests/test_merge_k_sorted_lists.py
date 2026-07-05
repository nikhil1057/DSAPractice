from solutions import build_list, to_array
from solutions.linked_list.hard.merge_k_sorted_lists import MergeKSortedLists


class TestMergeKSortedLists:
    def setup_method(self):
        self.sol = MergeKSortedLists()

    def test_example1(self):
        # [[1,4,5],[1,3,4],[2,6]] => [1,1,2,3,4,4,5,6]
        lists = [build_list([1, 4, 5]), build_list([1, 3, 4]), build_list([2, 6])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 1, 2, 3, 4, 4, 5, 6]

    def test_example2(self):
        # [] => None
        assert self.sol.merge_k_lists([]) is None

    def test_example3(self):
        # [[]] => None
        assert self.sol.merge_k_lists([None]) is None

    def test_single_list(self):
        lists = [build_list([1, 2, 3])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 2, 3]

    def test_two_lists(self):
        lists = [build_list([1, 3, 5]), build_list([2, 4, 6])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 2, 3, 4, 5, 6]

    def test_all_empty_lists(self):
        lists = [None, None, None]
        assert self.sol.merge_k_lists(lists) is None

    def test_some_empty_lists(self):
        lists = [None, build_list([1, 3]), None, build_list([2, 4])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 2, 3, 4]

    def test_single_element_lists(self):
        lists = [build_list([5]), build_list([1]), build_list([3])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 3, 5]

    def test_duplicate_values(self):
        lists = [build_list([1, 1, 1]), build_list([1, 1]), build_list([1])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [1, 1, 1, 1, 1, 1]

    def test_negative_values(self):
        lists = [build_list([-3, -1, 2]), build_list([-2, 0, 4])]
        result = self.sol.merge_k_lists(lists)
        assert to_array(result) == [-3, -2, -1, 0, 2, 4]
