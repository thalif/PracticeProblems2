using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] Inputs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = Inputs[0];
            long Ktimes = Inputs[1];
            
            for(long i = 0; i < Ktimes; i++)
            {
                long DD = Descend(N);
                long AA = Ascend(N);
                N =  Math.Abs(DD - AA);
            }
            Console.WriteLine(N);
        }
        static long Descend(long N)
        {
            long toReturn = 0;
            for(int i = 0; i <= 9; i++)
            {
                long CopyOfN = N;
                while(CopyOfN > 0)
                {
                    if (i == CopyOfN % 10)
                        toReturn = (toReturn * 10) + CopyOfN % 10;
                    CopyOfN = CopyOfN / 10;
                }
            }
            return toReturn;
        }
        static long Ascend(long N)
        {
            long toReturn = 0;
            for (int i = 9; i >= 0; i--)
            {
                long CopyOfN = N;
                while (CopyOfN > 0)
                {
                    if (i == CopyOfN % 10)
                        toReturn = (toReturn * 10) + CopyOfN % 10;
                    CopyOfN = CopyOfN / 10;
                }
            }
            return toReturn;
        }
    }
}
