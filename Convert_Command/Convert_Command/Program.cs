using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDoublevar = 2500.45d;

            string myStringvar, mySubString;

            //myDoublevar = myDoublevar;                // Implicit Conversion

            myStringvar = Convert.ToString(myDoublevar);

            mySubString = myStringvar.Substring(0, 2);

            Console.WriteLine($"My variabe is {myDoublevar}\n");
            Console.WriteLine($"My string variable is {myStringvar}\n");
            Console.WriteLine($"My substring variable is {mySubString}");
            Console.ReadKey();

        }
    }
}
