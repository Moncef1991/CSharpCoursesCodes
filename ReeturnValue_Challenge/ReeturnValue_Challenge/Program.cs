using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReeturnValue_Challenge
{
    class Program
    {
        static double average(double[] grades)
        { 
            double som = 0, averageStudent;
        
            for(int i = 0;i < grades.Length; i++)
            {
                  som += grades[i];
                  
            }
            averageStudent = som / grades.Length;
        return averageStudent;

        }
        static void Main(string[] args)
        {
            double[] myGrades = { 12, 7, 9, 15, 5.5, 10.75, 17 };
            double myAverage = average(myGrades);
            Console.WriteLine($"My average is = {myAverage}");
            Console.ReadKey();
        }
    }
}
