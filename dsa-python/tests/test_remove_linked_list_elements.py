from solutions import build_list, to_array
from solutions.remove_linked_list_elements import RemoveLinkedListElements


class TestRemoveLinkedListElements:
    def setup_method(self):
        self.sol = RemoveLinkedListElements()

    def test_example1(self):
        # [1,2,6,3,4,5,6] remove 6 => [1,2,3,4,5]
        result = self.sol.remove_elements(build_list([1, 2, 6, 3, 4, 5, 6]), 6)
        assert to_array(result) == [1, 2, 3, 4, 5]

    def test_example2(self):
        assert self.sol.remove_elements(None, 1) is None

    def test_example3(self):
        # [7,7,7,7] remove 7 => []
        assert self.sol.remove_elements(build_list([7, 7, 7, 7]), 7) is None

    def test_remove_head(self):
        result = self.sol.remove_elements(build_list([1, 2, 3]), 1)
        assert to_array(result) == [2, 3]

    def test_remove_tail(self):
        result = self.sol.remove_elements(build_list([1, 2, 3]), 3)
        assert to_array(result) == [1, 2]

    def test_no_match(self):
        result = self.sol.remove_elements(build_list([1, 2, 3]), 9)
        assert to_array(result) == [1, 2, 3]

    def test_consecutive_at_head(self):
        result = self.sol.remove_elements(build_list([1, 1, 2, 3]), 1)
        assert to_array(result) == [2, 3]
