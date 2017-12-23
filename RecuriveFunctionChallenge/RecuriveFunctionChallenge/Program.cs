using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RecuriveFunctionChallenge
{
    class Program
    {
        static int FactFunction(int myValue, ref int counter)
        {
            counter++;
            if (myValue == 0)
                return 1;

            else 
            {
                return myValue * FactFunction(myValue - 1, ref counter);

            }
            
        }
        static void Main(string[] args)
        {
            int counter = 0, myResult;
            myResult = FactFunction(5, ref counter);
            Console.WriteLine($"My result is {myResult} and counter value is {counter}");
            Console.ReadKey();
        }
    }
}
