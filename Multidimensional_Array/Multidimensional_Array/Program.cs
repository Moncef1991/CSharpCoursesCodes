using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myNumbers = new int[,]
            {
                { 1, 2, 3, 4 },
                { 2, 3, 4, 5 },
                { 3, 4, 5, 6 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", myNumbers[i, j] + " ");

                }
                Console.WriteLine(" ");
            }

            int[,,] myArray3D = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 }, { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 }, { 10, 11, 12 }
                }
            };

            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    for(int k=0; k<3; k++)
                    {
                        Console.Write($"{myArray3D[i,j,k]}" + " ");

                    }
                    Console.Write("\t");

                }
                Console.WriteLine("\n");
            }
            
            Console.ReadKey();
        }
    }
}
