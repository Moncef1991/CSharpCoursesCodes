using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public static int printNumber(int myNumber)
        {
            return myNumber;
        }
        public static double printNumber(double myNumber)
        {
            return myNumber;
        }
     
        static void Main(string[] args)
        {
            int myNumber = 9;
            Console.Write($"{printNumber(myNumber)}");
            Console.ReadKey();
            
        }
    }
}
