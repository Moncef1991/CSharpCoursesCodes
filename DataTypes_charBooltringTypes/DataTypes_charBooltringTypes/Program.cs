using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_charBooltringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myvarValue2 = Convert.ToChar(75);

            Console.WriteLine("Min char = {0} Max char = {1} My character = {2} my variable number = {3} my conversion value = {4}", charMin, charMax, myVar, myVarValue, myvarValue2);

            string myString = "This is my variable";
            Console.WriteLine("\nMy String is {0}", myString);

            bool myBool = false;
            Console.WriteLine("my boolean value is {0}", myBool);
            Console.ReadKey();
        }
    }
}
