using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class PayrollEmployee : Employee
    {
        public DateTime JoiningDate;
        public int Experience;
        public double BasicSalary, DA, HRA, PF, NetSalary;

        public PayrollEmployee(string id, string name, string manager,
                               DateTime join, int exp, double basic)
            : base(id, name, manager)
        {
            JoiningDate = join;
            Experience = exp;
            BasicSalary = basic;
            CalculateSalary();
        }

        private void CalculateSalary()
        {
            if (Experience > 10)
            {
                DA = 0.10 * BasicSalary;
                HRA = 0.085 * BasicSalary;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = 0.07 * BasicSalary;
                HRA = 0.065 * BasicSalary;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = 0.041 * BasicSalary;
                HRA = 0.038 * BasicSalary;
                PF = 1800;
            }
            else
            {
                DA = 0.019 * BasicSalary;
                HRA = 0.02 * BasicSalary;
                PF = 1200;
            }

            NetSalary = BasicSalary + DA + HRA - PF;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Type    : Payroll");
            Console.WriteLine($"Joined  : {JoiningDate.ToShortDateString()}");
            Console.WriteLine($"Exp     : {Experience} yrs");
            Console.WriteLine($"Basic   : ${BasicSalary}");
            Console.WriteLine($"DA      : ${DA}");
            Console.WriteLine($"HRA     : ${HRA}");
            Console.WriteLine($"PF      : ${PF}");
            Console.WriteLine($"Net     : ${NetSalary}");
            Console.WriteLine("----------------------------------");
        }
    }

}
