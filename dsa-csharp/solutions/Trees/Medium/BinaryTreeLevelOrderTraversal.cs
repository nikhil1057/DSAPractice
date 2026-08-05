// 102. Binary Tree Level Order Traversal
// https://leetcode.com/problems/binary-tree-level-order-traversal/
//
// Given the root of a binary tree, return the level order traversal of its
// nodes' values (i.e., from left to right, level by level).
//
// APPROACH: BFS with queue. Process nodes level by level using levelSize = queue.Count at start of each iteration.
//
// TIME: O(n)
// SPACE: O(n)

public class BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode? root)
    {
        List<IList<int>> result = new();

        if(root == null) return result;

        Queue<TreeNode?> queue = new();

        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> level = new();

            for(int i = 0; i< levelSize; i++)
            {
                TreeNode? node = queue.Dequeue();

                level.Add(node.val);

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }

            result.Add(level);
        }

        return result;
    }
}
