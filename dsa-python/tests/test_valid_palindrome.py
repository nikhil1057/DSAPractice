from solutions.two_pointers.easy.valid_palindrome import ValidPalindrome


class TestValidPalindrome:
    def setup_method(self):
        self.sol = ValidPalindrome()

    def test_example1(self):
        # "A man, a plan, a canal: Panama" => true
        assert self.sol.is_palindrome("A man, a plan, a canal: Panama") is True

    def test_example2(self):
        # "race a car" => false
        assert self.sol.is_palindrome("race a car") is False

    def test_example3(self):
        # " " => true (empty after removing non-alphanumeric)
        assert self.sol.is_palindrome(" ") is True

    def test_empty_string(self):
        assert self.sol.is_palindrome("") is True

    def test_single_char(self):
        assert self.sol.is_palindrome("a") is True

    def test_numbers_only(self):
        assert self.sol.is_palindrome("12321") is True

    def test_mixed_case(self):
        assert self.sol.is_palindrome("Aa") is True

    def test_special_chars_only(self):
        assert self.sol.is_palindrome(".,!?") is True
