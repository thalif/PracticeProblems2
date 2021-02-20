using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanyaandStairways
{
    class Program
    {
        static void Main(string[] args)
        {
            int NStairs = int.Parse(Console.ReadLine());
            int[] TanyasData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int Stepped = 1;
            List<int> SteppedCount = new List<int>();
            for (int i = 0; i < NStairs - 1; i++)
                if (TanyasData[i] >= TanyasData[i + 1])
                {
                    Stepped++;
                    SteppedCount.Add(TanyasData[i]);
                }

            SteppedCount.Add(TanyasData[NStairs - 1]);

            Console.WriteLine(Stepped);
            foreach (int SteppedAt in SteppedCount)
                Console.Write(SteppedAt + " ");
        }
    }
}
