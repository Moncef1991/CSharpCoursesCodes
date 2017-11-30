using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, +=, *=, /=, %=,
            int myVar1 = 7, myVar2 = 3;

            //myVar2 = myVar1;

            //myVar1 += myVar2;

            //myVar1 -= myVar2;

            //myVar1 *= myVar2;

            //myVar1 /= myVar2;

            myVar1 %= myVar2;



            Console.WriteLine("The result is {0}\nThe second result is {1}", myVar1, myVar2);
            Console.ReadKey();
        }
    }
}
