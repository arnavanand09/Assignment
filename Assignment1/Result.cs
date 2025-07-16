using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Result
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Give any number");
            short num3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give another number");
            short num4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Sum of {num3} and {num4} is {num3 + num4}");
            Console.WriteLine($"Sub of {num3} and {num4} is {num3 - num4}");
            Console.WriteLine($"product of {num3} and {num4} is {num3 * num4}");
            Console.WriteLine($"quotient of {num3} and {num4} is {num3 / num4}");
            
        }
    }
}
