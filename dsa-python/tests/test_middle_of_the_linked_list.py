from solutions import build_list, to_array
from solutions.middle_of_the_linked_list import MiddleOfTheLinkedList


class TestMiddleOfTheLinkedList:
    def setup_method(self):
        self.sol = MiddleOfTheLinkedList()

    def test_example1_odd(self):
        # [1,2,3,4,5] => middle is 3, return [3,4,5]
        result = self.sol.middle_node(build_list([1, 2, 3, 4, 5]))
        assert to_array(result) == [3, 4, 5]

    def test_example2_even(self):
        # [1,2,3,4,5,6] => second middle is 4, return [4,5,6]
        result = self.sol.middle_node(build_list([1, 2, 3, 4, 5, 6]))
        assert to_array(result) == [4, 5, 6]

    def test_single(self):
        result = self.sol.middle_node(build_list([1]))
        assert to_array(result) == [1]

    def test_two_nodes(self):
        result = self.sol.middle_node(build_list([1, 2]))
        assert to_array(result) == [2]

    def test_three_nodes(self):
        result = self.sol.middle_node(build_list([1, 2, 3]))
        assert to_array(result) == [2, 3]
