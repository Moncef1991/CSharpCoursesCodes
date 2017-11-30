using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7, myVar2 = 2;

            myVar1 /= ++myVar2;

            Console.WriteLine("The result is {0}\nThe second is {1}", myVar1, myVar2);
            Console.ReadKey();
        }
    }
}
