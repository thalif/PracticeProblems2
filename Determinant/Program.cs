using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] row1 = Console.ReadLine().Split(' ');
            string[] row2 = Console.ReadLine().Split(' ');
            Console.WriteLine((int.Parse(row1[0]) * int.Parse(row2[1])) - (int.Parse(row1[1]) * int.Parse(row2[0])));
        }
    }
}
