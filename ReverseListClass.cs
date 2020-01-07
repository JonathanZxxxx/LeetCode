using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class ReverseListClass
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;//前指针节点
            var current = head;//当前指针节点
            //每次循环，都将当前节点指向它前面的节点，然后当前节点和前节点后移
            while (current != null)
            {
                var temp = current.next;//临时节点，暂存当前节点的下一节点，用于后移
                current.next = prev;//将当前节点指向它前面的节点
                prev = current;//前指针后移
                current = temp;//当前指针后移
            }
            return prev;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList2(ListNode head)
        {
            //递归终止条件是当前为空，或者下一个节点为空
            if (head == null || head.next == null) return head;
            var node = ReverseList2(head.next);
            //head为4,head.next.next=head，node为4->5->4
            head.next.next = head;
            //head.next为空,防止链表循环，node为5->4
            head.next = null;
            //返回5->4,此时链表为1->2->3->4<-5
            //下次循环，head为3,head.next.next=head，node为3->4->3
            //head.next为空，node为4->3
            //返回4->3,此时链表为1->2<-3<-4<-5
            return node;
        }
    }
}
