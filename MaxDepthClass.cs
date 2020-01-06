using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class MaxDepthClass
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        /// <summary>
        /// 深度优先搜索，递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }

        /// <summary>
        /// 广度优先搜索，迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepthBFS(TreeNode root)
        {
            if (root == null) return 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var count = 0;
            while (queue.Any())
            {
                count++;
                var length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    var current = queue.Dequeue();
                    if (current.left != null) queue.Enqueue(current.left);
                    if (current.right != null) queue.Enqueue(current.right);
                }
            }
            return count;
        }

        /// <summary>
        /// 深度优先搜索，迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepthDFS(TreeNode root)
        {
            if (root == null) return 0;
            var stack = new Stack<Tuple<TreeNode, int>>();
            var depth = 0;
            stack.Push(new Tuple<TreeNode, int>(root, 1));
            while (stack.Any())
            {
                var current = stack.Pop();
                depth = Math.Max(depth, current.Item2);
                if (current.Item1.right != null) stack.Push(new Tuple<TreeNode, int>(current.Item1.right, current.Item2 + 1));
                if (current.Item1.left != null) stack.Push(new Tuple<TreeNode, int>(current.Item1.left, current.Item2 + 1));
            }
            return depth;
        }
    }
}
