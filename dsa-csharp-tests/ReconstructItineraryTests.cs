public class ReconstructItineraryTests
{
    [Fact]
    public void Example1()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "MUC", "LHR" },
            new List<string> { "JFK", "MUC" },
            new List<string> { "SFO", "SJC" },
            new List<string> { "LHR", "SFO" }
        };
        var expected = new List<string> { "JFK", "MUC", "LHR", "SFO", "SJC" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }

    [Fact]
    public void Example2()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "JFK", "SFO" },
            new List<string> { "JFK", "ATL" },
            new List<string> { "SFO", "ATL" },
            new List<string> { "ATL", "JFK" },
            new List<string> { "ATL", "SFO" }
        };
        var expected = new List<string> { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }

    [Fact]
    public void SingleTicket()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "JFK", "ATL" }
        };
        var expected = new List<string> { "JFK", "ATL" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }

    [Fact]
    public void LexicalOrder()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "JFK", "ZZZ" },
            new List<string> { "JFK", "AAA" },
            new List<string> { "AAA", "JFK" }
        };
        var expected = new List<string> { "JFK", "AAA", "JFK", "ZZZ" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }

    [Fact]
    public void Circular()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "JFK", "A" },
            new List<string> { "A", "JFK" }
        };
        var expected = new List<string> { "JFK", "A", "JFK" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }

    [Fact]
    public void MultipleSameDestination()
    {
        IList<IList<string>> tickets = new List<IList<string>>
        {
            new List<string> { "JFK", "ATL" },
            new List<string> { "ATL", "JFK" },
            new List<string> { "JFK", "ATL" }
        };
        var expected = new List<string> { "JFK", "ATL", "JFK", "ATL" };
        Assert.Equal(expected, new ReconstructItinerary().FindItinerary(tickets));
    }
}
