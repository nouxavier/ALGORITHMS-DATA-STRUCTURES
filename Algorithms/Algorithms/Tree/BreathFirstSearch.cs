using System;
namespace Algorithms.Tree
{
    public class BreathFirstSearch: BinaryTree
    {
        public BreathFirstSearch(int data):base(data)
        {
        }

        public static (List<int>, List<int>) SearchInt(Node currentNode, BinaryTree tree) 
        {
            List<int> list = new List<int>();
            List<int> listDistance = new List<int>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(currentNode);

            while (queue.Count >0)
            {
                currentNode = queue.Dequeue();

                listDistance.Add(tree.Height(currentNode));

                list.Add(currentNode.DataInt);
                
                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }

            }
            return (list, listDistance);
        }

        public static List<int> BFSDistance(int numberNodes, int numberEdges, List<List<int>> edges, int startNode)
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(startNode);
            foreach(var node in edges)
            {
                tree.Insert(node[1]);
            }

            return SearchInt(tree.Root,tree).Item1;
        }


    }
}

