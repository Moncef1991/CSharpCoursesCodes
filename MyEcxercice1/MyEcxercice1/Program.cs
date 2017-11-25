using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcxercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myCharValue1 = 'A';
            Console.WriteLine("The character value of A is = {0}", myCharValue1);

            int myCharValue2 = 'a';
            Console.WriteLine("The character value of a is = {0}", myCharValue2);

            string myString1 = "This is my character A value";
            Console.WriteLine("{0}", myString1);

            string myString2 = "This is my character a value";
            Console.WriteLine("{0}", myString2);

            Console.WriteLine("{0} {1} and {2} {3}", myString1, myCharValue1, myString2, myCharValue2);
            Console.ReadKey();
        }
    }
}
