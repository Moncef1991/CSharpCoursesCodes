using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;
            int myVar2 = 3;

            int opr1 = myVar1 + myVar2;
            int opr2 = myVar1 - myVar2;
            int opr3 = myVar1 * myVar2;
            int opr4 = myVar1 / myVar2;
            int opr5 = myVar1 % myVar2;

            string myString1 = "I am";
            string myString2 = " smart";

            string myString3 = myString1 + myString2;

            Console.WriteLine("result 1 = {0}\nresult 2 = {1}\nresult 3 = {2}\nresult 4 = {3}\nresult 5 = {4}", opr1, opr2, opr3, opr4, opr5);
            Console.WriteLine("\nthe string result is {0}", myString3);
            Console.ReadKey();
        }
    }
}
