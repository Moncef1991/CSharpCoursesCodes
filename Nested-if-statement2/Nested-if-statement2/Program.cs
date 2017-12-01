using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 4, myVar2 = 6;
            if(myVar1 <= 3 && myVar2 >=6)
            {
                Console.WriteLine("Condition one right");
            }
            else if(myVar1 <=4 && myVar2 >= 6)
            {
                Console.WriteLine("Condition two right");
            }
            else if (myVar2 >=5)
            {
                Console.WriteLine("Condition three right");
            }
            else
            {
                Console.WriteLine("All the conditions are not right");
            }
            Console.ReadKey();
        }
    }
}
