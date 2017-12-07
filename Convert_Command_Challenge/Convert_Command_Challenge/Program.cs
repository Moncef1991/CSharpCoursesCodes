using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloatvar = 45.56f;
            string myString, mySubString;

            myString = Convert.ToString(myFloatvar);
            mySubString = myString.Substring(2,3);

            Console.WriteLine($"My float variable is {myFloatvar}");
            Console.WriteLine($"My string variable is {myString}\nMy substring variable is {mySubString}");
            Console.ReadKey();
        }
    }
}
