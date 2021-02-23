using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePercent
{
    class Program
    {
        static void Main(string[] args)
        {
            long TakahashiBalance = 100;
            long TakahashiExpects = int.Parse(Console.ReadLine());

            decimal pp = 1m / 1333333333m;
            decimal val = pp * 100;
            
            long OnePercent = ((TakahashiBalance - 1) / TakahashiBalance) * 100;
            Console.ReadKey();

        }
    }
}
