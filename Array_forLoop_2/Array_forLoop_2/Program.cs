using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_forLoop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;
            int[] myNumbers1 = { 1, 5, 8, 7, 2 };
            int[] myNumbers2 = new int[myArraySize];
            int[] myNumbers3 = new int[myArraySize] { 1, 5, 8, 7, 2 };

            for (int i = 0; i < 5; i++)
            
                Console.WriteLine($"My number {i + 1} = {myNumbers1[i]}");
            
            Console.ReadKey();

        }
    }
}
