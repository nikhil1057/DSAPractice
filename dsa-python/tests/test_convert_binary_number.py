from solutions import build_list
from solutions.linked_list.easy.convert_binary_number_in_linked_list import ConvertBinaryNumberInLinkedList


class TestConvertBinaryNumberInLinkedList:
    def setup_method(self):
        self.sol = ConvertBinaryNumberInLinkedList()

    def test_example1(self):
        # 1->0->1 = 5
        assert self.sol.get_decimal_value(build_list([1, 0, 1])) == 5

    def test_example2(self):
        # 0 = 0
        assert self.sol.get_decimal_value(build_list([0])) == 0

    def test_example3(self):
        # 1 = 1
        assert self.sol.get_decimal_value(build_list([1])) == 1

    def test_all_ones(self):
        # 1->1->1->1 = 15
        assert self.sol.get_decimal_value(build_list([1, 1, 1, 1])) == 15

    def test_leading_zeros(self):
        # 0->0->1 = 1
        assert self.sol.get_decimal_value(build_list([0, 0, 1])) == 1

    def test_larger_number(self):
        # 1->0->0->1->0 = 18
        assert self.sol.get_decimal_value(build_list([1, 0, 0, 1, 0])) == 18
