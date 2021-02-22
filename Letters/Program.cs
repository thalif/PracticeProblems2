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
            string NInputs = Console.ReadLine();
            long[] Dormitory = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] Letters = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (long i = 0; i < Letters.Length; i++)
            {
                long CombineDormitory = 0;
                long Dorm = 0;
                while (true)
                {
                    CombineDormitory += Dormitory[Dorm];
                    if (Letters[i] <= CombineDormitory)
                    {
                        Console.WriteLine((Dorm + 1) + " " + Math.Abs((CombineDormitory - Dormitory[Dorm]) - (Letters[i])));
                        break;
                    }
                    Dorm++;
                }
            }
            Console.ReadKey();
        }
    }
}
