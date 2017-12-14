using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceValues_Challenge
{
    class Program
    {
        static void MultiplyNum1(ref int myVar1)
        {
            myVar1 *= 4;
            Console.WriteLine($"My number 1 is = {myVar1}");
        }

        static void MultiplyNum2(ref int myVar2)
        {
            myVar2 *= 4;
            Console.WriteLine($"My number 2 is = {myVar2}");
        }

        static void Main(string[] args)
        {
            int myNumber1 = 6, myNumber2 = 9;
            Console.WriteLine($"My number 1 before multiplication = {myNumber1}\nMy number 2 before multiplication = {myNumber2}");
            MultiplyNum1(ref myNumber1);
            MultiplyNum2(ref myNumber2);
            Console.WriteLine($"My number 1 after multiplication = {myNumber1}\nMy number 2 after multiplication = {myNumber2}");
            Console.ReadKey();
        }
    }
}
