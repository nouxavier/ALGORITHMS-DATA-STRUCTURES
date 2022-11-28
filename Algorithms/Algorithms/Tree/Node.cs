using System;
namespace Algorithms.Tree
{
    public class Node
    {
        public int DataInt  { get; internal set; }
        public string DataString { get; internal set; }
        public Node Left  { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            DataInt = data;
           
        }
        public Node(string data)
        {
            DataString = data;

        }


    }
}

