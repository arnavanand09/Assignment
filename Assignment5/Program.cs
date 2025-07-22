
using System;
using System.Collections.Generic;

namespace Assignment5
{
    public class Program
    {
        private static List<Employee> employeeList = new List<Employee>();

        public static void Main()
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nWho are you?");
                Console.WriteLine("1. Add Contract Employee");
                Console.WriteLine("2. Add Payroll Employee");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("4. Total Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddContractEmployee(); 
                        break;
                    case "2": AddPayrollEmployee(); 
                        break;
                    case "3": ShowAllEmployees(); 
                        break;
                    case "4": Console.WriteLine($"Total Employees: {Employee.EmployeeCount}"); 
                        break;
                    case "5": 
                        return;
                    default: Console.WriteLine("Invalid choice. Try again."); 
                        break;
                }
            }
        }

        private static void AddContractEmployee()
        {
            Console.Write("Emp ID: ");
            string id = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Manager: ");
            string mgr = Console.ReadLine();
            Console.Write("Contract Start Date (yyyy-mm-dd): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Duration (months): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Charges: ");
            double charges = double.Parse(Console.ReadLine());

            ContractEmployee ce = new ContractEmployee(id, name, mgr, start, duration, charges);
            employeeList.Add(ce);
        }

        private static void AddPayrollEmployee()
        {
            Console.Write("Emp ID: ");
            string id = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Manager: ");
            string mgr = Console.ReadLine();
            Console.Write("Joining Date (yyyy-mm-dd): ");
            DateTime join = DateTime.Parse(Console.ReadLine());
            Console.Write("Experience (years): ");
            int exp = int.Parse(Console.ReadLine());
            Console.Write("Basic Salary: ");
            double basic = double.Parse(Console.ReadLine());

            PayrollEmployee pe = new PayrollEmployee(id, name, mgr, join, exp, basic);
            employeeList.Add(pe);
        }

        private static void ShowAllEmployees()
        {
            if (employeeList.Count == 0)
            {
                Console.WriteLine("No employees added yet.");
                return;
            }

            Console.WriteLine("\n Employee List ");
            foreach (var emp in employeeList)
            {
                emp.Display();
            }
        }
    }
}