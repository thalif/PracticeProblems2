using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int Dtimes = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);

            for (int i = 0; i < Dtimes; i++)
                N *= 100;

            Console.WriteLine(N);
            Console.ReadKey();
        }
    }
}
