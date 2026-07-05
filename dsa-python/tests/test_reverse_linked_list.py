from solutions import build_list, to_array
from solutions.linked_list.easy.reverse_linked_list import ReverseLinkedList


class TestReverseLinkedList:
    def setup_method(self):
        self.sol = ReverseLinkedList()

    def test_example1(self):
        result = self.sol.reverse_list(build_list([1, 2, 3, 4, 5]))
        assert to_array(result) == [5, 4, 3, 2, 1]

    def test_example2(self):
        result = self.sol.reverse_list(build_list([1, 2]))
        assert to_array(result) == [2, 1]

    def test_example3(self):
        assert self.sol.reverse_list(None) is None

    def test_single(self):
        result = self.sol.reverse_list(build_list([1]))
        assert to_array(result) == [1]

    def test_three_elements(self):
        result = self.sol.reverse_list(build_list([1, 2, 3]))
        assert to_array(result) == [3, 2, 1]
