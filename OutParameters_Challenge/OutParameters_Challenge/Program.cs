using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters_Challenge
{
    class Program
    {
        static double Average(double[] grades, out double gradeAverage)
        {
            double som = 0, averageStudent;
            gradeAverage = 10;

            for (int i = 0; i < grades.Length; i++)
            {
                som += grades[i];
            }
            averageStudent = som / grades.Length;
            Console.WriteLine($"Your average is = {averageStudent}\n");

            if (gradeAverage >= 10)
            {
                Console.WriteLine("You are graduated student");
            }
            else
            {
                Console.WriteLine("You are drop-out");
            }
            return averageStudent;
        }
            static void Main(string[] args)
        {
            double gradeAverage;
            double[] myGrades = { 12, 7, 9, 15, 5.5, 10.75, 17 };
            double myAverage = Average(myGrades, out gradeAverage);
            
            Console.ReadKey();
        }
    }
}
