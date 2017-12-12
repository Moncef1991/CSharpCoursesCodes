using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            double [][] myArrays = new double [3][];

            myArrays[0] = new double[6] { 1, 5, 8, 9, 6.4, 9 };
            myArrays[1] = new double[3] { 0, 4, 3 };
            myArrays[2] = new double[4] { 2, 9, 3, 10 };

            for (int i = 0; i < myArrays.Length; i++)
            {
                Console.Write($"Element({i})");

                for (int j=0; j < myArrays[i].Length;j++)
                {
                    Console.Write($"{myArrays[i][j]}" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
