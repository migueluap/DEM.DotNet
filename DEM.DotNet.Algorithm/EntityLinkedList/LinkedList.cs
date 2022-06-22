using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.Algorithm.EntityLinkedList
{
    internal class LinkedList
    {
        private Node head;
        private Node work;
        private Node work2;

        public LinkedList()
        { 
            head = new Node();
            head.Next = null;
        }

        public void Traverse()
        {
            work = head;

            while (work.Next != null) 
            {
                work = work.Next;
                int d = work.Data;

                Console.Write("{0} ", d);
            }

            Console.WriteLine();
        }

        public void Add(int data)
        {
            work = head;

            while (work.Next != null)
            {
                work = work.Next;
            }
        
            Node tempNode = new Node();
            tempNode.Data = data;
            tempNode.Next = null;

            work.Next = tempNode;
            


        }
    }
}
