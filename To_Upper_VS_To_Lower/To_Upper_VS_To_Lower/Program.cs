using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Upper_VS_To_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString2, myString4, myString3,myString5, myString1;
            char[] mytrimChar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("Please enter your string");
            myString1 = Console.ReadLine();
            myString2 = myString1.ToUpper();
            myString3 = myString1.ToLower();
            myString4 = myString1.Trim();
            myString5 = myString1.Trim(mytrimChar);

            Console.WriteLine($"{myString2}");
            Console.WriteLine($"{myString3}");
            Console.WriteLine($"{myString4}");
            Console.WriteLine($"{myString5}");

            Console.ReadKey();

        }
    }
}
