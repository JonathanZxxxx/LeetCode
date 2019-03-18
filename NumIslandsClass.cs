using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class NumIslandsClass
    {
        public int NumIslands(char[,] grid)
        {
            if (grid.Length == 0) return 0;
            var result = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        result++;
                        ToTwo(grid, i, j);
                    }
                }
            }
            return result;
        }

        private void ToTwo(char[,] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.GetLength(0) || j >= grid.GetLength(1) || grid[i, j] != '1')
            {
                return;
            }
            grid[i, j] = '2';
            ToTwo(grid, i, j + 1);
            ToTwo(grid, i, j - 1);
            ToTwo(grid, i - 1, j);
            ToTwo(grid, i + 1, j);
        }
    }
}
