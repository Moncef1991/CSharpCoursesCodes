using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean comparaison ==, !=, <, >, <=, >=
            //Boolean conditions &&, ||

            bool myResult;
            int myVar1 = 5, myVar2 = 8;
            myResult = myVar1 <= 6;

            myResult = (myVar1 == 6) || (myVar2 == 8);

            Console.WriteLine("My result is = {0}", myResult);
            Console.ReadKey();
        }
    }
}
