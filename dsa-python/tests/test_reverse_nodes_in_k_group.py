from solutions import ListNode, build_list, to_array
from solutions.linked_list.hard.reverse_nodes_in_k_group import ReverseNodesInKGroup


class TestReverseNodesInKGroup:
    def setup_method(self):
        self.sol = ReverseNodesInKGroup()

    def test_example1(self):
        # [1,2,3,4,5], k=2 → [2,1,4,3,5]
        head = build_list([1, 2, 3, 4, 5])
        result = self.sol.reverse_k_group(head, 2)
        assert to_array(result) == [2, 1, 4, 3, 5]

    def test_example2(self):
        # [1,2,3,4,5], k=3 → [3,2,1,4,5]
        head = build_list([1, 2, 3, 4, 5])
        result = self.sol.reverse_k_group(head, 3)
        assert to_array(result) == [3, 2, 1, 4, 5]

    def test_k_equals_1(self):
        # k=1 means no change
        head = build_list([1, 2, 3])
        result = self.sol.reverse_k_group(head, 1)
        assert to_array(result) == [1, 2, 3]

    def test_k_equals_length(self):
        # [1,2,3], k=3 → [3,2,1]
        head = build_list([1, 2, 3])
        result = self.sol.reverse_k_group(head, 3)
        assert to_array(result) == [3, 2, 1]

    def test_k_greater_than_length(self):
        # [1,2], k=3 → [1,2] (fewer than k nodes, no reversal)
        head = build_list([1, 2])
        result = self.sol.reverse_k_group(head, 3)
        assert to_array(result) == [1, 2]

    def test_single_node(self):
        head = build_list([1])
        result = self.sol.reverse_k_group(head, 1)
        assert to_array(result) == [1]

    def test_even_groups(self):
        # [1,2,3,4,5,6], k=2 → [2,1,4,3,6,5]
        head = build_list([1, 2, 3, 4, 5, 6])
        result = self.sol.reverse_k_group(head, 2)
        assert to_array(result) == [2, 1, 4, 3, 6, 5]

    def test_full_reversal(self):
        # [1,2,3,4], k=4 → [4,3,2,1]
        head = build_list([1, 2, 3, 4])
        result = self.sol.reverse_k_group(head, 4)
        assert to_array(result) == [4, 3, 2, 1]
