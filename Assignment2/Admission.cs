namespace Assignment2
{
    internal class Admission
    {
        static void Main()
        {
            Console.WriteLine("Input the marks obtained in Physics:");
            int maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry:");
            int phy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics:");
            int chem = Convert.ToInt16(Console.ReadLine());

            int totalAll = phy + chem + maths;
            int totalMathPhy = maths + phy;

            if (maths >=65 && phy >=55 && chem >= 50 && totalAll >= 180 || totalMathPhy >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");

            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
