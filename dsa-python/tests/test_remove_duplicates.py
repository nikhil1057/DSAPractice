import pytest
from solutions import build_list, to_array
from solutions.linked_list.easy.remove_duplicates_from_sorted_list import (
    RemoveDuplicatesFromSortedList,
    RemoveDuplicatesFromSortedListII,
)


class TestQ83:
    def setup_method(self):
        self.sol = RemoveDuplicatesFromSortedList()

    def test_example1(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 1, 2]))) == [1, 2]

    def test_example2(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 1, 2, 3, 3]))) == [1, 2, 3]

    def test_empty(self):
        assert self.sol.delete_duplicates(None) is None

    def test_single(self):
        assert to_array(self.sol.delete_duplicates(build_list([1]))) == [1]

    def test_all_same(self):
        assert to_array(self.sol.delete_duplicates(build_list([5, 5, 5, 5]))) == [5]

    def test_no_duplicates(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 2, 3]))) == [1, 2, 3]


class TestQ82:
    def setup_method(self):
        self.sol = RemoveDuplicatesFromSortedListII()

    def test_example1(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 2, 3, 3, 4, 4, 5]))) == [1, 2, 5]

    def test_example2(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 1, 1, 2, 3]))) == [2, 3]

    def test_empty(self):
        assert self.sol.delete_duplicates(None) is None

    def test_single(self):
        assert to_array(self.sol.delete_duplicates(build_list([1]))) == [1]

    def test_all_duplicates(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 1, 2, 2, 3, 3]))) == []

    def test_no_duplicates(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 2, 3]))) == [1, 2, 3]

    def test_duplicates_at_end(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 2, 3, 3]))) == [1, 2]

    def test_duplicates_at_start(self):
        assert to_array(self.sol.delete_duplicates(build_list([1, 1, 2, 3]))) == [2, 3]
