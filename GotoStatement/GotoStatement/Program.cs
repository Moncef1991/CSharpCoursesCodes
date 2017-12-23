using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GotoStatement
{
    class Program
    {
        static int MyFunction()
        {
            int counter = 0;
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    if(j==5)
                    {
                        goto Mylebel;
                    }
                    counter++;
                }
            Mylebel:
                continue;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            //WriteLine(MyFunction());

            int counter = 0;
        myLable2:
            if (counter < 10)
            {
                counter++;
                goto myLable2;
            }
            else
                WriteLine("Done");
            WriteLine(counter);

            ReadKey();
        }
    }
}
