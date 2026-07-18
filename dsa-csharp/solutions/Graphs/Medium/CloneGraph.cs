// 133. Clone Graph
// https://leetcode.com/problems/clone-graph/
//
// Given a reference of a node in a connected undirected graph.
// Return a deep copy (clone) of the graph.
// Each node in the graph contains a value (int) and a list of its neighbors.
//
// Example 1: Input: adjList = [[2,4],[1,3],[2,4],[1,3]] Output: [[2,4],[1,3],[2,4],[1,3]]
// Example 2: Input: adjList = [[]] Output: [[]]
// Example 3: Input: adjList = [] Output: []
//
// Constraints:
// - The number of nodes in the graph is in the range [0, 100].
// - 1 <= Node.val <= 100
// - Node.val is unique for each node.

public class GraphNode
{
    public int val;
    public IList<GraphNode> neighbors;

    public GraphNode(int _val = 0, IList<GraphNode>? _neighbors = null)
    {
        val = _val;
        neighbors = _neighbors ?? new List<GraphNode>();
    }
}

public class CloneGraph
{
    public GraphNode? CloneGraphSolve(GraphNode? node)
    {
        throw new NotImplementedException();
    }
}
