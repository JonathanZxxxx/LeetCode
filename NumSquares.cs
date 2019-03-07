using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class NumSquaresClass
    {
        /// <summary>
        /// 动态规划实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                dp[i] = n;
            }
            for (int i = 1; i <= n; i++)
            {
                int j = 1;
                while (i - j * j >= 0)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                    j++;
                }
            }
            return dp[n];
        }

        /// <summary>
        /// 四平方和定理实现
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumSquares2(int n)
        {
            while (n % 4 == 0)
            {
                n /= 4;
            }
            if (n % 8 == 7)
            {
                return 4;
            }
            for (int i = 0; i * i <= n; i++)
            {
                int r = (int)Math.Sqrt(n - i * i); if (i * i + r * r == n)
                {
                    if (i == 0 || r == 0) return 1;
                    return 2;
                }
            }
            return 3;
        }
    }
}
