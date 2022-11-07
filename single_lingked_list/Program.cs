using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Collections;

public bool Search(int rollNo, ref Node previous, ref Node current)
{
    previous = START;
    current = START;
    while ((current != null) && (rollNo != current.rollNumber))
    {
        previous = current;
        current = current.next;
    }
    if (current == null)
        return false;
    else
        return true;
}
public void Traverse()
{
    if (listEmpty())
        Console.WriteLine("\nThe Records in The List are: ");
    else
    {
        Console.WriteLine("\nThe Records in The List are: ");
        Node currentNode;
        for (currentNode = START; currentNode != null;
            currentNode = currentNode.next)
            Console.Write(currentNode.rollNumber + " "
                + currentNode.name + "\n");
        Console.WriteLine();
    }
}

public bool listEmpty()
{
    if (START == null)
        return true;
    else
        return false;
}
    }
    class Program
{
    static void Main(string[] args)
    {
        List obj = new List();
        while (true)
        {
            try
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Add a record to the list");
                Console.WriteLine("2. Delete a record from the list");
                Console.WriteLine("3. View all the records in the list");
                Console.WriteLine("4. Search for a record in the list");
                Console.WriteLine("5. EXIT");
                Console.Write("\nEnter your choice (1-5) : ");
                while ((current != null) && (rollNo != current.rollNumber))
                {
                    previous = current;
                    current = current.next;
                }
                if (current == null)
                    return false;
                else
                    return true;
            }
        public void Traverse()
            {
                if (listEmpty())
                    Console.WriteLine("\nThe Records in The List are: ");
                else
                {
                    Console.WriteLine("\nThe Records in The List are: ");
                    Node currentNode;
                    for (currentNode = START; currentNode != null;
                        currentNode = currentNode.next)
                        Console.Write(currentNode.rollNumber + " "
                            + currentNode.name + "\n");
                    Console.WriteLine();
                }
            }

            public bool listEmpty()
            {
                if (START == null)
                    return true;
                else
                    return false;
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMENU");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all the records in the list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. EXIT");
                    Console.Write("\nEnter your choice (1-5) : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.addNote();
                            }
                            break;

                        case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Console.WriteLine("Enter the roll number of" +
                                    " The Student whose record is to be deleted: ");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delNode(rollNo) == false)
                                    Console.WriteLine("\nRecord Not Found.");
                                else
                                    Console.WriteLine("Record with roll number" +

                                        +rollNo + "Deleted");
                            }
                            break;
                        case '3':
                            {
                                obj.Traverse();
                            }
                            break;
                        case '4':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is Empty");
                                    break;
                                }
                                Node previous, current;
                                previous = current = null;
                                Console.Write("\nEnter the roll number of the " +
                                    "Student whole record is to be Searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nRecord Not Found");
                                else
                                {
                                    Console.WriteLine("\nRecord Not Found");
                                    Console.WriteLine("\nRoll Number: " + current.rollNumber);
                                    Console.WriteLine("\nName: " + current.name);
                                }
                            }
                            break;

                        case '5':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid ption");
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nCheck for the value entered");
                }
            }
        }
    }
}
