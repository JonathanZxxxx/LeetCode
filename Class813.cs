using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Class813
    {
        public double LargestSumOfAverages(int[] A, int K)
        {
            var sum = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                sum[i + 1] = sum[i] + A[i];
            }
            var dp = new double[A.Length + 1, K + 1];
            for (int i = 1; i <= A.Length; i++)
            {
                dp[i, 1] = (double)sum[i] / i;
                for (int k = 2; k <= K && k <= i; k++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        dp[i, k] = Math.Max(dp[i, k], dp[j, k - 1] + (double)(sum[i] - sum[j]) / (i - j));
                    }
                }
            }
            return dp[A.Length, K];
        }

        //public double LargestSumOfAverages2(int[] A, int K)
        //{
        //    var sum = new int[A.Length + 1];
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        sum[i + 1] = sum[i] + A[i];
        //    }
        //    var dp = new double[A.Length + 1];
        //    for (int i = 1; i < A.Length; i++)
        //    {
        //        dp[i] = (double)((sum[A.Length] - sum[i]) / (A.Length - i));
        //    }
        //    for (int k = 1; k <= K; k++)
        //    {
        //        for (int i = 1; i < A.Length; i++)
        //        {
        //            for (int j = i + 1; j < A.Length; j++)
        //            {
        //                dp[i] = Math.Max(dp[i], dp[j] + (double)((sum[j] - sum[i]) / (j - i)));
        //            }
        //        }
        //    }
        //    return dp[0];
        //}

        //public double largestSumOfAverages3(int[] A, int K)
        //{
        //    int N = A.Length;
        //    double[] P = new double[N + 1];
        //    for (int i = 0; i < N; ++i)
        //        P[i + 1] = P[i] + A[i];

        //    double[] dp = new double[N];
        //    for (int i = 0; i < N; ++i)
        //        dp[i] = (P[N] - P[i]) / (N - i);

        //    for (int k = 0; k < K - 1; ++k)
        //        for (int i = 0; i < N; ++i)
        //            for (int j = i + 1; j < N; ++j)
        //                dp[i] = Math.Max(dp[i], (P[j] - P[i]) / (j - i) + dp[j]);

        //    return dp[0];
        //}
    }
}
