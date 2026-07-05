from solutions import build_list, to_array
from solutions.linked_list.medium.add_two_numbers import AddTwoNumbers


class TestAddTwoNumbers:
    def setup_method(self):
        self.sol = AddTwoNumbers()

    def test_example1(self):
        # 342 + 465 = 807 => [2,4,3] + [5,6,4] => [7,0,8]
        result = self.sol.add_two_numbers(build_list([2, 4, 3]), build_list([5, 6, 4]))
        assert to_array(result) == [7, 0, 8]

    def test_example2(self):
        # 0 + 0 = 0
        result = self.sol.add_two_numbers(build_list([0]), build_list([0]))
        assert to_array(result) == [0]

    def test_example3(self):
        # 9999999 + 9999 = 10009998
        result = self.sol.add_two_numbers(
            build_list([9, 9, 9, 9, 9, 9, 9]), build_list([9, 9, 9, 9])
        )
        assert to_array(result) == [8, 9, 9, 9, 0, 0, 0, 1]

    def test_different_lengths(self):
        # 99 + 1 = 100 => [9,9] + [1] => [0,0,1]
        result = self.sol.add_two_numbers(build_list([9, 9]), build_list([1]))
        assert to_array(result) == [0, 0, 1]

    def test_no_carry(self):
        # 123 + 456 = 579 => [3,2,1] + [6,5,4] => [9,7,5]
        result = self.sol.add_two_numbers(build_list([3, 2, 1]), build_list([6, 5, 4]))
        assert to_array(result) == [9, 7, 5]

    def test_single_digit_with_carry(self):
        # 5 + 5 = 10 => [5] + [5] => [0,1]
        result = self.sol.add_two_numbers(build_list([5]), build_list([5]))
        assert to_array(result) == [0, 1]
