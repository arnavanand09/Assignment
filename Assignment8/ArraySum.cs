using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class ArraySum
    {
        
        public int solution(int[] A)
        {
            int sum = 0;

            foreach (int num in A)
            {
                if (num == 0)
                    break;

                if (num > 0)
                    sum += num;
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            ArraySum sol = new ArraySum();

            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                A[i] = int.Parse(Console.ReadLine());
            }

            int result = sol.solution(A);

            Console.WriteLine("Sum of positive numbers (until 0): " + result);
        }
    }

}
