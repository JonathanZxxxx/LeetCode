using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class DailyTemperaturesClass
    {
        public int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];
            var stack = new Stack<int>();
            for (int i = 0; i < T.Length; i++)
            {
                while (stack.Any() && T[i] > T[stack.Peek()])
                {
                    result[stack.Peek()] = i - stack.Peek();
                    stack.Pop();
                }
                stack.Push(i);
            }
            return result;
        }
    }
}
