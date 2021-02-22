using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] FiveVariables = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ZerosPostion = 0;
            for (int i = 0; i < FiveVariables.Length; i++)
                if (FiveVariables[i] == 0)
                    ZerosPostion = i + 1;
            Console.WriteLine(ZerosPostion);
        }
    }
}
