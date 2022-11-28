using System;
using Algorithms.Exceptions;

namespace Algorithms.LinkedList
{
    public class PrintElements
    {

        public List<int> Print(SinglyLinkedListNode head)
        { 
            SinglyLinkedList llist = new SinglyLinkedList();
            List<int> aux = new List<int>();
            bool run = true;
            while (run)
            {


                aux.Add(head.data);
                head.next = head.next.next;
                if (head.next == null)
                {
                    run = false;
                }
                   
                  

            }
            return aux;
            
        }

        public SinglyLinkedList InsertElements(int[] elements)
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            for (int i = 0; i < elements.Length; i++)
            {
                llist.InsertNode(elements[i]);
            }
            return llist;

        }


    }
}




