using System.ComponentModel;

namespace Assignment8
{
    internal class MinSumSq
    {
        
        public int solution(int[] A)
        {
            int smallest = int.MaxValue;

            foreach (int num in A)
            {
                if (num > 0 && num < smallest)
                {
                    smallest = num;
                }
            }

            if (smallest == int.MaxValue)
                return 0;

            return smallest * smallest;
        }

        public static void Main(string[] args)
        {
            MinSumSq sol = new MinSumSq();

            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];

            Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                A[i] = int.Parse(Console.ReadLine());
            }

            int result = sol.solution(A);
            Console.WriteLine("Result: " + result);
        }
    }

}
