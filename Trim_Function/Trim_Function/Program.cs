using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString2,  myString1;
            char[] mytrimChar = { 'h', 'e', 'i', ' ' };

            Console.WriteLine("Please enter your string");
            myString1 = Console.ReadLine();
            myString1 = myString1.ToLower();
            myString2 = myString1.Trim(mytrimChar);
            //myString2 = myString1.TrimEnd(mytrimChar);
            //myString2 = myString1.PadLeft(25, '-');
            //myString2 = myString1.PadRight(25, '-');


            Console.WriteLine($"{myString2}");
            Console.ReadKey();
        }
    }
}
