using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForLoop_Challenge
{
    class Program
    {
        enum directions
        {
            north    = 1,
            east     = 2,
            south    = 3,
            west     = 4
        }
        struct orientation
        {
            public directions directionType;
            public double distination;
        }
        static void Main(string[] args)
        {
            orientation myOrientation;
            int direction;
            double distance;
            Console.WriteLine("1) north\n2) east\n3) south\n4) west");
            do
            {
                Console.WriteLine("Enter your distination : ");
                direction = Convert.ToInt32(Console.ReadLine());
            }
            while ((direction < 1) || (direction > 4));

            Console.WriteLine("Enter your distance (km) : ");
            distance = Convert.ToDouble(Console.ReadLine());
            myOrientation.directionType = (directions)direction;
            myOrientation.distination = distance;
            Console.WriteLine($"your direction is {myOrientation.directionType} " + $"and your distance is {myOrientation.distination} km");
            Console.ReadKey();
        }
    }
}
