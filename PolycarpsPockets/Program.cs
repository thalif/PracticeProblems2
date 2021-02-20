using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolycarpsPockets
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ncoins = int.Parse(Console.ReadLine());
            int[] CoinBox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> CoinsCount = new Dictionary<int, int>();
            
            for (int i = 0; i < Ncoins; i++)
                if (CoinsCount.ContainsKey(CoinBox[i]))
                    CoinsCount[CoinBox[i]]++;
                else
                    CoinsCount.Add(CoinBox[i], 1);

            Console.WriteLine(CoinsCount.Values.Max());
        }
    }
}
