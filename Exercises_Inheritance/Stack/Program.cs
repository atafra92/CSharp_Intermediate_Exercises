using System;
using System.Collections;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("Antonio");
            stack.Push(1);
            stack.Push(new int[] { 3, 5 });
            stack.Push('c');

            //casting a List<object> object which contains an int[] object to int[]
            int[] arrobj = (int[])stack.StackList[2];

            //loops throught values of each object in a List<object> including anonymous int[] values and prints them to console
            foreach (var item in stack.StackList)
            {
                if (item.GetType().Name != "Int32[]")
                {
                    Console.WriteLine(item);
                }
                else
                {
                    foreach (var obj in arrobj)
                    {
                        Console.WriteLine(obj);
                    }
                }
            }

            //looping through values of a each object in List<object> with Pop() method 
            for (int i = stack.StackList.Count -1; i >= 0; i--)
            {
                if (stack.StackList[i].GetType().Name == "Int32[]")
                {
                    object o = stack.Pop();
                    int[] arr = (int[])o;
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine(stack.Pop());
                }
            }

            Console.ReadLine();
        }
    }
}
