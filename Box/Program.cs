using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine((Inputs[0] - Inputs[1]) + Inputs[2]);
        }
    }
}
