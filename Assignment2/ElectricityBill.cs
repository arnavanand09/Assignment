using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ElectricityBill
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int units = Convert.ToInt16(Console.ReadLine());

            double bill = 0;
            double rate = 0;

            if (units < 200) {
                bill = units * 1.20;
                rate = 1.20;
            }
            else if (units >=200 && units < 400)
            {
                bill = units * 1.50;
                rate = 1.50;
            }
            else if (units >=400 && units < 600)
            {
                bill = units * 1.80;
                rate = 1.80;
            }
            else
            {
                bill = units * 2.0;
                rate = 2.0;

            }
            if (bill < 100)
            {
                bill = 100;
            }

            double surcharge = 0;
            if (bill > 400)
            {
                surcharge = bill * 0.15;
            }
            double netAmount = bill + surcharge;

            Console.WriteLine($"Customer IdNo:{id}");
            Console.WriteLine($"Customer Name:{name}");
            Console.WriteLine($"Unit Consumed:{units}");
            Console.WriteLine($"Amount Charges {rate} per Unit:{bill}");
            Console.WriteLine($"Surcharge Amount:{surcharge}");
            Console.WriteLine($"Net Amount Paid by {name} : {netAmount}");
        }
    }
}
