using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //\' \" \\ \0 \a \b \n \r \t \v \f
            //@

            string myString = "I'm Moncef Oussaf , and this is me not you";
            string myString2 = @"F:\LocalRepository\CSharpCourseCodes";
            string myString3 = myString + myString2;


            Console.WriteLine("{0}", myString3);
            Console.ReadKey();


        }
    }
}
