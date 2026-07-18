# 286. Walls and Gates
# https://leetcode.com/problems/walls-and-gates/
#
# You are given an m x n grid rooms initialized with these three possible values:
# - -1: A wall or an obstacle.
# - 0: A gate.
# - INF (2147483647): An empty room.
# Fill each empty room with the distance to its nearest gate. If it is impossible
# to reach a gate, leave it as INF.
#
# Example 1:
#   Input: rooms = [[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],
#                   [2147483647,-1,2147483647,-1],[0,-1,2147483647,2147483647]]
#   Output: [[3,-1,0,1],[2,2,1,-1],[1,-1,2,-1],[0,-1,3,4]]
# Example 2: Input: rooms = [[-1]] Output: [[-1]]
#
# Constraints:
# - m == rooms.length, n == rooms[i].length
# - 1 <= m, n <= 250
# - rooms[i][j] is -1, 0, or 2147483647.


class WallsAndGates:
    def walls_and_gates(self, rooms: list[list[int]]) -> None:
        pass
