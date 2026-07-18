from collections import deque


class ListNode:
    def __init__(self, val: int = 0, next: "ListNode | None" = None):
        self.val = val
        self.next = next


class TreeNode:
    def __init__(self, val: int = 0, left: "TreeNode | None" = None, right: "TreeNode | None" = None):
        self.val = val
        self.left = left
        self.right = right


def build_list(values: list[int]) -> ListNode | None:
    if not values:
        return None
    head = ListNode(values[0])
    current = head
    for v in values[1:]:
        current.next = ListNode(v)
        current = current.next
    return head


def to_array(head: ListNode | None) -> list[int]:
    result = []
    while head:
        result.append(head.val)
        head = head.next
    return result


def build_tree(values: list[int | None] | None) -> TreeNode | None:
    """Build a binary tree from a level-order list (None represents null nodes)."""
    if not values or values[0] is None:
        return None
    root = TreeNode(values[0])
    queue = deque([root])
    i = 1
    while queue and i < len(values):
        node = queue.popleft()
        if i < len(values) and values[i] is not None:
            node.left = TreeNode(values[i])
            queue.append(node.left)
        i += 1
        if i < len(values) and values[i] is not None:
            node.right = TreeNode(values[i])
            queue.append(node.right)
        i += 1
    return root


def tree_to_list(root: TreeNode | None) -> list[int | None]:
    """Convert a binary tree to a level-order list."""
    if not root:
        return []
    result = []
    queue = deque([root])
    while queue:
        node = queue.popleft()
        if node:
            result.append(node.val)
            queue.append(node.left)
            queue.append(node.right)
        else:
            result.append(None)
    # Remove trailing Nones
    while result and result[-1] is None:
        result.pop()
    return result
