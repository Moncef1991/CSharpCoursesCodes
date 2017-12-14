using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceValue
{
    class Program
    {
        static void multipleNum(ref int myVar)
        {
            myVar *= 3;
            Console.WriteLine($"My number = {myVar}");
        }
        static void Main(string[] args)
        {
            int myNumber = 5;
            Console.WriteLine($"My number = {myNumber}");
            multipleNum(ref myNumber);
            Console.WriteLine($"My number = {myNumber}");
            Console.ReadKey();
        }
    }
}
