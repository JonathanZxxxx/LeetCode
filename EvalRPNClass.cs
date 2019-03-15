using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class EvalRPNClass
    {
        public int EvalRPN(string[] tokens)
        {
            var value = new Stack<int>();
            foreach (var s in tokens)
            {
                if (s != "+" && s != "-" && s != "*" && s != "/")
                {
                    value.Push(Convert.ToInt32(s));
                    continue;
                }
                var a = value.Pop();
                var b = value.Pop();
                switch (s)
                {
                    case "+": value.Push(b + a); break;
                    case "-": value.Push(b - a); break;
                    case "*": value.Push(b * a); break;
                    case "/": value.Push(b / a); break;
                    default: break;
                }
            }
            return value.Pop();
        }
    }
}
