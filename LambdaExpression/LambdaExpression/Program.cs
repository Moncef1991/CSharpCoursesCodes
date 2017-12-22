using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LambdaExpression
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myNumber = 3;
        static void Main(string[] args)
        {
            //MyNewNumber n = x => x + myNumber;
            //MyNewNumber n1 = x => x * myNumber;

            //Write($"My x number = {n(3)}\n");
            //Write($"My x number = {n1(4)}\n");
            //ReadKey();

            Func<int, bool> func = (x => x % 2 != 0);
            int[] myArray = { 1, 2, 4, 3, 5, 6, 7 };
            for (int i = 0; i < myArray.Length; i++)
                WriteLine(func.Invoke(myArray[i]));

            ReadKey();
        }
    }
}
