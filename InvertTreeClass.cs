using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class InvertTreeClass
    {
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            var left = InvertTree(root.right);
            var right = InvertTree(root.left);
            root.left = left;
            root.right = right;
            return root;
        }

        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree2(TreeNode root)
        {
            if (root == null) return null;
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Any())
            {
                var pop = stack.Pop();
                var temp = pop.left;
                pop.left = pop.right;
                pop.right = temp;
                if (pop.left != null) stack.Push(pop.left);
                if (pop.right != null) stack.Push(pop.right);
            }
            return root;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
