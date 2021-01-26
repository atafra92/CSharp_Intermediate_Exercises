using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        public List<object> StackList { get; } = new List<object>();

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Value can not be null!");
            }

            StackList.Add(obj);
        }

        public object Pop()
        {
            int index = StackList.Count - 1;
            object obj = null;

            if (StackList.Count > 0)
            {
                obj = StackList[index];

                StackList.RemoveAt(index);
            }
            else
            {
                throw new InvalidOperationException("List can not be empty!");
            }

            return obj; 
        }

        public void Clear()
        {
            StackList.Clear();
        }
    }
}
