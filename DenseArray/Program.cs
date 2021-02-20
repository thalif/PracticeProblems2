using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());
            for (int k = 0; k < Ninputs; k++)
            {
                int GivenArrayLength = int.Parse(Console.ReadLine());
                List<int> GivenArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int i = 0; i < GivenArray.Count() - 1; i++)
                {
                    int Max = Math.Max(GivenArray[i], GivenArray[i + 1]);
                    int Min = Math.Min(GivenArray[i], GivenArray[i + 1]);
                    if (!ConditionPassed(Max, Min))
                    {
                        while (true)
                        {
                            Min++;
                            if (ConditionPassed(Max, Min))
                                break;
                        }
                        GivenArray.Insert(i + 1, Min);
                        i--;
                    }
                }
                Console.WriteLine(Math.Abs(GivenArrayLength - GivenArray.Count()));
            }
        }
        static bool ConditionPassed(int Max, int Min)
        {
            return (decimal)Max / (decimal)Min <= 2;
        }
    }
}
