from solutions.stack.easy.valid_parentheses import ValidParentheses


class TestValidParentheses:
    def setup_method(self):
        self.sol = ValidParentheses()

    def test_example1(self):
        # "()" → True
        assert self.sol.is_valid("()") is True

    def test_example2(self):
        # "()[]{}" → True
        assert self.sol.is_valid("()[]{}") is True

    def test_example3(self):
        # "(]" → False
        assert self.sol.is_valid("(]") is False

    def test_nested_valid(self):
        # "{[]}" → True
        assert self.sol.is_valid("{[]}") is True

    def test_single_open(self):
        # "(" → False
        assert self.sol.is_valid("(") is False

    def test_single_close(self):
        # ")" → False
        assert self.sol.is_valid(")") is False

    def test_complex_valid(self):
        # "([{}])()" → True
        assert self.sol.is_valid("([{}])()") is True

    def test_wrong_order(self):
        # "([)]" → False
        assert self.sol.is_valid("([)]") is False
