using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        public static int EmployeeCount = 0;
        private string EmpID;
        private string Name;
        private string ReportingManager;

        public Employee(string id, string name, string manager)
        {
            EmpID = id;
            Name = name;
            ReportingManager = manager;
            EmployeeCount++;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID      : {EmpID}");
            Console.WriteLine($"Name    : {Name}");
            Console.WriteLine($"Manager : {ReportingManager}");
        }
    }

}
