from solutions.greedy.medium.valid_parenthesis_string import ValidParenthesisString


class TestValidParenthesisString:
    def setup_method(self):
        self.sol = ValidParenthesisString()

    def test_example1(self):
        assert self.sol.check_valid_string("()") is True

    def test_example2(self):
        assert self.sol.check_valid_string("(*)") is True

    def test_example3(self):
        assert self.sol.check_valid_string("(*))") is True

    def test_unbalanced(self):
        assert self.sol.check_valid_string("((") is False

    def test_star_as_empty(self):
        assert self.sol.check_valid_string("*") is True

    def test_star_as_open(self):
        assert self.sol.check_valid_string("*)") is True

    def test_star_as_close(self):
        assert self.sol.check_valid_string("(*") is True

    def test_complex_invalid(self):
        assert self.sol.check_valid_string(")*(") is False

    def test_all_stars(self):
        assert self.sol.check_valid_string("***") is True
