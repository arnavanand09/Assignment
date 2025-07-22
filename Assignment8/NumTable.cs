using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class NumTable
    {
        public string solution(int N1, int N2, int Start, int End)
        {
            if (N1 <= 0 || N2 <= 0 || Start <= 0 || End <= 0)
            {
                return "0";
            }

            string result = "";

            for (int i = N1; i <= N2; i++)
            {
                for (int j = Start; j <= End; j++)
                {
                    result += i + " * " + j + " = " + (i * j) + "\n";
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            NumTable sol = new NumTable();

            Console.Write("Enter N1: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.Write("Enter N2: ");
            int N2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Start: ");
            int Start = int.Parse(Console.ReadLine());

            Console.Write("Enter End: ");
            int End = int.Parse(Console.ReadLine());

            string output = sol.solution(N1, N2, Start, End);
            Console.WriteLine("\nResult:\n" + output);
        }
    }

}