using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace d7a1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            Console.Write("Enter the employee type (1-3): ");
            int employeeType = int.Parse(Console.ReadLine());
            int wHour, nWDays, projectHandles, extras;
            double monthlySalary;

            switch (employeeType)
            {
                case 1: // HR
                    Console.Write("Enter working hours: ");
                    wHour = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    nWDays = int.Parse(Console.ReadLine());
                    monthlySalary = CalculateSalary(1, 1);
                    Console.WriteLine("Monthly Salary: $" + monthlySalary);
                    break;

                case 2: // Admin
                    Console.Write("Enter working hours: ");
                    wHour = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    nWDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter project handles: ");
                    projectHandles = int.Parse(Console.ReadLine());

                    monthlySalary = CalculateSalary(1, 1, 1);
                    Console.WriteLine("Monthly Salary: $" + monthlySalary);
                    break;

                case 3: // Software Developer
                    Console.Write("Enter working hours: ");
                    wHour = int.Parse(Console.ReadLine());
                    Console.Write("Enter number of working days: ");
                    nWDays = int.Parse(Console.ReadLine());
                    Console.Write("Enter project handles: ");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.Write("Enter extras: ");
                    extras = int.Parse(Console.ReadLine());

                    monthlySalary = CalculateSalary(1, 1, 1, 1);
                    Console.WriteLine("Monthly Salary: $" + monthlySalary);
                    break;

                default:
                    Console.WriteLine("Invalid employee type!");
                    break;
            }

            Console.ReadLine();
        }

        static double CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
        {
            double total = wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
            return total;
        }
    }
}
