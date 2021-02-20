using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input1 = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[] Dormitory = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] Letters = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            foreach(long letterNo in Letters)
            {
                long DormOF = GuessDormitory(Dormitory, letterNo);
                
                long DormitorySum = 0;
                for (long i = 0; i < DormOF; i++)
                    DormitorySum += Dormitory[i];

                Console.WriteLine(DormOF + " " + (Dormitory[DormOF - 1] - (DormitorySum - letterNo)));
            }
        }

        static long GuessDormitory(long[] arr, long letterNo)
        {
            long DormOf = 0;
            long DormitorySum = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                DormitorySum += arr[i];
                DormOf = i + 1;
                if (DormitorySum >= letterNo)
                    break;
            }
            return DormOf;
        }
    }
}
