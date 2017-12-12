using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName = { "Oussaf", "Moncef" };
            int myArrayLentgth = myFullName.Length;

            for (int i = 0; i < myArrayLentgth; i++)
            {
                Console.Write($"{myFullName[i]}" + " ");
            }
            Console.WriteLine($"\nMy array length is {myArrayLentgth}");

            foreach (string myName in myFullName)
            {
                Console.Write($"{myName}" + " ");
            }
            Console.ReadKey();
        }
    }
}
