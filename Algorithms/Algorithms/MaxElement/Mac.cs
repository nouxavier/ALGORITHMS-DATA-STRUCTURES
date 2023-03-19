using System;
namespace Algorithms.MaxElement
{
    public class Max
    {
        public Max()
        {
        }
        public static void getMax(List<string> operations)
        {
            Dictionary<string, int> dicOp = new Dictionary<string, int>();
            Stack<int> s = new Stack<int>();
            Stack<int> max = new Stack<int>();
            foreach (var operation in operations)
            {
                var op = operation.Split(' ');
                //Push the element x into the stack.
                if (op[0] == "1")
                {
                    int value = int.Parse(op[1]);
                    s.Push(value);
                 
                    //max
                    if (max.Count == 0 || max.Peek() < value)
                    {
                        max.Push(value);
                    }
                }
                //Delete the element present at the top of the stack.
                else if (op[0] == "2")
                {
                    int value = int.Parse(op[1]);
                    s.Pop();
                    //max
                    if ( max.Peek() == value)
                    {
                        max.Pop();
                    }
                }
                //Print the maximum element in the stack.
                else if (op[0] == "3")
                {
                    Console.WriteLine(max.Peek());
                }

            }
        }


    }
}

