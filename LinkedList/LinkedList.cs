using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        Node head;
        public void Addnote(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("List contains");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.WriteLine("Data - " + tempnode.data + " ");
                    tempnode = tempnode.Next;
                }
                Console.WriteLine("\n");
            }
        }
        public void Addreverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.Next = temp;
            }

        }
        public void Insert(int position, int data)
        {
            {
                Node node = new Node(data);
                if (position < 1)
                    Console.WriteLine("Enter Valid Position");
                else if (position == 1)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    Node temp = head;
                    {
                        while (position > 2)
                        {
                            temp = temp.Next;
                            position--;
                        }
                        node.Next = temp.Next;
                        temp.Next = node;
                    }
                }
            }
        }
        public void FirstDelete()
        {
            Node node = head;
            if (head != null)
            {
                node = head;
                head = head.Next;
                node = null;
            }
        }
    }
}
