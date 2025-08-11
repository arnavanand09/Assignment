using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    class Queue
    {
        private Node front;
        private Node rear;

        public Queue()
        {
            front = rear = null;
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            Console.WriteLine($"Inserted: {data}");
        }

        public void Delete()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow! Cannot delete.");
                return;
            }

            Console.WriteLine($"Deleted: {front.Data}");
            front = front.Next;
            if (front == null)
                rear = null;
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.Write("Queue (front to rear): ");
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Peek()
        {
            if (front == null)
                Console.WriteLine("Queue is empty.");
            else
                Console.WriteLine($"Front of queue: {front.Data}");
        }
    }

    class LinkedListQueueDemo
    {
        static void Main()
        {
            Queue queue = new Queue();
            int choice;

                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Peek (Front)");
                Console.WriteLine("4. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt16(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to insert: ");
                        if (int.TryParse(Console.ReadLine(), out int value))
                            queue.Insert(value);
                        else
                            Console.WriteLine("Invalid input! Please enter a number.");
                        break;

                    case 2:
                        queue.Delete();
                        break;

                    case 3:
                        queue.Peek();
                        break;

                    case 4:
                        queue.Display();
                        break;

                    case 0:
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

        
        }
    }
}