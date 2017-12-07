using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myVar1 = 1000;
            float myVar2 = myVar1;
            Console.WriteLine($"{myVar2}");

            char myVar3 = 'G';
            int myIntvar = myVar3;
            Console.WriteLine($"\n{myIntvar}");

            Console.ReadKey();
        }
    }
}
