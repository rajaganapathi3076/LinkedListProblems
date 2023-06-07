using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Problem UC6\n");
            LinkedList1 LinkedList=new LinkedList1();
            LinkedList.Append(56);
            LinkedList.Append(30);
            LinkedList.Append(70);
            LinkedList.Display();
           

            LinkedList.RemoveLast();
            LinkedList.Display();
















        }
    }
}
