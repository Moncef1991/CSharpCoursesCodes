using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim_Function_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString2, myString3, myString4, myString1 = "Hello my dear";

            myString2 = myString1.PadRight(14, 'e');
            myString3 = myString2.PadRight(15, 's');
            myString4 = myString3.PadRight(16, 't');

            Console.WriteLine($"{myString4}");
            Console.ReadKey();

        }
    }
}
