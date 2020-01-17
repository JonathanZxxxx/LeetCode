using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class MoveZeroesClass
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;
            //非零个数
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //非零值移到当前指针位置
                if (nums[i] != 0)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            //当前指针位置后都为0
            for (int i = count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public void MoveZeroes2(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;
            var current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[current] = nums[i];
                    //num[i]值置0
                    if (current != i)
                    {
                        nums[i] = 0;
                    }
                    current++;
                }
            }
        }
    }
}
