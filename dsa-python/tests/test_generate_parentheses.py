from solutions.backtracking.medium.generate_parentheses import GenerateParentheses


class TestGenerateParentheses:
    def setup_method(self):
        self.sol = GenerateParentheses()

    def test_example1(self):
        result = self.sol.generate_parenthesis(3)
        expected = ["((()))", "(()())", "(())()", "()(())", "()()()"]
        assert sorted(result) == sorted(expected)

    def test_example2(self):
        result = self.sol.generate_parenthesis(1)
        assert result == ["()"]

    def test_n_equals_2(self):
        result = self.sol.generate_parenthesis(2)
        expected = ["(())", "()()"]
        assert sorted(result) == sorted(expected)

    def test_n_equals_4(self):
        result = self.sol.generate_parenthesis(4)
        assert len(result) == 14  # Catalan number C(4) = 14

    def test_all_valid(self):
        result = self.sol.generate_parenthesis(3)
        for s in result:
            count = 0
            for c in s:
                count += 1 if c == '(' else -1
                assert count >= 0
            assert count == 0

    def test_no_duplicates(self):
        result = self.sol.generate_parenthesis(4)
        assert len(result) == len(set(result))
