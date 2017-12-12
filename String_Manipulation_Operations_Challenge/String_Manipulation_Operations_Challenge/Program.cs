using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation_Operations_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString1 = "I am smart", myString2 = "He is", myString;
            myString = myString2 + (myString1.Substring(4));

            char[] myCharArray = myString.ToCharArray();

            foreach (char myCharStringArray in myCharArray)
            {
                Console.Write($"{myCharStringArray}" + " ");

            }
            Console.ReadKey();
            



           
            
        }
    }
}
