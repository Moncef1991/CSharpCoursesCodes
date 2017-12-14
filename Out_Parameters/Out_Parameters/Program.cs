using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    class Program
    {
        static int Minvalue(int[] myArray2, out int myIndex)
        {
            int minVal = myArray2[0];
            myIndex = 0;

            for(int i=1; i < myArray2.Length; i++)
            {
                if(myArray2[i] < minVal)
                {
                    minVal = myArray2[i];
                    myIndex = i;
                }
                        
            }
            return minVal;

        }
        static void Main(string[] args)
        {
            int myIndex;
            int[] myArray = { 11, 10, 43, 6, 22, 8, 9, 13, 50, 22 };
            int minVal = Minvalue(myArray, out myIndex);
            Console.WriteLine($"The minimum value in my array is {minVal} and the index is {myIndex}");
            Console.ReadKey();
        }
    }
}
