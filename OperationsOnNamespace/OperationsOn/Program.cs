using static System.Console;
using YB = Brothers.YoungBrothers.MyYoungBrothers;
using OB = Brothers.OldBrothers.MyOldBrothers;

namespace OperationsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Those are my familly");
            YB.print();
            OB.print();
            ReadKey();
        }
    }
}





