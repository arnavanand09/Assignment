using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();

            Console.WriteLine("your name is");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
