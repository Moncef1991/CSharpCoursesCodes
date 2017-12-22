using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LambdaExpressionChallenge
{
    
        class Program
    {

        static void Main(string[] args)
        {
            Func<int,bool> function = (x => x > 10);
            int[] myArray = { 16, 26, 57, 7, 98, 0, 9, 97, 5, 4, 41 };
            
            for (int i = 0; i < myArray.Length; i++)
                
                if (myArray[i] > 10)

                WriteLine($"{function.Invoke(myArray[i])}" + $" the number {myArray[i]} is bigger than 10");

            ReadKey();

        }
    }
}
