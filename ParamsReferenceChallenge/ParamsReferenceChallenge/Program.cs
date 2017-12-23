using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsReferenceChallenge
{
    class Program
    {
        static double MaxValue(params double[] values)
        {
            Console.WriteLine("You entered {0} values.", values.Length);
            double max = 0;

            if (values.Length == 0)
                return max;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            return max;

        }
        static void Main(string[] args)
        {
            double maxValue;
            maxValue = MaxValue(58.09, 93.27, 6.67, 1.44, 13);
            Console.WriteLine("The maximum value is : {0}", maxValue);
            Console.WriteLine();

            double[] data = { 40.09, 300.2, 445.7,0.98 };
            maxValue = MaxValue(data);
            Console.WriteLine("The maximum value is : {0}", maxValue);
            Console.WriteLine();

            Console.WriteLine("The maximum value is : {0}", MaxValue());

            Console.ReadKey();
        }
    }
}
