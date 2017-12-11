using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForLoop2_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 3, 10, 14, 55, 0, 1, 0, 12 };
            int maxValue = 0;
            
            for (int i = 0; i < 7; i++)
            {
                if (maxValue < myNumbers[i])
                {
                    maxValue = myNumbers[i];
                }
               
            }
            Console.WriteLine($"The max value is = {maxValue}");
            Console.ReadKey();
             
        }
    }
}
