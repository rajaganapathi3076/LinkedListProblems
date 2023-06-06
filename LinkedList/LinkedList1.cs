using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList1
    {
        private Node Head;

        public void AddLast(int data)
        {
            Node newNode=new Node(data);
            if (Head == null)
            {
                Head = newNode;
                Console.WriteLine("{0} is add  to the LinkedList", data);
            }
            else
            {
                Node lastnode= GetLastNode();
                lastnode.Next = newNode;
                Console.WriteLine("{0} is add  to the LinkedList", data);
                
            }
        }
        private Node GetLastNode()
        {
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void Display()
        {
            Node current = Head;
            while(current.Next != null)
            {
                //Console.WriteLine(current.Data +"  ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
