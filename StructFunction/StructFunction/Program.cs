using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructFunction
{
    class Program
    {
        struct FullName
        {
            public string myFirstName, myLastName;
            public string printName() => myFirstName + " " + myLastName;
        }

        static void Main(string[] args)
        {
            FullName myFullName;
            myFullName.myFirstName = "Moncef";
            myFullName.myLastName = "Oussaf";
            //Console.Write($"{myFullName.myFirstName} {myFullName.myLastName}");
            Console.Write(myFullName.printName());
            Console.ReadKey();
        }
    }
}
