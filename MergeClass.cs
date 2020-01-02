using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class MergeClass
    {
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            if (t2 == null)
            {
                return t1;
            }
            t1.val += t2.val;
            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);
            return t1;
        }

        /// <summary>
        /// 栈迭代
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees2(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            var stack = new Stack<TreeNode[]>();
            stack.Push(new TreeNode[] { t1, t2 });
            while (stack.Any())
            {
                var pop = stack.Pop();
                if (pop[0] == null || pop[1] == null)
                {
                    continue;
                }
                pop[0].val += pop[1].val;
                if (pop[0].left == null)
                {
                    pop[0].left = pop[1].left;
                }
                else
                {
                    stack.Push(new TreeNode[] { pop[0].left, pop[1].left });
                }
                if (pop[0].right == null)
                {
                    pop[0].right = pop[1].right;
                }
                else
                {
                    stack.Push(new TreeNode[] { pop[0].right, pop[1].right });
                }
            }
            return t1;
        }

        /// <summary>
        /// 队列迭代
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public TreeNode MergeTrees3(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            var queue = new Queue<TreeNode[]>();
            queue.Enqueue(new TreeNode[] { t1, t2 });
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current[0] == null || current[1] == null)
                {
                    continue;
                }
                current[0].val += current[1].val;
                if (current[0].left == null)
                {
                    current[0].left = current[1].left;
                }
                else
                {
                    queue.Enqueue(new TreeNode[] { current[0].left, current[1].left });
                }
                if (current[0].right == null)
                {
                    current[0].right = current[1].right;
                }
                else
                {
                    queue.Enqueue(new TreeNode[] { current[0].right, current[1].right });
                }
            }
            return t1;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

    }
}
