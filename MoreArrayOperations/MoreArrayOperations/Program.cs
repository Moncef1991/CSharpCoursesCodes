using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrayOperations
{
    class Program
    {
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("Working with the class System.Array.");
            //Initialize items at startup.
            int[] myNumbers = new[] { 11, 2, 31, 14, 5 };

            //Array Rank...

            //Console.WriteLine("\nThe rank of array = {0}", myNumbers.Rank);

            //Print out numbers in declared order.
            //Console.WriteLine("Here is the array : ");
            //for (int i = myNumbers.GetLowerBound(0); i <= myNumbers.GetUpperBound(0); i++)
            //{
            //    Console.Write(myNumbers[i] + "\n");
            //}

            //Sort them...
            Array.Sort(myNumbers);
            Console.WriteLine("\n\nThe sorted array = ");
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.Write(myNumbers[i] + "\n");
            }
            Console.WriteLine("\n");

            //Reverse them...
            Array.Reverse(myNumbers);
            Console.WriteLine("\n\nThe reversed array is = ");
            for(int i=0;i<myNumbers.Length;i++)
            {
                Console.Write(myNumbers[i] + "\n");
            }
            Console.WriteLine("\n");

            //Clear out all but the final number.
            Console.WriteLine("Cleared all bet...");
            Array.Clear(myNumbers, 0, 3);
            for(int i=0;i<myNumbers.Length;i++)
            {
                Console.Write(myNumbers[i] + "\n");
            }

            string[] array2 = Array.ConvertAll(myNumbers, element => element.ToString());
            //Write string array
            Console.WriteLine(string.Join(";", array2));

        }
        static void Main(string[] args)
        {
            SystemArrayFunctionality();
            Console.ReadKey();
        }
    }
}
