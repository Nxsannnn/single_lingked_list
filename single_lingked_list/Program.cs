using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_lingked_list
{
    class Node
    {
        public int rollNumber;
        public string name;
        public  Node next;
    }

    class List
    {
        Node START;
        public List() 
        {
            START = null;
        }
        public void addNote()
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll number of the student: ");
            nm = Console.ReadLine();
            Node.newnode = Node();
            newnode.rollNumber

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
