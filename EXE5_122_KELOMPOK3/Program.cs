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

        public void Enter()
        {
            String value;
            Node newnode = new Node();
            Console.Write("\nEnter the element: ");
            value = Console.ReadLine();
            newnode.data = value;
            if (Habib == null)
            {
                Habib = newnode;
                Santoso = newnode;
            }
            else
            {
                Santoso.next = newnode;
                Santoso = newnode;

            }

            

        }
         public void Delete()
        {
            if (Habib == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Habib = Habib.next;
        }

        public void Display()
        {
            if (Habib == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node Display;
            for(Display = Habib; Display != null; Display = Display.next)
            {
                Console.WriteLine(Display.data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
