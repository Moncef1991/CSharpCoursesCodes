using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Foreach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 15;
            int[] myNumbers = new int[myArraySize] { 7, 9, 1, 0, 11, 5, 3, 13, 20, 14, 3, 9, 4, 6, 10 };
            int i = 0;
            foreach (int item in myNumbers) 
            {
                Console.WriteLine($"My number is {item}");
                i++;
                if (i > 13)
                    break;
               


            }
            Console.ReadKey();
            

        }
    }
}
