using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyalTest15
{
    public class ListNode<T> where T : IComparable
    {
        private T _val;

        private ListNode<T> _next { get; set; }

        public ListNode(T val)
        {
            _val = val;
        }               

        public void AppendToTail(T val)
        {
            var end = new ListNode<T>(val);
            var n = this;
            while (n._next != null)
            {
                n = n._next;
            }
            n._next = end;
        }

        public ListNode<T> Remove(T val)
        {
            var n = this;
            while (n._next != null && n._next._val.CompareTo(val) != 0) n = n._next;
            if (n._next != null) n._next = n._next._next;
            return this;
        }
    }
}
