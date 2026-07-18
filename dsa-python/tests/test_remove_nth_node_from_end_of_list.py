from solutions import ListNode, build_list, to_array
from solutions.linked_list.medium.remove_nth_node_from_end_of_list import RemoveNthNodeFromEndOfList


class TestRemoveNthNodeFromEndOfList:
    def setup_method(self):
        self.sol = RemoveNthNodeFromEndOfList()

    def test_example1(self):
        # [1,2,3,4,5], n=2 → [1,2,3,5]
        head = build_list([1, 2, 3, 4, 5])
        result = self.sol.remove_nth_from_end(head, 2)
        assert to_array(result) == [1, 2, 3, 5]

    def test_example2(self):
        # [1], n=1 → []
        head = build_list([1])
        result = self.sol.remove_nth_from_end(head, 1)
        assert to_array(result) == []

    def test_example3(self):
        # [1,2], n=1 → [1]
        head = build_list([1, 2])
        result = self.sol.remove_nth_from_end(head, 1)
        assert to_array(result) == [1]

    def test_remove_head(self):
        # [1,2], n=2 → [2]
        head = build_list([1, 2])
        result = self.sol.remove_nth_from_end(head, 2)
        assert to_array(result) == [2]

    def test_remove_middle(self):
        # [1,2,3], n=2 → [1,3]
        head = build_list([1, 2, 3])
        result = self.sol.remove_nth_from_end(head, 2)
        assert to_array(result) == [1, 3]

    def test_remove_last(self):
        # [1,2,3,4], n=1 → [1,2,3]
        head = build_list([1, 2, 3, 4])
        result = self.sol.remove_nth_from_end(head, 1)
        assert to_array(result) == [1, 2, 3]

    def test_long_list(self):
        # [1,2,3,4,5,6,7], n=4 → [1,2,3,5,6,7]
        head = build_list([1, 2, 3, 4, 5, 6, 7])
        result = self.sol.remove_nth_from_end(head, 4)
        assert to_array(result) == [1, 2, 3, 5, 6, 7]
