using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethode
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine($"{args.Length} command line arguments has entered");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
            return 0;        }
    }
}
