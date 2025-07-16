using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayNumberGap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 100 to 5 with a gap of 3 ");

            for (int i = 100; i >= 5; i-=3) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
