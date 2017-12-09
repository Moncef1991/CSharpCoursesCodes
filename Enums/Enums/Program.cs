using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum humanSex : sbyte
        {
            male = 1,
            female = 2

        }
        static void Main(string[] args)
        {
            sbyte humanSbyte;
            string humanGender;
            humanSex myHumansex = humanSex.male;
            Console.WriteLine($"Human sex = {myHumansex}" + "\n");
            humanSbyte = (sbyte)myHumansex;
            humanGender = Convert.ToString(myHumansex);
            Console.WriteLine($"Human Gender index in = {humanSbyte}" + "\n");
            Console.WriteLine($"Human associated with this index = {humanGender}" + "\n");
            Console.ReadKey();

        }
    }
}
