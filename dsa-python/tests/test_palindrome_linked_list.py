from solutions import build_list
from solutions.linked_list.easy.palindrome_linked_list import PalindromeLinkedList


class TestPalindromeLinkedList:
    def setup_method(self):
        self.sol = PalindromeLinkedList()

    def test_example1(self):
        assert self.sol.is_palindrome(build_list([1, 2, 2, 1])) is True

    def test_example2(self):
        assert self.sol.is_palindrome(build_list([1, 2])) is False

    def test_single(self):
        assert self.sol.is_palindrome(build_list([1])) is True

    def test_odd_palindrome(self):
        assert self.sol.is_palindrome(build_list([1, 2, 1])) is True

    def test_odd_not_palindrome(self):
        assert self.sol.is_palindrome(build_list([1, 2, 3])) is False

    def test_all_same(self):
        assert self.sol.is_palindrome(build_list([1, 1, 1, 1])) is True

    def test_longer_palindrome(self):
        assert self.sol.is_palindrome(build_list([1, 2, 3, 2, 1])) is True
