namespace Assignment11
{
    public class NumericFunctionsLib
    {
        public static int AddNumbers(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }

     
        public static int SubtractNumbers(int first, int second)
        {
            return first - second;
        }

        public static int MultiplyNumbers(params int[] numbers)
        {
            int result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public static float DivideNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide ");
            }
            return (float)dividend / divisor;
        }

        public static int FindLargest(params int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        public static int FindSmallest(params int[] numbers)
        {
            int smallest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            return smallest;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> GetEvenNumbers(int start, int end)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsEven(i))
                {
                    evenNumbers.Add(i);
                }
            }
            return evenNumbers;
        }

        public static List<int> GetOddNumbers(int start, int end)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsOdd(i))
                {
                    oddNumbers.Add(i);
                }
            }
            return oddNumbers;
        }

        public static List<int> GetPrimeNumbers(int start, int end)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        public static string GenerateMultiplicationTable(int number)
        {
            string table = "";
            for (int i = 1; i <= 10; i++)
            {
                table += $"{number} × {i} = {number * i}\n";
            }
            return table;
        }

        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            int original = number;

            while (original != 0)
            {
                int digit = original % 10;
                reversed = reversed * 10 + digit;
                original /= 10;
            }

            return reversed;
        }
    }
}
