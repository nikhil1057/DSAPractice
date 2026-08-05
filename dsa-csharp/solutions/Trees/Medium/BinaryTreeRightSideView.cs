// 199. Binary Tree Right Side View
// https://leetcode.com/problems/binary-tree-right-side-view/
//
// Given the root of a binary tree, imagine yourself standing on the right side
// of it, return the values of the nodes you can see ordered from top to bottom.
//
// APPROACH: BFS level by level (same as Level Order Traversal).
// For each level, only the LAST node is visible from the right side.
//
// TIME: O(n) — visit every node once
// SPACE: O(n) — queue can hold up to n/2 nodes

public class BinaryTreeRightSideView
{
    public IList<int> RightSideView(TreeNode? root)
    {
        var result = new List<int>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();

                // Last node in this level = rightmost visible
                if(i == levelSize - 1)
                result.Add(node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return result;
    }
}
