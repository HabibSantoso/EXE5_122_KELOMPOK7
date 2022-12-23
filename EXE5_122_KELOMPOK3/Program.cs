using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_122_KELOMPOK7
{
    class Node
    {
        public String data;
        public Node next;
    }

    class QueueLinkedList
    {
        Node Habib;
        Node Santoso;

        public QueueLinkedList()
        {
            Habib = null;
            Santoso = null;
        }

        public void insert()
        {
            String value;
            Console.Write("\nEnter the value you want to insert: ");
            value = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
