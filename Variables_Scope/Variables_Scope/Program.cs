using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string myString;
        static void printmyString()
        {
           

            string myString = "My string inside th printmyString methode";
            Console.WriteLine($"{myString}");
            Console.WriteLine($"{Program.myString}");
        }
        static void Main(string[] args)
        {

            string myString = "My string inside th main methode";
            Program.myString = "Global myString variable";
            printmyString();

            Console.WriteLine($"{myString}");
            Console.WriteLine($"{Program.myString}");
            Console.ReadKey();
        }
    }
}
