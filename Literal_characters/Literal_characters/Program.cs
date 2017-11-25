using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000;
            ulong myLVar = 1000;

            float myFLVar = 1.5F;
            double myDVar = 100.5D;
            decimal myDCVar = 100.5M;

            Console.WriteLine("{0} {1}", myVar, myUVar);
            Console.WriteLine($"{myDCVar}, {myDVar}");
            Console.ReadKey();

        }
    }
}
