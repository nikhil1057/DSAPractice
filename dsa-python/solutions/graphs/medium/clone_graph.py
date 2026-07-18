# 133. Clone Graph
# https://leetcode.com/problems/clone-graph/
#
# Given a reference of a node in a connected undirected graph.
# Return a deep copy (clone) of the graph.
# Each node in the graph contains a value (int) and a list of its neighbors.
#
# class Node:
#     def __init__(self, val=0, neighbors=None):
#         self.val = val
#         self.neighbors = neighbors if neighbors is not None else []
#
# Example 1: Input: adjList = [[2,4],[1,3],[2,4],[1,3]] Output: [[2,4],[1,3],[2,4],[1,3]]
# Example 2: Input: adjList = [[]] Output: [[]]
# Example 3: Input: adjList = [] Output: []
#
# Constraints:
# - The number of nodes in the graph is in the range [0, 100].
# - 1 <= Node.val <= 100
# - Node.val is unique for each node.
# - There are no repeated edges and no self-loops in the graph.
# - The Graph is connected and all nodes can be visited starting from the given node.


class Node:
    def __init__(self, val=0, neighbors=None):
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []


class CloneGraph:
    def clone_graph(self, node: "Node | None") -> "Node | None":
        pass
