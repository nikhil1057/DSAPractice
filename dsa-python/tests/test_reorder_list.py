from solutions import ListNode, build_list, to_array
from solutions.linked_list.medium.reorder_list import ReorderList


class TestReorderList:
    def setup_method(self):
        self.sol = ReorderList()

    def test_example1(self):
        # [1,2,3,4] → [1,4,2,3]
        head = build_list([1, 2, 3, 4])
        self.sol.reorder_list(head)
        assert to_array(head) == [1, 4, 2, 3]

    def test_example2(self):
        # [1,2,3,4,5] → [1,5,2,4,3]
        head = build_list([1, 2, 3, 4, 5])
        self.sol.reorder_list(head)
        assert to_array(head) == [1, 5, 2, 4, 3]

    def test_single_node(self):
        head = build_list([1])
        self.sol.reorder_list(head)
        assert to_array(head) == [1]

    def test_two_nodes(self):
        head = build_list([1, 2])
        self.sol.reorder_list(head)
        assert to_array(head) == [1, 2]

    def test_three_nodes(self):
        head = build_list([1, 2, 3])
        self.sol.reorder_list(head)
        assert to_array(head) == [1, 3, 2]

    def test_six_nodes(self):
        # [1,2,3,4,5,6] → [1,6,2,5,3,4]
        head = build_list([1, 2, 3, 4, 5, 6])
        self.sol.reorder_list(head)
        assert to_array(head) == [1, 6, 2, 5, 3, 4]
