from solutions.graphs.medium.walls_and_gates import WallsAndGates


INF = 2147483647


class TestWallsAndGates:
    def setup_method(self):
        self.sol = WallsAndGates()

    def test_example1(self):
        rooms = [[INF, -1, 0, INF], [INF, INF, INF, -1], [INF, -1, INF, -1], [0, -1, INF, INF]]
        self.sol.walls_and_gates(rooms)
        expected = [[3, -1, 0, 1], [2, 2, 1, -1], [1, -1, 2, -1], [0, -1, 3, 4]]
        assert rooms == expected

    def test_single_wall(self):
        rooms = [[-1]]
        self.sol.walls_and_gates(rooms)
        assert rooms == [[-1]]

    def test_single_gate(self):
        rooms = [[0]]
        self.sol.walls_and_gates(rooms)
        assert rooms == [[0]]

    def test_all_empty(self):
        rooms = [[INF, INF], [INF, INF]]
        self.sol.walls_and_gates(rooms)
        # No gates, so all remain INF
        assert rooms == [[INF, INF], [INF, INF]]

    def test_gate_surrounded_by_rooms(self):
        rooms = [[INF, INF, INF], [INF, 0, INF], [INF, INF, INF]]
        self.sol.walls_and_gates(rooms)
        expected = [[2, 1, 2], [1, 0, 1], [2, 1, 2]]
        assert rooms == expected

    def test_unreachable_room(self):
        rooms = [[INF, -1], [-1, 0]]
        self.sol.walls_and_gates(rooms)
        expected = [[INF, -1], [-1, 0]]
        assert rooms == expected

    def test_multiple_gates(self):
        rooms = [[0, INF, INF], [INF, INF, INF], [INF, INF, 0]]
        self.sol.walls_and_gates(rooms)
        expected = [[0, 1, 2], [1, 2, 1], [2, 1, 0]]
        assert rooms == expected
