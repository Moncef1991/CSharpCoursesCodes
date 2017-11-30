using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 5;
            int temp1 = myVar1++;
            int temp2 = ++myVar1;

            Console.WriteLine("{0}\n{1}", temp1, temp2);

            int myVar2 = 7;
            int myVar3 = 2;

            int temp3 = myVar2-- / ++myVar3;

            Console.WriteLine("\n\n{0}", temp3);
            Console.ReadKey();

        }
    }
}
