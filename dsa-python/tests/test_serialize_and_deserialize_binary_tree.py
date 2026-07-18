from solutions import build_tree, tree_to_list
from solutions.trees.hard.serialize_and_deserialize_binary_tree import Codec


class TestSerializeAndDeserializeBinaryTree:
    def setup_method(self):
        self.codec = Codec()

    def test_example1(self):
        root = build_tree([1, 2, 3, None, None, 4, 5])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [1, 2, 3, None, None, 4, 5]

    def test_empty_tree(self):
        data = self.codec.serialize(None)
        result = self.codec.deserialize(data)
        assert result is None

    def test_single_node(self):
        root = build_tree([1])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [1]

    def test_left_skewed(self):
        root = build_tree([1, 2, None, 3])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [1, 2, None, 3]

    def test_right_skewed(self):
        root = build_tree([1, None, 2, None, 3])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [1, None, 2, None, 3]

    def test_complete_tree(self):
        root = build_tree([1, 2, 3, 4, 5, 6, 7])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [1, 2, 3, 4, 5, 6, 7]

    def test_negative_values(self):
        root = build_tree([-1, -2, -3])
        data = self.codec.serialize(root)
        result = self.codec.deserialize(data)
        assert tree_to_list(result) == [-1, -2, -3]
