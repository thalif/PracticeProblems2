using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(A, 2) + Math.Pow(A, 3) + A);
        }
    }
}
