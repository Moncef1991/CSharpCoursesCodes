using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Moncef Oussaf";
            char[] myCharArray = myString.ToCharArray();
            Console.WriteLine($"My string length is {myString.Length}\n");

            foreach(char myChar in myCharArray)
            {
                Console.WriteLine($"{myChar}");
            }





            Console.ReadKey();

        }
    }
}
