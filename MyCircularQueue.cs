using System.Collections.Generic;

namespace Async
{
    //代码实现
    public class MyCircularQueue
    {
        //保存数据
        private int[] data;
        //头指针
        private int head;
        //尾指针
        private int tail;
        //队列长度
        private int size;

        //初始化
        public MyCircularQueue(int k)
        {
            data = new int[k];
            head = tail = -1;
            size = k;
        }

        //插入
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            if (IsEmpty()) head = 0;
            tail = (tail + 1) % size;
            data[tail] = value;
            return true;
        }

        //删除
        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            if (head == tail)
            {
                head = tail = -1;
                return true;
            }
            head = (head + 1) % size;
            return true;
        }

        //返回头
        public int Front()
        {
            if (IsEmpty()) return -1;
            return data[head];
        }

        //返回尾
        public int Rear()
        {
            if (IsEmpty()) return -1;
            return data[tail];
        }

        //判断队列是否已满
        public bool IsFull()
        {
            return (tail + 1) % size == head;
        }

        //判断队列是否为空
        public bool IsEmpty()
        {
            return head == -1;
        }
    }

    //C# Queue队列用法
    public class QueueClass
    {
        //Queue队列就是先进先出。它并没有实现 IList，ICollection。所以它不能按索引访问元素，不能使用Add和Remove。下面是 Queue的一些方法和属性
        //Enqueue():在队列的末端添加元素
        //Dequeue():在队列的头部读取和删除一个元素，注意，这里读取元素的同时也删除了这个元素。如果队列中不再有任何元素。就抛出异常
        //Peek():在队列的头读取一个元素，但是不删除它
        //Count：返回队列中的元素个数
        //TrimExcess():重新设置队列的容量，因为调用Dequeue方法读取删除元素后不会重新设置队列的容量。
        //Contains():确定某个元素是否在队列中
        //CopyTo():把元素队列复制到一个已有的数组中
        //ToArray():返回一个包含元素的新数组
        public void QueueFunction()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            var q1 = queue.Peek();
            var q2 = queue.Count;
            var q3 = queue.Dequeue();
            var q4 = queue.Count;
            queue.TrimExcess();
            var q5 = queue.Count;
            var q6 = queue.Contains(2);
        }
    }
}
