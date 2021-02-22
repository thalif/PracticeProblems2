using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 100 == 0)
                Console.WriteLine(100);
            else
                Console.WriteLine(100 - (N % 100));
        }
    }
}
