using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class ConvertBSTClass
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        int sum = 0;

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null) return null;
            ConvertBST(root.right);
            root.val += sum;
            sum = root.val;
            ConvertBST(root.left);
            return root;
        }

        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode ConvertBST2(TreeNode root)
        {
            if (root == null) return null;
            var stack = new Stack<TreeNode>();
            var node = root;
            while (node != null || stack.Any())
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.right;
                }
                node = stack.Pop();
                node.val += sum;
                sum = node.val;
                node = node.left;
            }
            return root;
        }
    }
}
