using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myAminal = "Cat";

            switch (myAminal)
            {
                case "Canary":
                    Console.WriteLine("My animal is the canary bird");
                    break;
                case "Cat":
                    Console.WriteLine("My animal is a cat");
                    break;
                case "Camel":
                    Console.WriteLine("My animal is a camel");
                    break;
                default:
                    Console.WriteLine("No one");
                    break;
            }
            int myVar = 15;
            switch (myVar)
            {
                case 10:
                    Console.WriteLine("My variable number value is 10");
                    break;
                case 7:
                    Console.WriteLine("My variable number value is 7");
                    break;
                case 4:
                    Console.WriteLine("My variable number value is 4");
                    break;
                default:
                    Console.WriteLine("No one");
                    break;
            }
            Console.ReadKey();
        }
    }
}
