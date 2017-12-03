using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int myWeight = 120, i = 0;
            
            while (myWeight > 83)
            {
                myWeight -= 1;
                i++;
            }
            Console.WriteLine("I need {0} exercises to reach 83 kg", i);
            Console.ReadKey();
        }
    }
}
