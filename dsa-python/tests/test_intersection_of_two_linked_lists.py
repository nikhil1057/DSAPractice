import pytest
from solutions import ListNode, build_list
from solutions.intersection_of_two_linked_lists import IntersectionOfTwoLinkedLists


def attach(prefix: list[int], intersection: ListNode | None) -> ListNode | None:
    if not prefix:
        return intersection
    head = build_list(prefix)
    current = head
    while current.next:
        current = current.next
    current.next = intersection
    return head


class TestIntersectionOfTwoLinkedLists:
    def setup_method(self):
        self.sol = IntersectionOfTwoLinkedLists()

    def test_example1(self):
        shared = build_list([8, 4, 5])
        head_a = attach([4, 1], shared)
        head_b = attach([5, 6, 1], shared)
        assert self.sol.get_intersection_node(head_a, head_b) is shared

    def test_example2(self):
        shared = build_list([2, 4])
        head_a = attach([1, 9, 1], shared)
        head_b = attach([3], shared)
        assert self.sol.get_intersection_node(head_a, head_b) is shared

    def test_no_intersection(self):
        head_a = build_list([2, 6, 4])
        head_b = build_list([1, 5])
        assert self.sol.get_intersection_node(head_a, head_b) is None

    def test_same_list(self):
        shared = build_list([1, 2, 3])
        assert self.sol.get_intersection_node(shared, shared) is shared

    def test_intersection_at_last_node(self):
        shared = ListNode(99)
        head_a = attach([1, 2, 3], shared)
        head_b = attach([7, 8], shared)
        assert self.sol.get_intersection_node(head_a, head_b) is shared

    def test_one_empty(self):
        head_a = build_list([1, 2, 3])
        assert self.sol.get_intersection_node(head_a, None) is None

    def test_same_values_no_intersection(self):
        head_a = build_list([1, 2, 3])
        head_b = build_list([1, 2, 3])
        assert self.sol.get_intersection_node(head_a, head_b) is None
