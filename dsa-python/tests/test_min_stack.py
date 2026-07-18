from solutions.stack.medium.min_stack import MinStack


class TestMinStack:
    def setup_method(self):
        self.stack = MinStack()

    def test_example1(self):
        # LeetCode example
        self.stack.push(-2)
        self.stack.push(0)
        self.stack.push(-3)
        assert self.stack.get_min() == -3
        self.stack.pop()
        assert self.stack.top() == 0
        assert self.stack.get_min() == -2

    def test_single_element(self):
        self.stack.push(5)
        assert self.stack.top() == 5
        assert self.stack.get_min() == 5

    def test_push_pop_sequence(self):
        self.stack.push(1)
        self.stack.push(2)
        self.stack.push(3)
        self.stack.pop()
        assert self.stack.top() == 2
        assert self.stack.get_min() == 1

    def test_min_updates_after_pop(self):
        self.stack.push(3)
        self.stack.push(1)
        self.stack.push(2)
        assert self.stack.get_min() == 1
        self.stack.pop()
        assert self.stack.get_min() == 1
        self.stack.pop()
        assert self.stack.get_min() == 3

    def test_all_same_elements(self):
        self.stack.push(5)
        self.stack.push(5)
        self.stack.push(5)
        assert self.stack.get_min() == 5
        self.stack.pop()
        assert self.stack.get_min() == 5

    def test_negative_numbers(self):
        self.stack.push(-1)
        self.stack.push(-5)
        self.stack.push(-3)
        assert self.stack.get_min() == -5
        assert self.stack.top() == -3
