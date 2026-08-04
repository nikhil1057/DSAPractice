# 853. Car Fleet
# https://leetcode.com/problems/car-fleet/
#
# There are n cars going to the same destination along a one-lane road.
# The destination is target miles away. You are given two integer arrays position and speed,
# where position[i] is the position of the ith car and speed[i] is the speed of the ith car.
#
# A car can never pass another car ahead of it, but it can catch up and then travel at the
# same speed. A car fleet is some non-empty set of cars driving at the same position and speed.
# A single car is also a car fleet.
#
# Return the number of car fleets that will arrive at the destination.
#
# APPROACH: Sort cars by position descending (closest to target first).
# Calculate time to reach target for each car. If a car takes more time
# than the fleet ahead, it's a new fleet. If less/equal, it merges.
#
# TIME: O(n log n) — sorting dominates
# SPACE: O(n) — stack space (or O(1) with counter approach)


class CarFleet:
    def car_fleet(self, target: int, position: list[int], speed: list[int]) -> int:
        # Pair position with speed, sort by position descending (closest to target first)
        cars = sorted(zip(position, speed), reverse=True)

        # ========== APPROACH 1: Stack ==========
        stack = []

        for pos, spd in cars:
            time = (target - pos) / spd

            if not stack or time > stack[-1]:
                stack.append(time)  # new fleet — slower than fleet ahead
            # else: merges into fleet ahead, don't push

        return len(stack)

        # ========== APPROACH 2: Counter (no stack needed) ==========
        # fleets = 0
        # max_time = 0
        #
        # for pos, spd in cars:
        #     time = (target - pos) / spd
        #
        #     if time > max_time:
        #         fleets += 1       # new fleet — slower than everything ahead
        #         max_time = time
        #     # else: faster car, will merge into fleet ahead
        #
        # return fleets
