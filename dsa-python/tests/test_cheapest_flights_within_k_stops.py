from solutions.advanced_graphs.medium.cheapest_flights_within_k_stops import CheapestFlightsWithinKStops


class TestCheapestFlightsWithinKStops:
    def setup_method(self):
        self.sol = CheapestFlightsWithinKStops()

    def test_example1(self):
        n = 4
        flights = [[0, 1, 100], [1, 2, 100], [2, 0, 100], [1, 3, 600], [2, 3, 200]]
        assert self.sol.find_cheapest_price(n, flights, 0, 3, 1) == 700

    def test_example2(self):
        n = 3
        flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]]
        assert self.sol.find_cheapest_price(n, flights, 0, 2, 1) == 200

    def test_example3(self):
        n = 3
        flights = [[0, 1, 100], [1, 2, 100], [0, 2, 500]]
        assert self.sol.find_cheapest_price(n, flights, 0, 2, 0) == 500

    def test_no_route(self):
        n = 3
        flights = [[0, 1, 100]]
        assert self.sol.find_cheapest_price(n, flights, 0, 2, 1) == -1

    def test_direct_flight(self):
        n = 2
        flights = [[0, 1, 50]]
        assert self.sol.find_cheapest_price(n, flights, 0, 1, 0) == 50

    def test_k_too_small(self):
        n = 4
        flights = [[0, 1, 1], [1, 2, 1], [2, 3, 1]]
        assert self.sol.find_cheapest_price(n, flights, 0, 3, 1) == -1

    def test_same_src_dst(self):
        n = 3
        flights = [[0, 1, 100], [1, 2, 100]]
        assert self.sol.find_cheapest_price(n, flights, 0, 0, 0) == 0
