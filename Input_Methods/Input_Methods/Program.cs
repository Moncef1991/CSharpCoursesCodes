using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Readline , Read

            //string myNAME, myStrnumber;
            //int myVar1, myVar2;
            char myVar3;

            //Console.WriteLine("Please enter your name \n");
            //myNAME = Console.ReadLine();

            //Console.WriteLine("\nPlease enter your first number \n");
            //myStrnumber = Console.ReadLine();
            //myVar1 = Convert.ToInt32(myStrnumber);

            //Console.WriteLine("\nWrite your caracter");
            //myVar2 = Console.Read();

            Console.WriteLine("\nWrite your second caracter\n");
            myVar3 = Convert.ToChar(Console.Read());
           

            //Console.WriteLine($"\nHello {myNAME}");
            //Console.WriteLine($"\nYou entered the number {myVar1}");
           // Console.WriteLine($"\nYou entered your caracter {myVar2}");
            Console.WriteLine($"\nYou entered your second caracter {myVar3}");
            Console.ReadKey();










        }
    }
}
