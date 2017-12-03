using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            double mySalary = 1020, i = 1.0;
            
            do
            {
                mySalary += 20;
                i++;
            } while (mySalary <= 2000);
            Console.WriteLine("I need {0} years to reach 2000", i/12);
            Console.ReadKey();
        }
    }
}
