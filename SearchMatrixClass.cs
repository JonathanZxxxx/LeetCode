namespace Async
{
    //二分查找
    public class SearchMatrixClass
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0) return false;
            //行
            var m = matrix.GetLength(0);
            //列
            var n = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                var left = 0;
                var right = n - 1;
                while (left <= right)
                {
                    var middle = (left + right) / 2;
                    if (matrix[i, middle] == target) return true;
                    if (matrix[i, middle] < target) left = middle + 1;
                    else right = middle - 1;
                }
            }
            return false;
        }

        //分治法
        public bool SearchMatrix2(int[,] matrix, int target)
        {
            if (matrix.Length == 0) return false;
            //行
            var m = matrix.GetLength(0);
            //列
            var n = matrix.GetLength(1);
            var i = 0;
            var j = n - 1;
            while (j >= 0 && i < m)
            {
                if (matrix[i, j] == target) return true;
                if (matrix[i, j] > target) j--;
                else i++;
            }
            return false;
        }
    }
}
