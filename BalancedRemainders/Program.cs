using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedRemainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());

            for(int i = 0; i < Ninputs; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] GivenArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Balancing(GivenArray, N);
            }
        }
        static void Balancing(int[] GivenArray, int N)
        {
            int CCC = N / 3;
            int[] Counts = new int[3];
            for (int k = 0; k < GivenArray.Length; k++)
            {
                int Remind = GivenArray[k] % 3;
                Counts[Remind]++;
            }

            int Move = 0;
            int i = 0;
            while (true)
            {
                if (Counts[i] > CCC)
                {
                    if (i == 2)
                    {
                        Move += Counts[i] - CCC;
                        Counts[0] += Counts[i] - CCC;
                        Counts[i] -= Counts[i] - CCC;
                        i = -1;
                    }
                    else
                    {
                        Move += Counts[i] - CCC;
                        Counts[i + 1] += Counts[i] - CCC;
                        Counts[i] -= Counts[i] - CCC;
                    }
                }
                if (Counts.Distinct().Count() == 1) break;
                i++;
            }
            Console.WriteLine(Move);
        }
    }
}
