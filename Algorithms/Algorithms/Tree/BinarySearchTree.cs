using System;
using Algorithms.Exceptions;

namespace Algorithms.Tree
{
    public class BinarySearchTree: BinaryTree
    {
        public BinarySearchTree(int data):base(data)
        {
        }
        public BinarySearchTree(string data) : base(data)
        {
        }
        public BinarySearchTree(Node data) : base(data)
        {
        }
        public BinarySearchTree()
        {
        }


        public void Insert(int value)
        {
            Node parent = null;
            var x = this.Root;

            while(x != null)
            {
                parent = x;
                if (value < x.DataInt)
                    x = x.Left;
                else
                    x = x.Right;
            }

            if (parent == null)
                this.Root = new Node(value);
            else if (value < parent.DataInt)
                parent.Left = new Node(value);
            else
                parent.Right = new Node(value);

        }

        public Node Remove(int value, Node node, bool root = true)
        {
            if (root)
            {
                node = this.Root;
                root = false;
            }
               

            if (node == null)
                return node;

            if (value < node.DataInt)
                node.Left = Remove(value, node.Left, false);
            else if (value > node.DataInt)
                node.Right = Remove(value, node.Right, false);
            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;
                else
                {
                    int substitute = Min(node.Right);
                    node.DataInt = substitute;
                    node.Right = Remove(substitute, node.Right, false);

                }

            }
            return node;
        }

        public BinarySearchTree Search(int value)
        {
            return SearchInt(value, this.Root);
        }

        private BinarySearchTree SearchInt(int value, Node node)
        {
            if (node == null)
                node = Root;
            if (node.DataInt == value)
                return new BinarySearchTree(value);
            else if (value < node.DataInt)
                return SearchInt(value, node.Left);
            else
                return SearchInt(value, node.Right);

        }

        public int Min (Node node = null)
        {
            if(node== null)
                node = Root;

            while(node.Left != null)
            {
                node = node.Left;
            }

            return node.DataInt;
        }

        public int Max(Node node = null)
        {
            if (node == null)
                node = Root;

            while (node.Right != null)
            {
                node = node.Right;    
            }

            return node.DataInt;
        }


    }
}

