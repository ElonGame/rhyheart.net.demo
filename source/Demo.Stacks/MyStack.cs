using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Stacks
{
    public class MyStack
    {
        Entry top;

        public void Push(object data)
        {
            top = new Entry(top, data);
        }

        public object Pop()
        {
            if (top == null)
                return null;

            var result = top.Data;
            top = top.Next;

            return result;
        }

        class Entry
        {
            public readonly Entry Next;
            public readonly object Data;

            public Entry(Entry next, object data)
            {
                Next = next;
                Data = data;
            }

        }
    }
}
