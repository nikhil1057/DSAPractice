from solutions import ListNode, build_list
from solutions.linked_list_cycle import LinkedListCycle


def build_cycle_list(values: list[int], pos: int) -> ListNode | None:
    """Build list with cycle. pos = index where tail connects to. -1 means no cycle."""
    if not values:
        return None
    head = build_list(values)
    if pos == -1:
        return head
    # Find tail and the node at pos
    tail = head
    cycle_node = head
    for i in range(len(values) - 1):
        tail = tail.next
    for i in range(pos):
        cycle_node = cycle_node.next
    tail.next = cycle_node
    return head


class TestLinkedListCycle:
    def setup_method(self):
        self.sol = LinkedListCycle()

    def test_example1(self):
        # [3,2,0,-4], pos=1 => cycle
        assert self.sol.has_cycle(build_cycle_list([3, 2, 0, -4], 1)) is True

    def test_example2(self):
        # [1,2], pos=0 => cycle
        assert self.sol.has_cycle(build_cycle_list([1, 2], 0)) is True

    def test_example3(self):
        # [1], pos=-1 => no cycle
        assert self.sol.has_cycle(build_cycle_list([1], -1)) is False

    def test_empty(self):
        assert self.sol.has_cycle(None) is False

    def test_no_cycle(self):
        assert self.sol.has_cycle(build_list([1, 2, 3, 4, 5])) is False

    def test_cycle_at_head(self):
        # Single node pointing to itself
        node = ListNode(1)
        node.next = node
        assert self.sol.has_cycle(node) is True

    def test_cycle_at_tail(self):
        assert self.sol.has_cycle(build_cycle_list([1, 2, 3, 4], 3)) is True
