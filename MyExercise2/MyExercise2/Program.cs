using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Moncef has said \"this is unique course\", and i think so";
            string myString2 = @"Moncef has said ""this is unique course"", and i think so";


            Console.WriteLine("{0}\n{1}", myString, myString2);
            Console.ReadKey();
        }
    }
}
