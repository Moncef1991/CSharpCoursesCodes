using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 0;
            for (double mySalary = 1020; mySalary <= 2000; mySalary += 20)
            {
                i++;
            }
            Console.WriteLine("I need {0} years to reach 2000", i/12);

            int j = 0;
            for (int myWeight = 120; myWeight > 83; myWeight--)
            {
                j++;
            }
            Console.WriteLine("\nI need {0} to reach 83 kg", j);
            Console.ReadKey();
        }
    }
}
