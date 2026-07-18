from solutions.advanced_graphs.hard.reconstruct_itinerary import ReconstructItinerary


class TestReconstructItinerary:
    def setup_method(self):
        self.sol = ReconstructItinerary()

    def test_example1(self):
        tickets = [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "MUC", "LHR", "SFO", "SJC"]

    def test_example2(self):
        tickets = [["JFK", "SFO"], ["JFK", "ATL"], ["SFO", "ATL"], ["ATL", "JFK"], ["ATL", "SFO"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "ATL", "JFK", "SFO", "ATL", "SFO"]

    def test_single_ticket(self):
        tickets = [["JFK", "ATL"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "ATL"]

    def test_lexical_order(self):
        tickets = [["JFK", "ZZZ"], ["JFK", "AAA"], ["AAA", "JFK"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "AAA", "JFK", "ZZZ"]

    def test_circular(self):
        tickets = [["JFK", "A"], ["A", "JFK"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "A", "JFK"]

    def test_multiple_same_destination(self):
        tickets = [["JFK", "ATL"], ["ATL", "JFK"], ["JFK", "ATL"]]
        assert self.sol.find_itinerary(tickets) == ["JFK", "ATL", "JFK", "ATL"]
