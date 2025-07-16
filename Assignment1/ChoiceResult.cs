using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ChoiceResult
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num 1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 0)
                Console.WriteLine($"The sum of {n1} and {n2} is {n1 + n2}");
            else if (ch == 1)
                Console.WriteLine($"The Sub of {n1} and {n2} is {n1 - n2}");
            else if (ch == 2)
                Console.WriteLine($"The product of {n1} and {n2} is {n1 * n2}");
            else if (ch == 3)
                Console.WriteLine($"quotient of {n1} and {n2} is {n1 / n2}");

            else Console.WriteLine("Invalid Choice");
        }
    }
}
