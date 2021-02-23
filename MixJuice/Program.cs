using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixJuice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputL1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] Fruits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int K = InputL1[1];
            int Sum = 0;

            int LastSmallestIndex = 0;
            for(int k = 0; k < K; k++)
            {
                int Smallest = int.MaxValue;
                for (int i = 0; i < Fruits.Length; i++)
                {
                    if (Smallest > Fruits[i])
                    {
                        Smallest = Fruits[i];
                        LastSmallestIndex = i;
                    }
                }
                Fruits[LastSmallestIndex] = int.MaxValue;
                Sum += Smallest;
            }
            Console.WriteLine(Sum);
        }
    }
}
