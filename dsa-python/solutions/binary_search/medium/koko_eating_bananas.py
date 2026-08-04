# 875. Koko Eating Bananas
# https://leetcode.com/problems/koko-eating-bananas/
#
# Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas.
# The guards have gone and will come back in h hours.
# Koko can decide her bananas-per-hour eating speed of k.
# Return the minimum integer k such that she can eat all the bananas within h hours.
#
# APPROACH: Binary search on the answer (eating speed k).
#
# Think of it like this:
# Koko is trying different eating speeds. She starts guessing in the middle.
# "Can I finish all bananas at speed 6?" → Count the hours. Yes? Try eating slower.
# "Can I finish at speed 3?" → Count the hours. No? Eat faster.
# Keep guessing in the middle until you find the SLOWEST speed that still works.
#
# WHY BINARY SEARCH?
# The answer (speed k) is somewhere between 1 and max(piles).
# That's a sorted range — slow speeds fail, fast speeds work.
# Binary search finds the boundary between "too slow" and "fast enough".
#
# HOW DO WE COUNT HOURS?
# For each pile: hours = ceil(pile / k)
# If pile = 7 and k = 4: she eats 4, then 3 → 2 hours = ceil(7/4)
# Ceiling trick without decimals: (pile + k - 1) // k
#
# WHY right = k (not k-1)?
# Because k WORKS! It might be the answer. Don't throw it away.
# We keep it and try to find something even slower.
#
# TIME: O(n * log(max(piles))) — binary search over speeds, linear check each
# SPACE: O(1) — constant extra space


class KokoEatingBananas:
    def min_eating_speed(self, piles: list[int], h: int) -> int:
        # Slowest possible speed: 1 banana/hour
        # Fastest needed speed: max(piles) — eat the biggest pile in one hour
        left = 1
        right = max(piles)

        while left < right:
            k = left + (right - left) // 2  # try this speed

            # Count how many hours Koko needs at speed k
            hours = sum((pile + k - 1) // k for pile in piles)  # ceil(pile / k)

            if hours <= h:
                right = k      # fast enough! but maybe slower works too — keep k, try left
            else:
                left = k + 1   # too slow! need to eat faster — move right

        # left == right — they met at the minimum speed that works
        return left
