using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    class Program
    {
        static int minValue(int[] myArray)
        {
            int minVal = myArray[0];
            for (int i = 1; i < myArray.Length; i++) 
            {
                if (myArray[i] < minVal)
                    minVal = myArray[i];
            }
            return minVal;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 11, 10, 3, 6, 2, 8, 9, 3, 50, 2 };
            int minVal = minValue(myArray);
            Console.WriteLine($"The minimum value in myArray is {minVal}");
            Console.ReadKey();
         
        }
    }
}
