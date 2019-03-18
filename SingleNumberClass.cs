using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class SingleNumberClass
    {
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            if (nums.Any())
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result ^= nums[i];
                }
            }
            return result;
        }
    }
}
