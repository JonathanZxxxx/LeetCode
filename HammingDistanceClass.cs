using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class HammingDistanceClass
    {
        public int HammingDistance(int x, int y)
        {
            var result = x ^ y;//二进制异或运算
            var count = 0;
            while (result > 0)
            {
                if ((result & 1) == 1)//二进制与操作
                {
                    count++;
                }
                result = result >> 1;//位右移操作
            }
            return count;
        }
    }
}
