using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class MajorityElementClass
    {
        public int MajorityElement(int[] nums)
        {
            var count = 1;
            var result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (result == nums[i]) count++;
                else
                {
                    count--;
                    if (count == 0) result = nums[i + 1];
                }
            }
            return result;
        }
    }
}
