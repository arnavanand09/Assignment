namespace Assignment5
{
    using System;
    using System.Collections.Generic;

    class Employee
    {
        public static int EmployeeCount = 0;
        public string EmpID;
        public string Name;
        public string ReportingManager;

        public Employee(string id, string name, string manager)
        {
            EmpID = id;
            Name = name;
            ReportingManager = manager;
            EmployeeCount++;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee ID       : {EmpID}");
            Console.WriteLine($"Name              : {Name}");
            Console.WriteLine($"Reporting Manager : {ReportingManager}");
        }
    }

    class ContractEmployee : Employee
    {
        public DateTime ContractStartDate;
        public int DurationInMonths;
        public double Charges;

        public ContractEmployee(string id, string name, string manager,
                                DateTime startDate, int duration, double charges)
            : base(id, name, manager)
        {
            ContractStartDate = startDate;
            DurationInMonths = duration;
            Charges = charges;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Type              : Contract");
            Console.WriteLine($"Contract Start    : {ContractStartDate.ToShortDateString()}");
            Console.WriteLine($"Duration (months) : {DurationInMonths}");
            Console.WriteLine($"Charges           : ₹{Charges}");
            Console.WriteLine("--------------------------------------------");
        }
    }

    class PayrollEmployee : Employee
    {
        public DateTime JoiningDate;
        public int Experience;
        public double BasicSalary;
        public double DA;
        public double HRA;
        public double PF;
        public double NetSalary;

        public PayrollEmployee(string id, string name, string manager,
                               DateTime joiningDate, int exp, double basic)
            : base(id, name, manager)
        {
            JoiningDate = joiningDate;
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
            Console.WriteLine($"Type              : Payroll");
            Console.WriteLine($"Joining Date      : {JoiningDate.ToShortDateString()}");
            Console.WriteLine($"Experience (years): {Experience}");
            Console.WriteLine($"Basic Salary      : ₹{BasicSalary}");
            Console.WriteLine($"DA                : ₹{DA}");
            Console.WriteLine($"HRA               : ₹{HRA}");
            Console.WriteLine($"PF                : ₹{PF}");
            Console.WriteLine($"Net Salary        : ₹{NetSalary}");
            Console.WriteLine("--------------------------------------------");
        }
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Contract Employee");
                Console.WriteLine("2. Add Payroll Employee");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("4. Show Total Employee Count");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter EmpID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Reporting Manager: ");
                    string manager = Console.ReadLine();
                    Console.Write("Enter Contract Start Date (yyyy-mm-dd): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Duration in months: ");
                    int duration = int.Parse(Console.ReadLine());
                    Console.Write("Enter Charges: ");
                    double charges = double.Parse(Console.ReadLine());

                    ContractEmployee ce = new ContractEmployee(id, name, manager, date, duration, charges);
                    employees.Add(ce);
                    Console.WriteLine("Contract Employee added successfully!");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter EmpID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Reporting Manager: ");
                    string manager = Console.ReadLine();
                    Console.Write("Enter Joining Date (yyyy-mm-dd): ");
                    DateTime joining = DateTime.Parse(Console.ReadLine());
                    Console.Write("Enter Experience in years: ");
                    int exp = int.Parse(Console.ReadLine());
                    Console.Write("Enter Basic Salary: ");
                    double basic = double.Parse(Console.ReadLine());

                    PayrollEmployee pe = new PayrollEmployee(id, name, manager, joining, exp, basic);
                    employees.Add(pe);
                    Console.WriteLine("Payroll Employee added successfully!");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("\n--- Employee Details ---");
                    foreach (var emp in employees)
                    {
                        emp.Display();
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine($"\nTotal Number of Employees: {Employee.EmployeeCount}");
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Try again.");
                }
            }
        }
    }

}
