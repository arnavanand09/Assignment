namespace Assignment14
{
    internal class LLStack
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

        class Stack
        {
             Node top;

            public Stack()
            {
                top = null;
            }

            public void Push(int data)
            {
                Node newNode = new Node(data);
                newNode.Next = top;
                top = newNode;
                Console.WriteLine($"Pushed: {data}");
            }

            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack Underflow!.");
                    return;
                }

                Console.WriteLine($"Popped: {top.Data}");
                top = top.Next;
            }

            public void Peek()
            {
                if (top == null)
                    Console.WriteLine("Stack is empty.");
                else
                    Console.WriteLine($"Top element: {top.Data}");
            }

            public void Display()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty.");
                    return;
                }

                Console.Write("Stack : ");
                Node current = top;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        class LinkedListStackDemo
        {
            static void Main()
            {
                Stack stack = new Stack();

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                stack.Display();  

                stack.Peek();     

                stack.Pop();      
                stack.Pop();      

                stack.Display();  

                stack.Peek();     

                stack.Pop();      
                stack.Pop();   
            }
        }
    }
}