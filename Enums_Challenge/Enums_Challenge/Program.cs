using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Challenge
{
    class Program
    {
        enum orientation : sbyte
        {
            north = 2,
            east =3,
            south = 4,
            west = 5
        }
        static void Main(string[] args)
        {
            sbyte orienSbyte;
            string myOrien;
            orientation myOrientation = orientation.east;
            Console.WriteLine($"The direction = {myOrientation}\n");
            orienSbyte = (sbyte)myOrientation;
            Console.WriteLine($"My direction index = {orienSbyte}\n");
            myOrien = Convert.ToString(myOrientation);
            Console.WriteLine($"Orientation associated with this index = {myOrien}");
            Console.ReadKey();
        }
    }
}
