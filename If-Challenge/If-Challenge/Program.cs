using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 8;
            if (myVar > 10)
                Console.WriteLine("My variable is greater than 10");
            else
                Console.WriteLine("My variable is less than 10");

            int myVar1 = 10, myVar2 = 5, myVar3 = 9;
            if ((myVar1 <= 11) || (myVar2 == 6) && (myVar3 >= 8))
                Console.WriteLine("\nTrue");
            else
                Console.WriteLine("\nFalse");

            Console.ReadKey();
        }
    }
}
