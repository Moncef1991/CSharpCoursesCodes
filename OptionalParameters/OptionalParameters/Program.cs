using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        public static void PrintValues(string name="Moncef", int myValue=7)
        {
            Console.WriteLine($"Name = {name} \nNumber = {myValue}\n");
        }

        static void Main(string[] args)
        {
            string name = "Ahmed";
            int value = 15;
            PrintValues();
            PrintValues(name);
            PrintValues(name, value);
            PrintValues(name:"Houssem",myValue:6);
            Console.ReadKey();
        }
    }
}
