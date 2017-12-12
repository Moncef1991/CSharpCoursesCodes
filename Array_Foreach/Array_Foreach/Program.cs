using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;
            int[] myNumbers3 = new int[myArraySize] { 1, 5, 8, 9, 7 };

            for (int i = 0; i < 5; i++)
                Console.WriteLine("My numbers " + (i + 1) + "= " + $"{myNumbers3[i]}" + " ");

            foreach(int item in myNumbers3)
            {
                Console.WriteLine($"\nMy numbers {item}");
            }
            Console.ReadKey();
        }
    }
}
