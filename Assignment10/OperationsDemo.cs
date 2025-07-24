using System;
using System.Linq;

namespace Assignment10
{
    public static class Operations
    {
        public static int Sum(params int[] nums) => nums.Sum();

        public static int Sub(int a, int b) => a - b;

        public static int Product(params int[] nums) => nums.Aggregate(1, (acc, val) => acc * val);

        public static int Min(params int[] nums) => nums.Min();

        public static int Max(params int[] nums) => nums.Max();

        public static bool IsEven(int num) => num % 2 == 0;

        public static bool IsOdd(int num) => num % 2 != 0;

        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
                if (num % i == 0) return false;

            return true;
        }
    }

    public static class NumberExtensions
    {
        public static void DisplayEven(this int start, int end)
        {
            Console.WriteLine($"Even numbers from {start} to {end}:");
            for (int i = start; i <= end; i++)
                if (i % 2 == 0)
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayOdd(this int start, int end)
        {
            Console.WriteLine($"Odd numbers from {start} to {end}:");
            for (int i = start; i <= end; i++)
                if (i % 2 != 0)
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayPrimes(this int start, int end)
        {
            Console.WriteLine($"Prime numbers from {start} to {end}:");
            for (int i = start; i <= end; i++)
                if (Operations.IsPrime(i))
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static void DisplayTable(this int num)
        {
            Console.WriteLine($"Table of {num}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} * {i} = {num * i}");
        }

        public static void DisplayTablesFrom1to10(this int start, int end)
        {
            Console.WriteLine($"Tables from 1 to 10 for numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"\nTable of {i}:");
                for (int j = 1; j <= 10; j++)
                    Console.WriteLine($"{i} * {j} = {i * j}");
            }
        }

        public static void DisplayTablesFromRange(this int _, int start, int end, int tableStart, int tableEnd)
        {
            Console.WriteLine($"\nTables from {tableStart} to {tableEnd} for numbers between {start} and {end}:");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"\nTable of {i}:");
                for (int j = tableStart; j <= tableEnd; j++)
                    Console.WriteLine($"{i} * {j} = {i * j}");
            }
        }

        public static int ReverseNumber(this int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
    }

    class OperationsDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                string input1 = Console.ReadLine();
                int num1 = string.IsNullOrWhiteSpace(input1) ? 10 : int.Parse(input1);

                Console.Write("Enter second number: ");
                string input2 = Console.ReadLine();
                int num2 = string.IsNullOrWhiteSpace(input2) ? 10 : int.Parse(input2);

                Console.WriteLine("\n--- Basic Operations ---");
                Console.WriteLine($"Sum: {Operations.Sum(num1, num2)}");
                Console.WriteLine($"Subtract: {Operations.Sub(num1, num2)}");
                Console.WriteLine($"Product: {Operations.Product(num1, num2)}");
                Console.WriteLine($"Min: {Operations.Min(num1, num2)}");
                Console.WriteLine($"Max: {Operations.Max(num1, num2)}");
                Console.WriteLine($"{num1} is Even? {Operations.IsEven(num1)}");
                Console.WriteLine($"{num2} is Odd? {Operations.IsOdd(num2)}");
                Console.WriteLine($"{num1} is Prime? {Operations.IsPrime(num1)}");

                Console.WriteLine("\n--- Extension Methods ---");
                num1.DisplayTable();
                num1.DisplayTablesFrom1to10(num2);
                num1.DisplayTablesFromRange(num2, num2 + 1, 2, 4);
                num1.DisplayEven(num2);
                num1.DisplayOdd(num2);
                num1.DisplayPrimes(num2);
                Console.WriteLine($"Reverse of {num1} is {num1.ReverseNumber()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
