using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Type
{
    delegate int MyNewNumber(int myNumber);

    class Program
    {
        static int myXNumber = 3;
        static int addFunct(int number)
        {
            myXNumber += number;
            return myXNumber;
        }
        static int mulFunct(int number)
        {
            myXNumber *= number;
            return myXNumber;
        }
        static void Main(string[] args)
        {
            MyNewNumber n1 = new MyNewNumber(addFunct);
            MyNewNumber n2 = new MyNewNumber(mulFunct);
            n1(4);
            Console.Write($"{myXNumber}");
            n2(9);
            Console.Write($"\n{myXNumber}");
            Console.ReadKey();



        }
    }
}
