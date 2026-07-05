from solutions import ListNode


# 169. Majority Element
# https://leetcode.com/problems/majority-element/
#
# APPROACH: Boyer-Moore Voting Algorithm
#
# KEY INSIGHT: The majority element appears > n/2 times. If we "cancel out"
# each majority occurrence with a non-majority one, the majority still survives.
#
# HOW IT WORKS:
# - When count == 0, pick current element as new candidate.
# - If current matches candidate → increment count (support).
# - If it doesn't match → decrement count (opposition cancels one support).
# - Majority always wins because it has more supporters than all opposition combined.
#
# ANALOGY: A battle between soldiers. Different elements meeting = both die.
# Since majority has > n/2 soldiers, they always have survivors at the end.
#
# TIME: O(n) — single pass
# SPACE: O(1) — just two variables

class MajorityElement:
    def majority_element(self, nums: list[int]) -> int:
        candidate = -1  # Current candidate for majority
        count = 0       # "Votes" for the current candidate

        for n in nums:
            # Count hit 0 → previous candidate was cancelled, pick new one
            if(count == 0): candidate = n
            # Same as candidate → gains a vote
            if(n == candidate): count += 1
            # Different → cancels one vote
            else: count -= 1

        # Candidate left standing is the majority (guaranteed to exist)
        return candidate
