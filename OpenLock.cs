using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Solution
    {
        public int OpenLock(string[] deadends, string target)
        {
            //搜索次数
            int step = 0;
            var deadEndsList = deadends.Distinct().ToDictionary(q => q, q => q);
            if (deadEndsList.ContainsKey("0000")) return -1;
            //队列
            var queue = new Queue<string>();
            //已尝试组合
            var usedList = new Dictionary<string, string>();
            queue.Enqueue("0000");
            usedList.Add("0000", "0000");
            while (queue.Any())
            {
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    //当前尝试密码
                    var current = queue.Peek();
                    if (current == target) return step;
                    var neighbor = GetNeighbor(current);
                    foreach (var n in neighbor)
                    {
                        if (!usedList.ContainsKey(n) && !deadEndsList.ContainsKey(n))
                        {
                            queue.Enqueue(n);
                            usedList.Add(n, n);
                        }
                    }
                    queue.Dequeue();
                }
                step += 1;
            }
            return -1;
        }

        //获取相邻的8个密码
        private List<string> GetNeighbor(string current)
        {
            var result = new List<string>();
            var value = new Dictionary<int, int>();
            for (int i = 0; i < current.Length; i++)
            {
                value.Add(i, Convert.ToInt32(current.Substring(i, 1)));
            }
            for (int i = 0; i < current.Length; i++)
            {
                var temp = GetAddSub(value[i]);
                result.Add(current.Substring(0, i) + temp[0] + current.Substring(i + 1, current.Length - i - 1));
                result.Add(current.Substring(0, i) + temp[1] + current.Substring(i + 1, current.Length - i - 1));
            }
            return result;
        }

        //获取当前数字加减后的数字
        private int[] GetAddSub(int value)
        {
            var add = value + 1;
            var sub = value - 1;
            if (add == 10) add = 0;
            if (sub == -1) sub = 9;
            return new int[] { add, sub };
        }
    }
}
