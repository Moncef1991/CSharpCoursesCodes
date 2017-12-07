using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explixit_Conversion_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal myDecvar = 100.999m;
            int myIntvar;
            myIntvar = unchecked((int)myDecvar);

            Console.WriteLine($"My Decimal variable = {myDecvar}" + "\n");
            Console.WriteLine($"My int variable = {myIntvar}");
            Console.ReadKey();
        }
    }
}
