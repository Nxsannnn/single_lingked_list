using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace single_lingked_list
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
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
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if (START == null || (rollNo <= START.rollNumber))
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = START;
                START = newNode();
                return;
            }
            Node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = current;
                previous = newnode;
            }
            newnode.next = current;
            previous = newnode;

        }


    }
    public bool delNode(int rollNO)
    {
        Node previous, current;
        previous = current = null;
        if(Search(rollNO,ref previous ref current)== false)
            return false;
        previous.next = current.next;
        if (current == START)
            START = START.next;
        return true;
    }
    public bool Search(int rollNo, ref Node previous, ref Node Current)
    {
        previous = START;
        Current = START;
        while ((Current != null) && (rollNo != Current.rollNumber))
        {
            previous = Current;
            Current = Current.next;
        }
        if (Current == null)
            return false;
        else
            return true;
    }
    public void Traverse()
    {
        if (listEmpty())
            Console.WriteLine("\nThe records in the list are: ");
        else
        {
            Console.WriteLine("\nThe records in the list are:");
            Node currentNode;
            for (currentNode = START; currentNode != null;
                 currentNode = currentNode.next)

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
