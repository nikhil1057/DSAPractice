"""DSA Practice - Python"""


def two_sum(nums: list[int], target: int) -> list[int]:
    """Example: LeetCode #1 - Two Sum"""
    seen: dict[int, int] = {}
    for i, num in enumerate(nums):
        complement = target - num
        if complement in seen:
            return [seen[complement], i]
        seen[num] = i
    return []


if __name__ == "__main__":
    print(two_sum([2, 7, 11, 15], 9))
