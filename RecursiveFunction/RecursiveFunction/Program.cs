using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        static int MyRecursiveFunction(int myValue,ref int counter)
        {
            counter++;
            //if value=0
            if (myValue == 0)
                return 0;
            //if value less than 10
            else if(myValue<10)
            {
                return MyRecursiveFunction(myValue + 1, ref counter);

            }
            //ifvalue equal or exceeds 10
            return myValue;
        }
        static void Main(string[] args)
        {
            int counter = 0, myResult;
            myResult = MyRecursiveFunction(4, ref counter);
            Console.WriteLine($"My result is {myResult} and counter value is {counter}");
            Console.ReadKey();
        }
    }
}
