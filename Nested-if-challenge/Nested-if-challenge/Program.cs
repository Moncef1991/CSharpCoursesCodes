using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 10, myVar2 = 6, myVar3 = 8;

            if (myVar1 == 10)
            {
                Console.WriteLine("myVar1 = 10");
                if ((myVar2 >= 5) && (myVar3 <= 9))
                {
                    Console.WriteLine("This is True");
                }
                else
                {
                    Console.WriteLine("This is False");
                }
            }

            else
            {
                Console.WriteLine("myVar1 is not = 10");

            }
            Console.ReadKey();


        }
    }
}
