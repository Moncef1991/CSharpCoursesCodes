using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace AssertionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Enter a value");
            int i = Convert.ToInt32(ReadLine());
            if(i >= 100)
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We are here");
                Debug.Assert(i >= 100, "Short", "Long");
            }
            WriteLine("Done");
            ReadKey();
        }
    }
}
