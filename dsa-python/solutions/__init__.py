class ListNode:
    def __init__(self, val: int = 0, next: "ListNode | None" = None):
        self.val = val
        self.next = next


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
