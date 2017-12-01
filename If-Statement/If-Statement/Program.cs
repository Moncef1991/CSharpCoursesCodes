using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 11;
            if (myVar == 11)
            {
                myVar = 11;
                Console.WriteLine("{0}", myVar);
                Console.WriteLine("My variable = 10");
            }
            else
                Console.WriteLine("My variable is not = 10");


            int myVar1 = 9, myVar2 = 7;

            if((myVar1<=7) || (myVar2>=10))
            {
                Console.WriteLine("\nMy conditions is true");

            }
            else
            {
                Console.WriteLine("\nMy conditions is false");

            }
            
            Console.ReadKey();
        }
    }
}
