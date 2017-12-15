using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadin_Challenge
{
    class Program
    {
        public static int MinValue(int[] myArray)
        {
            int minVal = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (minVal > myArray[i])
                {
                    minVal = myArray[i];
                }
            }
            Console.WriteLine($"The minimum int value = {minVal}\n");
            return minVal;
        }

        public static double MinValue(double[] myArray)
        {
            double minVal = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (minVal > myArray[i])
                {
                    minVal = myArray[i];
                }
            }
            Console.WriteLine($"The minimum int value = {minVal}\n");
            return minVal;
        }
    
        static void Main(string[] args)
        {
            int[] myArray1 = { 4, 6, 9, 14, 97, 99, 2 , 67};
            double[] myArray2 = { 1.09 , 7.8, 18, 2.5, 8.4, 3, 4.78 };
            MinValue(myArray1);
            MinValue(myArray2);
            Console.ReadKey();
        }
    }
}
 