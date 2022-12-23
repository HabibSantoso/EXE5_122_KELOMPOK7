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
            QueueLinkedList q = new QueueLinkedList();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("\n***Menu***\n");
                    Console.WriteLine("1. Implement insert opration");
                    Console.WriteLine("2. Implement delete opration");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    String sInput = Console.ReadLine();
                    ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                    switch (ch)
                    {
                        case '1':

                            q.Enter();
                            break;
                        case '2':
                            q.Delete();
                            break;
                        case '3':
                            q.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("\nInvalid choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Check for the values entered");
                }

            }
        }
    }
}
