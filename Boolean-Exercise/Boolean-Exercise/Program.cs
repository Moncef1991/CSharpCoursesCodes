using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 9, myVar2 = 11;
            bool myResult1 , myResult2;

            myResult1 = (myVar1 <10) && (myVar2<=11);
            myResult2 = (myVar1 < 10) || (myVar2 <= 11);

            Console.WriteLine("My result 1 is = {0}\nMy result 2 is = {1}", myResult1, myResult2);
            Console.ReadKey();

        }
    }
}
