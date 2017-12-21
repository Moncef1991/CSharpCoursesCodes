using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace DebuggingMethods
{
    class Program
    {
        public static int addFunction(int x, int y)
        {
            Debug.WriteLine("We started here in the add function");
            int z = x + y;
            Debug.WriteLine("We are done here in the add function");
            return z;
        }
        public static int mulFunction(int x, int y)
        {
            Debug.WriteLine("We started here in the mult function");
            int z = x * y;
            Debug.WriteLine("We are done here in the mult function");
            Trace.WriteLine("We are done here in the mult function");
            return z;
        }
        public static void writeFunction(int z)
        {
            Debug.WriteLine("We are started here in the whrite function");
            WriteLine($"{z}");
            Debug.WriteLine("We are done here in the write function");
        }
        static void Main(string[] args)
        {
            int myNum, myVar = 4, myVar2 = 7;

            myNum = addFunction(myVar, myVar2);
            writeFunction(myNum);

            myNum = mulFunction(myVar, myVar2);
            writeFunction(myNum);

            ReadKey();
        }
    }
}
