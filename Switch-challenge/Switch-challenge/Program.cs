using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string whathesay = "Hello";

            switch (whathesay)
            {
                case "hello":
                    Console.WriteLine("He say hello");
                    break;
                case "Bye":
                    Console.WriteLine("He say bye");
                    break;
                case "welcome":
                    Console.WriteLine("He say welcome");
                    break;
                default:
                    Console.WriteLine("No one");
                    break;

            }
            Console.ReadKey();
        }
    }
}
