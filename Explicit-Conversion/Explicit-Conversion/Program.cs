using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type1 = (Type1)Type2                 //Casting

            byte mySbyte;
            int myInt = 350;

            // mySbyte = myInt;

            mySbyte = unchecked((byte)myInt);

            Console.WriteLine($"My variable int = {myInt}" + "\n");
            Console.WriteLine($"My byte variable = {mySbyte}");
            Console.ReadKey();
        }
    }
}
