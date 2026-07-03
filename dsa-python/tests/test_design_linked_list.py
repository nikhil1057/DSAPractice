import pytest
from solutions.design_linked_list import MyLinkedList


class TestDesignLinkedList:
    def test_example1(self):
        ll = MyLinkedList()
        ll.add_at_head(1)
        ll.add_at_tail(3)
        ll.add_at_index(1, 2)  # 1->2->3
        assert ll.get(1) == 2
        ll.delete_at_index(1)  # 1->3
        assert ll.get(1) == 3

    def test_get_empty(self):
        ll = MyLinkedList()
        assert ll.get(0) == -1

    def test_get_invalid_index(self):
        ll = MyLinkedList()
        ll.add_at_head(1)
        assert ll.get(5) == -1

    def test_add_at_head_multiple(self):
        ll = MyLinkedList()
        ll.add_at_head(3)
        ll.add_at_head(2)
        ll.add_at_head(1)
        assert ll.get(0) == 1
        assert ll.get(1) == 2
        assert ll.get(2) == 3

    def test_add_at_tail_multiple(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.add_at_tail(3)
        assert ll.get(0) == 1
        assert ll.get(1) == 2
        assert ll.get(2) == 3

    def test_add_at_index_beginning(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(3)
        ll.add_at_index(0, 0)  # 0->1->3
        assert ll.get(0) == 0
        assert ll.get(1) == 1

    def test_add_at_index_end(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.add_at_index(2, 3)  # 1->2->3
        assert ll.get(2) == 3

    def test_add_at_index_invalid(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_index(5, 99)
        assert ll.get(1) == -1

    def test_add_at_index_middle(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.add_at_tail(4)
        ll.add_at_index(2, 3)  # 1->2->3->4
        assert ll.get(2) == 3
        assert ll.get(3) == 4

    def test_delete_at_index_head(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.delete_at_index(0)
        assert ll.get(0) == 2

    def test_delete_at_index_tail(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.add_at_tail(3)
        ll.delete_at_index(2)
        assert ll.get(2) == -1
        assert ll.get(1) == 2

    def test_delete_at_index_middle(self):
        ll = MyLinkedList()
        ll.add_at_tail(1)
        ll.add_at_tail(2)
        ll.add_at_tail(3)
        ll.add_at_tail(4)
        ll.delete_at_index(2)  # 1->2->4
        assert ll.get(2) == 4
