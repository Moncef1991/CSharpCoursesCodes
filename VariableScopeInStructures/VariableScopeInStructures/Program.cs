using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScopeInStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, index = 0;
            for(i = 0;i < 10; i++)
            {
                index = i;
                Console.WriteLine($"{index}");

            }
            Console.WriteLine($"Last index output in loop : {index}");
            Console.ReadKey();
        }
    }
}
