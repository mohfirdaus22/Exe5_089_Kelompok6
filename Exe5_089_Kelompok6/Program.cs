using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_089_Kelompok6
{
     class Node
    {
        public string name;
        public Node next;

    }
    class Queue
    {
        Node Moh, Illahi;

        public Queue()
        {
            Moh = null;
            Illahi = null;  
        }
        public void Insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Maukkan Element : ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (Moh == null)
            {
                Moh = newnode;
                Illahi = newnode;
                return;
            }
            Illahi.next = newnode;
            Illahi = newnode;
        }
        public void Delete()
        {
            if(Moh == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Moh = Moh.next;
            if(Moh == null)
                Illahi=null;
        }
        public void display()
        {
            if(Moh == null)
            {
                Console.WriteLine("Queue is Empty !!");
                return ;
            }
            Node display;
            for (display = Moh; display != null; display = display.next)
                Console.WriteLine(display.name);
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert operation");
                    Console.WriteLine("2. Implement Delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\n Enter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}
