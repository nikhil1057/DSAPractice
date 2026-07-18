from solutions.linked_list.medium.copy_list_with_random_pointer import CopyListWithRandomPointer, Node


class TestCopyListWithRandomPointer:
    def setup_method(self):
        self.sol = CopyListWithRandomPointer()

    def _build_list(self, values, random_indices):
        """Build a list with random pointers. random_indices[i] is the index of the random pointer for node i."""
        if not values:
            return None
        nodes = [Node(v) for v in values]
        for i in range(len(nodes) - 1):
            nodes[i].next = nodes[i + 1]
        for i, idx in enumerate(random_indices):
            nodes[i].random = nodes[idx] if idx is not None else None
        return nodes[0]

    def _to_values_and_randoms(self, head):
        """Convert list to (values, random_indices) for verification."""
        nodes = []
        curr = head
        while curr:
            nodes.append(curr)
            curr = curr.next
        values = [n.val for n in nodes]
        random_indices = []
        for n in nodes:
            if n.random is None:
                random_indices.append(None)
            else:
                random_indices.append(nodes.index(n.random))
        return values, random_indices

    def test_example1(self):
        # [[7,null],[13,0],[11,4],[10,2],[1,0]]
        head = self._build_list([7, 13, 11, 10, 1], [None, 0, 4, 2, 0])
        copy = self.sol.copy_random_list(head)
        values, randoms = self._to_values_and_randoms(copy)
        assert values == [7, 13, 11, 10, 1]
        assert randoms == [None, 0, 4, 2, 0]

    def test_example2(self):
        # [[1,1],[2,1]]
        head = self._build_list([1, 2], [1, 1])
        copy = self.sol.copy_random_list(head)
        values, randoms = self._to_values_and_randoms(copy)
        assert values == [1, 2]
        assert randoms == [1, 1]

    def test_example3(self):
        # [[3,null],[3,0],[3,null]]
        head = self._build_list([3, 3, 3], [None, 0, None])
        copy = self.sol.copy_random_list(head)
        values, randoms = self._to_values_and_randoms(copy)
        assert values == [3, 3, 3]
        assert randoms == [None, 0, None]

    def test_empty_list(self):
        assert self.sol.copy_random_list(None) is None

    def test_single_node_self_random(self):
        node = Node(1)
        node.random = node
        copy = self.sol.copy_random_list(node)
        assert copy.val == 1
        assert copy.random is copy
        assert copy is not node

    def test_deep_copy_is_independent(self):
        head = self._build_list([1, 2], [None, 0])
        copy = self.sol.copy_random_list(head)
        # Verify it's a deep copy (different objects)
        assert copy is not head
        assert copy.next is not head.next
