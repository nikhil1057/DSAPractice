from solutions.backtracking.medium.letter_combinations_of_a_phone_number import LetterCombinationsOfAPhoneNumber


class TestLetterCombinationsOfAPhoneNumber:
    def setup_method(self):
        self.sol = LetterCombinationsOfAPhoneNumber()

    def test_example1(self):
        result = self.sol.letter_combinations("23")
        expected = ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]
        assert sorted(result) == sorted(expected)

    def test_example2(self):
        result = self.sol.letter_combinations("")
        assert result == []

    def test_example3(self):
        result = self.sol.letter_combinations("2")
        expected = ["a", "b", "c"]
        assert sorted(result) == sorted(expected)

    def test_digit_7(self):
        result = self.sol.letter_combinations("7")
        expected = ["p", "q", "r", "s"]
        assert sorted(result) == sorted(expected)

    def test_digit_9(self):
        result = self.sol.letter_combinations("9")
        expected = ["w", "x", "y", "z"]
        assert sorted(result) == sorted(expected)

    def test_three_digits(self):
        result = self.sol.letter_combinations("234")
        # 3 * 3 * 3 = 27 combinations
        assert len(result) == 27

    def test_four_letter_digit(self):
        result = self.sol.letter_combinations("79")
        # 4 * 4 = 16 combinations
        assert len(result) == 16
