using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    public class ContractEmployee : Employee
    {
        private DateTime ContractStartDate;
        private int Duration;
        private double Charges;

        public ContractEmployee(string id, string name, string manager,
                                DateTime start, int duration, double charges)
            : base(id, name, manager)
        {
            ContractStartDate = start;
            Duration = duration;
            Charges = charges;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Type    : Contract");
            Console.WriteLine($"Start   : {ContractStartDate.ToShortDateString()}");
            Console.WriteLine($"Duration: {Duration} months");
            Console.WriteLine($"Charges : ${Charges}");
            Console.WriteLine("----------------------------------");
        }
    }

}
