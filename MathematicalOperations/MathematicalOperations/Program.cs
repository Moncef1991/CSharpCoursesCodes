using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - * / %

            int myVar1 = 15;
            int myVar2 = 10;
            int temp = myVar1 + myVar2;
            int temp2 = myVar2 - myVar1;
            int temp3 = myVar1 % myVar2;
            int temp4 = myVar1 / myVar2;
            int temp5 = myVar1 * myVar2;

            // + -

            int temp6 = +myVar1;
            int temp7 = -myVar1;

            string myString1 = "This is wonderful";
            string myString2 = "yes it is";


            Console.WriteLine("the result1 is = {0}\nthe result2 is = {1}\nthe result3 is = {2}\nthe result4 is = {3}\nthe result5 is = {4}\nthe result6 is = {5}\nthe result7 is = {6}", temp, temp2, temp3, temp4, temp5, temp6, temp7);
            Console.WriteLine("\n{0}\n{1}", myString1, myString2);
            Console.ReadKey();

        }
    }
}
