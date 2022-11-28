using System;
namespace Algorithms.Tree
{
    public class BinaryTree
    {
        public Node Root { get; internal set; }



        public BinaryTree(int data)
        {
            Root = new Node(data);
        }
        public BinaryTree(string data)
        {
            Root = new Node(data);
        }
        public BinaryTree(Node node)
        {
            Root = node;
        }
        public BinaryTree()
        {
        }



        //InOrder
        public void SimetricTraversalString(Node node =null)
        {
            if (node == null)
            {
                node = this.Root;
            }
            if(node.Left != null)
            {
                Console.Write(' ');
                SimetricTraversalString(node.Left);
            }
            Console.Write(node.DataString);
            if (node.Right != null)
            {
                SimetricTraversalString(node.Right);
                Console.Write(' ');
            }
        }

        //InOrder
        public void InOrderInt(Node node = null)
        {
            if (node == null)
                node = this.Root;

            if (node.Left != null)
            {
                
                InOrderInt(node.Left);
            }
            Console.Write(node.DataInt + " ");
            if (node.Right != null)
            {
                InOrderInt(node.Right);
           
            }
        }

        public void PosOrderTraversalString(Node node = null)
        {
            if (node == null)
                node = this.Root;
            if (node.Left != null)
                PosOrderTraversalString(node.Left);
            if (node.Right != null)
                PosOrderTraversalString(node.Right);

            Console.Write(node.DataString);

        }

        public int Height(Node node = null)
        {
            var hLeft = 0;
            var hRight = 0;

            if (node == null)
                node = this.Root;
            if (node.Left != null)
                hLeft = Height(node.Left);
            if (node.Right != null)
                hRight =  Height(node.Right);
            if (hRight > hLeft)
                return hRight + 1;

            return hLeft + 1;
        }

        public void LevelOrderTraversalInt (Node node= null)
        {
            if (node == null)
                node = Root;

            var q = new Queue<Node>();
            q.Enqueue(node);

            while(q.Count > 0)
            {
                node = q.Dequeue();

                if(node.Left != null)
                    q.Enqueue(node.Left);
                if (node.Right != null)
                    q.Enqueue(node.Right);

                Console.WriteLine(node.DataInt);
            }
        }

        public int[] Print(int[] datas)
        {
            var tree = new BinaryTree(datas[0]);
            tree.Root.Left = new Node(datas[1]);
            tree.Root.Right = new Node(datas[2]);
            return new int[] { tree.Root.DataInt, tree.Root.Left.DataInt, tree.Root.Right.DataInt};

        }
    }
}

