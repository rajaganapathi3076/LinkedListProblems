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
        public void AddFirst(int data)
        {
            Node newNode=new Node(data);
            newNode.Next = Head;
            Head = newNode; 
            Console.WriteLine("{0} is added into LinkedList",newNode.Data);
        }
        public void Display()
        {
            if(Head == null)
            {
                Console.WriteLine("No node are present");
            }
            else
            {
                Node temp=Head;
                while(temp!=null)
                {
                    Console.Write(temp.Data+ " ");
                    temp = temp.Next;
                }
            }
            
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void RemoveFirst()
        {
            if( Head == null)
            {
                Console.WriteLine("\nLinkedList is empty");
            }
            else
            {
                int deletedNode = Head.Data;
                Head=Head.Next;
                Console.WriteLine("\n{0} means 1st node is deleted from LinkedList", deletedNode);
            }
        }
        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("\n LinkedList is empty");
            }
            else if (Head.Next == null)
                Head = Head.Next;
            else
            {
                Node temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                Console.WriteLine("\n{0} is removed from last", temp.Next.Data);
                temp.Next = null;

            }





    }   }
}
