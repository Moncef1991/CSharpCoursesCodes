using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName;
            decimal Salary, TaxRate = 0.07M;


            Console.WriteLine("Enter your First Name\n");
            FirstName = Console.ReadLine();

            Console.WriteLine("\nEnter your Last Name\n");
            LastName = Console.ReadLine();

            Console.WriteLine("\nEnter your Salary\n");
            Salary = (Convert.ToDecimal(Console.Read()));

            Console.WriteLine($"\nWelcome {FirstName} {LastName}\n");
            Console.WriteLine("Your Salary for 12 months is {0} $ ", ((Salary - (TaxRate * Salary)) * 12));
            Console.WriteLine("\nYou paid Tax Rate for 12 months {0} $", ((TaxRate * Salary) * 12));
            Console.ReadKey();
        }
    }
}
