using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_looplchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For all numbers\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("For even number\n");
            for (int t = 2; t <= 6; t += 2)
            {
                for (int s = 0; s <= 10; s++)
                {
                    Console.WriteLine("{0} * {1} = {2}", t, s, t * s);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("For odd number\n");
            for (int x = 2; x <= 6; x += 2)
            {
                for (int y = 0; y <= 10; y++)
                {
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }

    }
}
