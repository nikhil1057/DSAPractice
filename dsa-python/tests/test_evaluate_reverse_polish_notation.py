from solutions.stack.medium.evaluate_reverse_polish_notation import EvaluateReversePolishNotation


class TestEvaluateReversePolishNotation:
    def setup_method(self):
        self.sol = EvaluateReversePolishNotation()

    def test_example1(self):
        # ["2","1","+","3","*"] → ((2+1)*3) = 9
        assert self.sol.eval_rpn(["2", "1", "+", "3", "*"]) == 9

    def test_example2(self):
        # ["4","13","5","/","+"] → (4+(13/5)) = 6
        assert self.sol.eval_rpn(["4", "13", "5", "/", "+"]) == 6

    def test_example3(self):
        # ["10","6","9","3","+","-11","*","/","*","17","+","5","+"] → 22
        assert self.sol.eval_rpn(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]) == 22

    def test_single_number(self):
        assert self.sol.eval_rpn(["42"]) == 42

    def test_subtraction(self):
        # ["5","3","-"] → 2
        assert self.sol.eval_rpn(["5", "3", "-"]) == 2

    def test_division_truncates_toward_zero(self):
        # ["7","-3","/"] → -2 (truncate toward zero, not floor)
        assert self.sol.eval_rpn(["7", "-3", "/"]) == -2

    def test_negative_result(self):
        # ["3","5","-"] → -2
        assert self.sol.eval_rpn(["3", "5", "-"]) == -2

    def test_multiplication(self):
        # ["2","3","*"] → 6
        assert self.sol.eval_rpn(["2", "3", "*"]) == 6
